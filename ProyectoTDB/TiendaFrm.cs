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
    public partial class TiendaFrm : Form
    {
        public TiendaFrm()
        {
            InitializeComponent();
        }

        private void TiendaFrm_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tiendaDataSet.Tienda' Puede moverla o quitarla según sea necesario.
            this.tiendaTableAdapter.Fill(this.tiendaDataSet.Tienda);
            PrincipalBindingSource.AddNew();
        }

        private void tb_Buscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (tb_Buscar.Text.Length > 0)
            {
                PrincipalBindingSource.Filter = "Ubicacion LIKE '*" + tb_Buscar.Text + "*'";
            }
            else
            {
                PrincipalBindingSource.RemoveFilter();
            }
        }

        private void dataGridView1_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                PrincipalBindingSource.EndEdit();
                tiendaTableAdapter.Update(this.tiendaDataSet);
            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.ToString());
            }
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("¿Está Seguro que quiere eliminar este registro?", "Eliminar", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    PrincipalBindingSource.RemoveCurrent();
                    this.PrincipalBindingSource.EndEdit();
                    this.tiendaTableAdapter.Update(this.tiendaDataSet.Tienda);
                    MessageBox.Show("El registro ha sido eliminado");
                    this.tiendaTableAdapter.Fill(this.tiendaDataSet.Tienda);
                }
                else if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("El registro no ha sido eliminado");
                }
            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.ToString());
            }
        }
    }
}
