using System;
using System.Windows.Forms;

namespace ProyectoDB
{
    public partial class InventarioFrm : Form
    {
        public InventarioFrm()
        {
            InitializeComponent();
        }
        private String tipoUsuario = "";
        public void setTipoUsuario(String tipoUsuario)
        {
            this.tipoUsuario = tipoUsuario;
        }

        private void InventarioFrm_Load(object sender, EventArgs e)
        {
            this.tiendaTableAdapter.Fill(this.tiendaDataSet.Tienda);
            this.almacenTableAdapter.Fill(this.almacenDataSet.Almacen);
            this.productoTableAdapter.Fill(this.productosDataSet.Producto);
            if (tipoUsuario.Equals("Servicio al Cliente"))
            {
                btn_Eliminar.Visible = false;
                btn_Guardar.Visible = false;
                btn_Nuevo.Visible = false;
                groupBox1.Enabled = false;
            }
            recargar();

        }

        private void recargar()
        {
            this.inventarioTableAdapter.Fill(this.inventarioDataSet.Inventario);
        }

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            InventarioBindingSource.AddNew();
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                InventarioBindingSource.EndEdit();
                inventarioTableAdapter.Update(this.inventarioDataSet.Inventario);
                MessageBox.Show("Guardado Correctamente!");
                recargar();
            }catch(Exception ex)
            {
                MessageBox.Show("Error al querer guardar!");
            }
        }

        private void btn_Recargar_Click(object sender, EventArgs e)
        {
            recargar();
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("¿Está Seguro que quiere eliminar este registro?", "Eliminar", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    InventarioBindingSource.RemoveCurrent();
                    this.InventarioBindingSource.EndEdit();
                    this.inventarioTableAdapter.Update(this.inventarioDataSet.Inventario);
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
    }
}
