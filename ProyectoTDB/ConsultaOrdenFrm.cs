using System;
using System.Data;
using System.Windows.Forms;

namespace ProyectoDB
{
    public partial class ConsultaOrdenFrm : Form
    {

        private int noOrden, idCliente;
        public void setOrdenCliente( int noOrden, int idCliente)
        {
            this.noOrden = noOrden;
            this.idCliente = idCliente;
        }

        public ConsultaOrdenFrm()
        {
            InitializeComponent();
        }

        private void ConsultaOrdenFrm_Load(object sender, EventArgs e)
        {
            this.ordenTableAdapter.FillByOrden(this.ordenDataSet.Orden, noOrden);
            this.clienteTableAdapter1.FillByCliente(this.facturasDataSet.Cliente, idCliente);
            this.clienteVirtualTableAdapter.FillByID(this.clientesDataSet.ClienteVirtual, idCliente);
            this.facturaTableAdapter.FillByFactura(this.facturasDataSet.Factura, idCliente);
            this.productoTableAdapter.Fill(this.productosDataSet.Producto);
            DataRowView drvFactura = (DataRowView)EncabezadoFacturaBindingSource.Current;
            this.detalleFacturaTableAdapter.FillByFactura(this.facturasDataSet.DetalleFactura, Convert.ToInt32(drvFactura["noFactura"]));

        }
    }
}
