using System;
using System.Data;
using System.Windows.Forms;

namespace ProyectoDB
{
    public partial class ProductoFrm : Form
    {
        public ProductoFrm()
        {
            InitializeComponent();
        }

        private void ProductoFrm_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'productosDataSet.Categoria' Puede moverla o quitarla según sea necesario.
            this.categoriaTableAdapter.Fill(this.productosDataSet.Categoria);
            recargar();
        }

       

        private void recargar()
        {
            // TODO: esta línea de código carga datos en la tabla 'productosDataSet.Producto' Puede moverla o quitarla según sea necesario.
            this.productoTableAdapter.Fill(this.productosDataSet.Producto);
            PrincipalBindingSource.RemoveFilter();
            tb_Buscar.Text = "";
            deshabilitar();
        }

        private void deshabilitar()
        {
            btn_nuevo.Enabled = true;
            btn_eliminar.Enabled = false;
            btn_guardar.Enabled = false;
            groupBox1.Enabled = false;
        }
        private void habilitar()
        {
            btn_guardar.Enabled = true;
            groupBox1.Enabled = true;
            btn_eliminar.Enabled = false;
            btn_nuevo.Enabled = false;
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            PrincipalBindingSource.AddNew();
            habilitar();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.PrincipalBindingSource.EndEdit();
                this.productoTableAdapter.Update(this.productosDataSet.Producto);
                MessageBox.Show("Guardado Correctamente");
                recargar();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }

        private void btn_Recargar_Click(object sender, EventArgs e)
        {
            recargar();
        }

        private void tb_Buscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (tb_Buscar.Text.Length > 0)
            {
                PrincipalBindingSource.Filter = "nombreProducto LIKE '*" + tb_Buscar.Text + "*'";
            }
            else
            {
                PrincipalBindingSource.RemoveFilter();
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("¿Está Seguro que quiere eliminar este registro?", "Eliminar", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    PrincipalBindingSource.RemoveCurrent();
                    this.PrincipalBindingSource.EndEdit();
                    this.productoTableAdapter.Update(this.productosDataSet.Producto);
                    MessageBox.Show("El registro ha sido eliminado");
                    recargar();
                }
                else if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("El registro no ha sido eliminado");
                }

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }

        private void PrincipalBindingSource_PositionChanged(object sender, EventArgs e)
        {
            DataRowView drvProducto = (DataRowView)PrincipalBindingSource.Current;
            if (drvProducto != null)
            {
                tb_Descripcion.Text = drvProducto.Row["Descripcion"].ToString();
                tb_Fabricante.Text = drvProducto.Row["fabricante"].ToString();
                tb_Nombre.Text = drvProducto.Row["nombreProducto"].ToString();
                tb_Modelo.Text = drvProducto.Row["Modelo"].ToString();
                tb_Precio.Text = drvProducto.Row["Precio"].ToString();
                tb_tipo.Text = drvProducto.Row["tipoProducto"].ToString();
                habilitar();
                btn_nuevo.Enabled = false;
                btn_guardar.Enabled = true;
                btn_eliminar.Enabled = true;
                drvProducto = null;
            }
        }
    }
}
