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
    public partial class FacturasFrm : Form
    {
        public FacturasFrm()
        {
            InitializeComponent();
        }

        private void FacturasFrm_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'facturasDataSet.Factura' Puede moverla o quitarla según sea necesario.
            this.facturaTableAdapter.Fill(this.facturasDataSet.Factura);
            // TODO: esta línea de código carga datos en la tabla 'facturasDataSet.DetalleFactura' Puede moverla o quitarla según sea necesario.
            this.detalleFacturaTableAdapter.Fill(this.facturasDataSet.DetalleFactura);

        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {

        }
    }
}
