using System;
using System.Data;
using System.Windows.Forms;

namespace ProyectoDB
{
    public partial class ClienteProcesaOrdenFrm : Form
    {

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
            // TODO: esta línea de código carga datos en la tabla 'carritoClienteDataSet.Carrito' Puede moverla o quitarla según sea necesario.
            this.carritoTableAdapter.Fill(this.carritoClienteDataSet.Carrito);
            // TODO: esta línea de código carga datos en la tabla 'tiendaDataSet.Tienda' Puede moverla o quitarla según sea necesario.

            //// TODO: esta línea de código carga datos en la tabla 'facturasDataSet.DetalleFactura' Puede moverla o quitarla según sea necesario.
            //this.detalleFacturaTableAdapter.Fill(this.facturasDataSet.DetalleFactura);
            //// TODO: esta línea de código carga datos en la tabla 'facturasDataSet.Factura' Puede moverla o quitarla según sea necesario.
            //this.facturaTableAdapter.Fill(this.facturasDataSet.Factura);
            //// TODO: esta línea de código carga datos en la tabla 'contratoDataSet.Contrato' Puede moverla o quitarla según sea necesario.
            //this.contratoTableAdapter.Fill(this.contratoDataSet.Contrato);
            this.tiendaTableAdapter.Fill(this.tiendaDataSet.Tienda);
            this.empresaDeEnvioTableAdapter.Fill(this.empresasDeEnvioDataSet.EmpresaDeEnvio);
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
            DataRowView drvFacturaDetalle = (DataRowView)FacturaDetalleBindingSource.Current;
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

                this.Validate();
                this.OrdenBindingSource.EndEdit();
                this.ordenTableAdapter.Update(this.ordenDataSet.Orden);

                MessageBox.Show("Guardado Correctamente");
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
