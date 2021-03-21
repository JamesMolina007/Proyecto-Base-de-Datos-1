using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoDB
{
    public partial class VistaCincoFrm : Form
    {
        public VistaCincoFrm()
        {
            InitializeComponent();
        }

        private void VistaCincoFrm_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'vistasDataSet.AgotadoTGU' Puede moverla o quitarla según sea necesario.
            this.agotadoTGUTableAdapter.Fill(this.vistasDataSet.AgotadoTGU);

        }
    }
}
