using System;
using System.Windows.Forms;

namespace ProyectoDB
{
    public partial class ClienteContratoFrm : Form
    {
        private String nombre;
        public void setNombre( String nombre)
        {
            this.nombre = nombre;
        } 
        public ClienteContratoFrm()
        {
            InitializeComponent();
        }

        private void ClienteContratoFrm_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'contratoDataSet.Contrato' Puede moverla o quitarla según sea necesario.
            this.contratoTableAdapter.FillByNombre(this.contratoDataSet.Contrato, nombre);

        }
    }
}
