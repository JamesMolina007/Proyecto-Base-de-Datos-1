using System;
using System.Data;
using System.Windows.Forms;

namespace ProyectoDB
{
    public partial class ClienteProcesaOrdenFrm : Form
    {
        private int seguimiento;

        private int id_Cliente;
        public void setId_Cliente(int id_Cliente)
        {
            this.id_Cliente = id_Cliente;
        }

        private double total;
        public void setTotal(double total)
        {
            this.total = total;
        }

        private double isv;
        public void setIsv(double isv)
        {
            this.isv = isv;
        }

        private DataGridView carrito;
        public void setCarrito(DataGridView carrito)
        {
            this.carrito = carrito;
        }

        public ClienteProcesaOrdenFrm()
        {
            InitializeComponent();
        }

        private void ClienteProcesaOrdenFrm_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'productosDataSet.Producto' Puede moverla o quitarla según sea necesario.
            this.productoTableAdapter.Fill(this.productosDataSet.Producto);
            // TODO: esta línea de código carga datos en la tabla 'carritoClienteDataSet.Carrito' Puede moverla o quitarla según sea necesario.
            this.carritoTableAdapter.Fill(this.carritoClienteDataSet.Carrito);
            // TODO: esta línea de código carga datos en la tabla 'tiendaDataSet.Tienda' Puede moverla o quitarla según sea necesario.

            //// TODO: esta línea de código carga datos en la tabla 'facturasDataSet.DetalleFactura' Puede moverla o quitarla según sea necesario.
            //this.detalleFacturaTableAdapter.Fill(this.facturasDataSet.DetalleFactura);
            //// TODO: esta línea de código carga datos en la tabla 'facturasDataSet.Factura' Puede moverla o quitarla según sea necesario.
            this.facturaTableAdapter.Fill(this.facturasDataSet.Factura);
            //// TODO: esta línea de código carga datos en la tabla 'contratoDataSet.Contrato' Puede moverla o quitarla según sea necesario.
            //this.contratoTableAdapter.Fill(this.contratoDataSet.Contrato);
            this.tiendaTableAdapter.Fill(this.tiendaDataSet.Tienda);
            this.empresaDeEnvioTableAdapter.Fill(this.empresasDeEnvioDataSet.EmpresaDeEnvio);
            this.ordenTableAdapter.Fill(this.ordenDataSet.Orden);
            DataRowView drvOrden = (DataRowView)OrdenBindingSource.Current;
            seguimiento = Convert.ToInt32(drvOrden["noSeguimiento"])+1;
            OrdenBindingSource.AddNew();
            ContratoBindingSource.AddNew();
            //FacturaDetalleBindingSource.AddNew();
            FacturaEncabezadoBindingSource.AddNew();
            lbl_Cuota.Text = total.ToString();
            
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            DataRowView drvOrden = (DataRowView)OrdenBindingSource.Current;
            DataRowView drvContrato = (DataRowView)ContratoBindingSource.Current;
            DataRowView drvFacturaEncabezado = (DataRowView)FacturaEncabezadoBindingSource.Current;
            drvOrden.Row["idCliente"] = id_Cliente;
            try
            {
                drvFacturaEncabezado.Row["Direccion"] = tb_Direccion.Text;
                drvFacturaEncabezado.Row["FechaEmision"] = DateTime.Now;
                drvFacturaEncabezado.Row["idCliente"] = id_Cliente;
                this.FacturaEncabezadoBindingSource.EndEdit();
                this.facturaTableAdapter.Update(this.facturasDataSet.Factura);

                drvContrato.Row["Cuota"] = Convert.ToDouble(lbl_Cuota.Text);
                drvContrato.Row["idCliente"] = id_Cliente;
                this.ContratoBindingSource.EndEdit();
                this.contratoTableAdapter.Update(this.contratoDataSet.Contrato);
                drvFacturaEncabezado = (DataRowView)FacturaEncabezadoBindingSource.Current;
                for (int i = 0; i < carrito.RowCount; i++)
                {
                    ProductosBindingSource.Filter = string.Format("convert(idProducto, 'System.String') Like '{0}' ", Convert.ToInt32(carrito.Rows[i].Cells[0].Value));
                    DataRowView drvProducto = (DataRowView)ProductosBindingSource.Current;
                    if (Convert.ToInt32(drvProducto["Cantidad"]) - Convert.ToInt32(carrito.Rows[i].Cells[2].Value) > 0)
                    {
                        DataRowView drvFacturaDetalle = (DataRowView)FacturaDetalleBindingSource.AddNew();
                        drvFacturaDetalle["idProducto"] = carrito.Rows[i].Cells[0].Value;
                        drvFacturaDetalle["cantidadProducto"] = carrito.Rows[i].Cells[2].Value;
                        drvFacturaDetalle["Total"] = total;
                        drvFacturaDetalle["isv"] = isv;
                        drvFacturaDetalle["NoFactura"] = drvFacturaEncabezado["noFactura"];
                        this.FacturaDetalleBindingSource.EndEdit();
                        this.detalleFacturaTableAdapter.Update(this.facturasDataSet.DetalleFactura);
                        drvProducto["Cantidad"] = Convert.ToInt32(drvProducto["Cantidad"]) - Convert.ToInt32(carrito.Rows[i].Cells[2].Value);
                    }
                    else
                        MessageBox.Show("No se puede llevar más producto de lo que hay disponible");
                }
                ProductosBindingSource.EndEdit();
                productoTableAdapter.Update(this.productosDataSet.Producto);
                this.Validate();
                drvOrden.Row["noSeguimiento"] = seguimiento;
                drvOrden.Row["Estatus"] = "En Proceso";
                this.OrdenBindingSource.EndEdit();
                this.ordenTableAdapter.Update(this.ordenDataSet.Orden);
                MessageBox.Show("Compra realizada exitosamente!!");
                carritoTableAdapter.FillByDeleteCliente(this.carritoClienteDataSet.Carrito, id_Cliente);
                this.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }


        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            lbl_Cuota.Text = (total/Convert.ToDouble(ne_Meses.Value)).ToString();
        }
    }
}
