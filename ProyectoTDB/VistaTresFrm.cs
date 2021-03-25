using System;
using System.Windows.Forms;

namespace ProyectoDB
{
    public partial class VistaTresFrm : Form
    {
        public VistaTresFrm()
        {
            InitializeComponent();
        }

        private void VistaTresFrm_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'vistasDataSet.Top2Dolares' Puede moverla o quitarla según sea necesario.
            this.top2DolaresTableAdapter.Fill(this.vistasDataSet.Top2Dolares);

        }
    }
}
