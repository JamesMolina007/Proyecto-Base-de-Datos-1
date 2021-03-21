using System;
using System.Data;
using System.Runtime.InteropServices;
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
            this.productoTableAdapter.Fill(this.productosDataSet.Producto);
            this.carritoTableAdapter.Fill(this.carritoClienteDataSet.Carrito);
            this.facturaTableAdapter.Fill(this.facturasDataSet.Factura);
            this.tiendaTableAdapter.Fill(this.tiendaDataSet.Tienda);
            this.empresaDeEnvioTableAdapter.Fill(this.empresasDeEnvioDataSet.EmpresaDeEnvio);
            this.ordenTableAdapter.Fill(this.ordenDataSet.Orden);
            DataRowView drvOrden = (DataRowView)OrdenBindingSource.Current;
            if (drvOrden != null)
            {
                seguimiento = Convert.ToInt32(drvOrden["noSeguimiento"]) + 1;
                OrdenBindingSource.AddNew();
            }
            else
            {
                drvOrden = (DataRowView)OrdenBindingSource.AddNew();
                drvOrden["noSeguimiento"] = 1000000;
            }
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
            DataRowView drvFacturaEncabezado = (DataRowView)FacturaEncabezadoBindingSource.Current;
            drvOrden.Row["idCliente"] = id_Cliente;
            try
            {
                drvFacturaEncabezado.Row["Direccion"] = tb_Direccion.Text;
                drvFacturaEncabezado.Row["FechaEmision"] = DateTime.Now;
                drvFacturaEncabezado.Row["idCliente"] = id_Cliente;
                this.FacturaEncabezadoBindingSource.EndEdit();
                this.facturaTableAdapter.Update(this.facturasDataSet.Factura);
                facturaTableAdapter.Fill(this.facturasDataSet.Factura);
                drvFacturaEncabezado = (DataRowView)FacturaEncabezadoBindingSource.Current;
                for (int i = 0; i < carrito.RowCount; i++)
                {
                    ProductosBindingSource.Filter = string.Format("convert(idProducto, 'System.String') = '{0}' ", Convert.ToInt32(carrito.Rows[i].Cells[0].Value));
                    DataRowView drvProducto = (DataRowView)ProductosBindingSource.Current;
                    if (Convert.ToInt32(drvProducto["Cantidad"]) - Convert.ToInt32(carrito.Rows[i].Cells[2].Value) > 0)
                    {
                        DataRowView drvFacturaDetalle = (DataRowView)FacturaDetalleBindingSource.AddNew();
                        drvFacturaDetalle["idProducto"] = carrito.Rows[i].Cells[0].Value;
                        drvFacturaDetalle["cantidadProducto"] = carrito.Rows[i].Cells[2].Value;
                        drvFacturaDetalle["Total"] = Convert.ToInt32(drvProducto["Precio"]) * Convert.ToInt32(carrito.Rows[i].Cells[2].Value) * 1.15;
                        drvFacturaDetalle["isv"] = Convert.ToInt32(drvProducto["Precio"])* Convert.ToInt32(carrito.Rows[i].Cells[2].Value)*0.15;
                        drvFacturaDetalle["NoFactura"] = drvFacturaEncabezado["noFactura"];
                        this.FacturaDetalleBindingSource.EndEdit();
                        this.detalleFacturaTableAdapter.Update(this.facturasDataSet.DetalleFactura);
                        drvProducto["Cantidad"] = Convert.ToInt32(drvProducto["Cantidad"]) - Convert.ToInt32(carrito.Rows[i].Cells[2].Value);
                    }
                    else
                        MessageBox.Show("No se puede llevar más producto de lo que hay disponible");
                    ProductosBindingSource.EndEdit();
                    productoTableAdapter.Update(this.productosDataSet.Producto);
                }
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
