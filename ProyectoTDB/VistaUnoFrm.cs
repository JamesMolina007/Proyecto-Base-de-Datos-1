using System;
using System.Windows.Forms;

namespace ProyectoDB
{
    public partial class VistaUnoFrm : Form
    {
        public VistaUnoFrm()
        {
            InitializeComponent();
        }

        private void VistaUnoFrm_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'vistasDataSet.OrdenDestruida' Puede moverla o quitarla según sea necesario.
            this.ordenDestruidaTableAdapter.Fill(this.vistasDataSet.OrdenDestruida);

        }
    }
}
