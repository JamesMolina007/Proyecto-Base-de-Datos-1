using System;
using System.Data;
using System.Windows.Forms;

namespace ProyectoDB
{
    public partial class ConsultaFacturaClienteFrm : Form
    {
        private int idCliente;
        public void setIdCliente( int idCliente)
        {
            this.idCliente = idCliente;
        }
        public ConsultaFacturaClienteFrm()
        {
            InitializeComponent();
        }

        private void ConsultaFacturaClienteFrm_Load(object sender, EventArgs e)
        {
            this.facturaTableAdapter.FillByFactura(this.facturasDataSet.Factura, idCliente);
            this.productoTableAdapter.Fill(this.productosDataSet.Producto);
            DataRowView drvFactura = (DataRowView)FacturaBindingSource.Current;
            this.detalleFacturaTableAdapter.FillByFactura(this.facturasDataSet.DetalleFactura, Convert.ToInt32(drvFactura["noFactura"]));
        }

        private void FacturaBindingSource_PositionChanged(object sender, EventArgs e)
        {
            DataRowView drvFactura = (DataRowView)FacturaBindingSource.Current;
            this.detalleFacturaTableAdapter.FillByFactura(this.facturasDataSet.DetalleFactura, Convert.ToInt32(drvFactura["noFactura"]));
        }
    }
}
