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
    public partial class VistaSeisFrm : Form
    {
        public VistaSeisFrm()
        {
            InitializeComponent();
        }

        private void VistaSeisFrm_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'vistasDataSet.FacturaClienteUltimoMes' Puede moverla o quitarla según sea necesario.
            this.facturaClienteUltimoMesTableAdapter.Fill(this.vistasDataSet.FacturaClienteUltimoMes);

        }
    }
}
