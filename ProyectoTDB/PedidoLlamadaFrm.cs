using System;
using System.Data;
using System.Windows.Forms;

namespace ProyectoDB
{
    public partial class PedidoLlamadaFrm : Form
    {

        public DataGridView carro;
        public int idCliente;
        public int tienda;
        public PedidoLlamadaFrm()
        {
            InitializeComponent();
        }

        private void PedidoLlamadaFrm_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'productosDataSet.Producto' Puede moverla o quitarla según sea necesario.
            this.productoTableAdapter.Fill(this.productosDataSet.Producto);
            // TODO: esta línea de código carga datos en la tabla 'inventarioDataSet.Inventario' Puede moverla o quitarla según sea necesario.
            this.inventarioTableAdapter.Fill(this.inventarioDataSet.Inventario);
            //// TODO: esta línea de código carga datos en la tabla 'facturasDataSet.Factura' Puede moverla o quitarla según sea necesario.
            this.facturaTableAdapter.Fill(this.facturasDataSet.Factura);
            //// TODO: esta línea de código carga datos en la tabla 'facturasDataSet.DetalleFactura' Puede moverla o quitarla según sea necesario.
            this.detalleFacturaTableAdapter.Fill(this.facturasDataSet.DetalleFactura);
            tb_Tienda.Text = tienda.ToString();
            FacturaBindingSource.AddNew();
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            DataRowView drvFacturaEncabezado = (DataRowView)FacturaBindingSource.Current;
            try
            {
                
                drvFacturaEncabezado.Row["Direccion"] = tb_Direccion.Text;
                drvFacturaEncabezado.Row["FechaEmision"] = DateTime.Now;
                drvFacturaEncabezado.Row["idCliente"] = idCliente;
                drvFacturaEncabezado.Row["codigoTienda"] = tienda;
                this.FacturaBindingSource.EndEdit();
                this.facturaTableAdapter.Update(this.facturasDataSet.Factura);
                facturaTableAdapter.Fill(this.facturasDataSet.Factura);
                drvFacturaEncabezado = (DataRowView)FacturaBindingSource.Current;
                for (int i = 0; i < carro.RowCount; i++)
                {
                    InventarioBindingSource.Filter = string.Format("convert(idProducto, 'System.String') = '{0}' ", Convert.ToInt32(carro.Rows[i].Cells[0].Value));
                    ProductosBindingSource.Filter = string.Format("convert(idProducto, 'System.String') = '{0}' ", Convert.ToInt32(carro.Rows[i].Cells[0].Value));
                    DataRowView drvProducto = (DataRowView)ProductosBindingSource.Current;
                    DataRowView drvInventario = (DataRowView)InventarioBindingSource.Current;
                    if (Convert.ToInt32(drvProducto["Cantidad"]) - Convert.ToInt32(carro.Rows[i].Cells[2].Value) > 0)
                    {
                        DataRowView drvFacturaDetalle = (DataRowView)DetalleFacturaBindingSource.AddNew();
                        drvFacturaDetalle["idProducto"] = carro.Rows[i].Cells[0].Value;
                        drvFacturaDetalle["cantidadProducto"] = carro.Rows[i].Cells[2].Value;
                        drvFacturaDetalle["Total"] = Convert.ToInt32(drvProducto["Precio"]) * Convert.ToInt32(carro.Rows[i].Cells[2].Value) * 1.15;
                        drvFacturaDetalle["isv"] = Convert.ToInt32(drvProducto["Precio"]) * Convert.ToInt32(carro.Rows[i].Cells[2].Value) * 0.15;
                        drvFacturaDetalle["NoFactura"] = drvFacturaEncabezado["noFactura"];
                        this.DetalleFacturaBindingSource.EndEdit();
                        this.detalleFacturaTableAdapter.Update(this.facturasDataSet.DetalleFactura);
                        drvInventario["Cantidad"] = Convert.ToInt32(drvInventario["Cantidad"]) - Convert.ToInt32(carro.Rows[i].Cells[2].Value);
                        InventarioBindingSource.EndEdit();
                        inventarioTableAdapter.Update(this.inventarioDataSet.Inventario);
                    }
                    else
                        MessageBox.Show("No se puede llevar más producto de lo que hay disponible");

                }
                this.Validate();
                MessageBox.Show("Compra realizada exitosamente!!");
                this.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }
    }
}
