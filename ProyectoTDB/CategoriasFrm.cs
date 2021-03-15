using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace ProyectoDB
{
    public partial class CategoriasFrm : Form
    {
        public CategoriasFrm()
        {
            InitializeComponent();
        }

        private void CategoriasFrm_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'categoriasDataSet.Categoria' Puede moverla o quitarla según sea necesario.
            this.categoriaTableAdapter.Fill(this.categoriasDataSet.Categoria);
            PrincipalBindingSource.AddNew();
            
        }

        private void tb_BuscarCategoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (tb_BuscarCategoria.Text.Length > 0)
            {
                PrincipalBindingSource.Filter = "nombreCategoria LIKE '*" + tb_BuscarCategoria.Text + "*'";
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
                categoriaTableAdapter.Update(this.categoriasDataSet);
            }catch( Exception ex)
            {
               // MessageBox.Show(ex.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("¿Está Seguro que quiere eliminar este registro?", "Eliminar", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    PrincipalBindingSource.RemoveCurrent();
                    this.PrincipalBindingSource.EndEdit();
                    this.categoriaTableAdapter.Update(this.categoriasDataSet.Categoria);
                    MessageBox.Show("El registro ha sido eliminado");
                    this.categoriaTableAdapter.Fill(this.categoriasDataSet.Categoria);
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
