using System;
using System.Data;
using System.Windows.Forms;

namespace ProyectoDB
{
    public partial class ConsultaOrdenFrm : Form
    {

        private int noOrden, idCliente, noFactura;
        public void setOrdenCliente( int noOrden, int idCliente, int noFactura)
        {
            this.noOrden = noOrden;
            this.noFactura = noFactura;
            this.idCliente = idCliente;
        }

        public ConsultaOrdenFrm()
        {
            InitializeComponent();
        }

        private void EncabezadoFacturaBindingSource_PositionChanged(object sender, EventArgs e)
        {
            DataRowView drvFactura = (DataRowView)EncabezadoFacturaBindingSource.Current;
            this.detalleFacturaTableAdapter.FillByFactura(this.facturasDataSet.DetalleFactura, Convert.ToInt32(drvFactura["noFactura"]));
        }

        private void ConsultaOrdenFrm_Load(object sender, EventArgs e)
        {
            this.ordenTableAdapter.FillByOrden(this.ordenDataSet.Orden, noOrden);
            this.clienteTableAdapter1.FillByCliente(this.facturasDataSet.Cliente, idCliente);
            this.clienteVirtualTableAdapter.FillByID(this.clientesDataSet.ClienteVirtual, idCliente);
            this.facturaTableAdapter.FillByNoFactura(this.facturasDataSet.Factura, noFactura);
            this.productoTableAdapter.Fill(this.productosDataSet.Producto);
            DataRowView drvFactura = (DataRowView)EncabezadoFacturaBindingSource.Current;
            this.detalleFacturaTableAdapter.FillByFactura(this.facturasDataSet.DetalleFactura, Convert.ToInt32(drvFactura["noFactura"]));

        }
    }
}
