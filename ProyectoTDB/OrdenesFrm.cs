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
    public partial class OrdenesFrm : Form
    {
        public OrdenesFrm()
        {
            InitializeComponent();
        }

        private void OrdenClienteFrm_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'clientesDataSet.ClientePocoFrecuente' Puede moverla o quitarla según sea necesario.
            this.clientePocoFrecuenteTableAdapter.Fill(this.clientesDataSet.ClientePocoFrecuente);
            // TODO: esta línea de código carga datos en la tabla 'empresasDeEnvioDataSet.EmpresaDeEnvio' Puede moverla o quitarla según sea necesario.
            this.empresaDeEnvioTableAdapter.Fill(this.empresasDeEnvioDataSet.EmpresaDeEnvio);
            // TODO: esta línea de código carga datos en la tabla 'ordenDataSet.Orden' Puede moverla o quitarla según sea necesario.
            this.ordenTableAdapter.Fill(this.ordenDataSet.Orden);

        }
    }
}
