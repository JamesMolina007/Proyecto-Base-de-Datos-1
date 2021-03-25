using System;
using System.Data;
using System.Windows.Forms;

namespace ProyectoDB
{
    public partial class VistaUnoFrm : Form
    {
        private int seguimiento;
        public VistaUnoFrm()
        {
            InitializeComponent();
        }

        private void VistaUnoFrm_Load(object sender, EventArgs e)
        {
            this.ordenTableAdapter.Fill(this.ordenDataSet.Orden);
            this.detalleFacturaTableAdapter.Fill(this.facturasDataSet.DetalleFactura);
            this.facturaTableAdapter.Fill(this.facturasDataSet.Factura);
            this.ordenDestruidaTableAdapter.Fill(this.vistasDataSet.OrdenDestruida);
            DataRowView drvOrden = (DataRowView)OrdenBindingSource.Current;
            if (drvOrden != null)
            {
                seguimiento = Convert.ToInt32(drvOrden["noSeguimiento"]) + 1;
            }
            else
            {
                seguimiento = 1000000;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataRowView drDestruido = (DataRowView)PrincipalBindingSource.Current;
            int facturaBorrar = Convert.ToInt32(drDestruido["noFactura"]);
            int ordenBorrar = Convert.ToInt32(drDestruido["noOrden"]);

            DataRowView drEncabezado = (DataRowView)EncabezadoFacturaBindingSource.AddNew();
            drEncabezado["Direccion"] = drDestruido["direccionEnvio"];
            drEncabezado["RTN"] = Convert.ToInt32(drDestruido["RTN"]);//--------
            drEncabezado["FechaEmision"] = DateTime.Now;
            drEncabezado["idCliente"] = Convert.ToInt32(drDestruido["idCliente"]);//---------------
            drEncabezado["codigoTienda"] = Convert.ToInt32(drDestruido["codigoTienda"]);//--------------
            EncabezadoFacturaBindingSource.EndEdit();
            facturaTableAdapter.Update(this.facturasDataSet.Factura);
            drEncabezado = (DataRowView)EncabezadoFacturaBindingSource.Current;

            DataRowView drOrden = (DataRowView)OrdenBindingSource.AddNew();
            drOrden["nombreRemitente"] = drDestruido["nombreRemitente"];
            drOrden["empresaEnvio"] = drDestruido["empresaEnvio"];
            drOrden["direccionEnvio"] = drDestruido["direccionEnvio"];
            drOrden["noSeguimiento"] = seguimiento;
            drOrden["idCliente"] = Convert.ToInt32(drDestruido["idCliente"]);//---------------------
            drOrden["Estatus"] = "En Proceso";
            drOrden["noFactura"] = Convert.ToInt32(drEncabezado["noFactura"]);
            OrdenBindingSource.EndEdit();
            ordenTableAdapter.Update(this.ordenDataSet.Orden);

            foreach (DataRowView drInformacion in PrincipalBindingSource)
            {
                DataRowView drDetalle = (DataRowView)DetalleFacturaBindingSource.AddNew();
                drDetalle["isv"] = Convert.ToInt32(drInformacion["isv"]);
                drDetalle["total"] = Convert.ToInt32(drInformacion["Total"]);
                drDetalle["cantidadProducto"] = Convert.ToInt32(drInformacion["cantidadProducto"]);
                drDetalle["NoFactura"] = Convert.ToInt32(drEncabezado["noFactura"]);
                drDetalle["idProducto"] = Convert.ToInt32(drInformacion["idProducto"]);
            }
            DetalleFacturaBindingSource.EndEdit();
            detalleFacturaTableAdapter.Update(this.facturasDataSet.DetalleFactura);
            facturaTableAdapter.DeleteQuery(facturaBorrar);
            ordenTableAdapter.DeleteQuery(ordenBorrar);
            MessageBox.Show("Reemplazado correctamente");
            this.Close();
        }
    }
}
