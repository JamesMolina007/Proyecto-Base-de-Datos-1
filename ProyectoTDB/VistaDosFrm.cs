using System;
using System.Windows.Forms;

namespace ProyectoDB
{
    public partial class VistaDosFrm : Form
    {
        public VistaDosFrm()
        {
            InitializeComponent();
        }

        private void ConsultaDosFrm_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'vistasDataSet.ClienteMasCompras' Puede moverla o quitarla según sea necesario.
            this.clienteMasComprasTableAdapter.Fill(this.vistasDataSet.ClienteMasCompras);

        }
    }
}
