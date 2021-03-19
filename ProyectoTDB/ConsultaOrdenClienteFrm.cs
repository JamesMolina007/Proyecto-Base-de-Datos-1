using System;
using System.Windows.Forms;

namespace ProyectoDB
{
    public partial class ConsultaOrdenClienteFrm : Form
    {

        private int idCliente;
        public void setIdCliente( int idCliente)
        {
            this.idCliente = idCliente;
        }

        public ConsultaOrdenClienteFrm()
        {
            InitializeComponent();
        }

        private void ConsultaOrdenClienteFrm_Load(object sender, EventArgs e)
        {
            this.ordenTableAdapter.FillByCliente(this.ordenDataSet.Orden,idCliente);
        }
    }
}
