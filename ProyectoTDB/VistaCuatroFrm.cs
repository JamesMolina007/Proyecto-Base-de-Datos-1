using System;
using System.Windows.Forms;

namespace ProyectoDB
{
    public partial class VistaCuatroFrm : Form
    {
        public VistaCuatroFrm()
        {
            InitializeComponent();
        }

        private void ConsultaCuatroFrm_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'vistasDataSet.Top2Productos' Puede moverla o quitarla según sea necesario.
            this.top2ProductosTableAdapter.Fill(this.vistasDataSet.Top2Productos);

        }
    }
}
