using System;
using System.Windows.Forms;

namespace ProyectoDB
{
    
    public partial class Principal : Form
    {
        private Login pantallaLogin;
        public void setLogin(Login pantallaLogin)
        {
            this.pantallaLogin = pantallaLogin;
        }

        private String tipoUsuario;
        public void setTipoUsuario(String tipoUsuario)
        {
            this.tipoUsuario = tipoUsuario;
        }

        public Principal()
        {
            InitializeComponent();
        }

        private void configuraciónDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsuariosFrm usuarios = new UsuariosFrm();
            usuarios.Show();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            if ( tipoUsuario.Equals("Servicio al Cliente"))
            {
                inventarioToolStripMenuItem.Visible = true;
            }else if( tipoUsuario.Equals("Personal de Centro de Llamadas"))
            {
                clientesToolStripMenuItem.Visible = true;
                pedidosToolStripMenuItem.Visible = true;
            }else if( tipoUsuario.Equals("Empleado de Almacen"))
            {
                inventarioToolStripMenuItem.Visible = true;
                enviosToolStripMenuItem.Visible = true;
            }
            else
            {
                inventarioToolStripMenuItem.Visible = true;
                clientesToolStripMenuItem.Visible = true;
                pedidosToolStripMenuItem.Visible = true;
                inventarioToolStripMenuItem.Visible = true;
                enviosToolStripMenuItem.Visible = true;
                reportesToolStripMenuItem.Visible = true;
                tiendaToolStripMenuItem.Visible = true;
                usuariosToolStripMenuItem.Visible = true;
            }
        }

        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pantallaLogin.Visible = true;
            this.Dispose();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategoriasFrm categorias = new CategoriasFrm();
            categorias.Show();
        }

        private void almacenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AlmacenFrm almacen = new AlmacenFrm();
            almacen.Show();
        }

        private void configuraciónDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientesFrm clientes = new ClientesFrm();
            clientes.Show();
        }

        private void almacenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductoFrm productosFrm = new ProductoFrm();
            productosFrm.Show();
        }

        private void configuraciónDeTiendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TiendaFrm tienda = new TiendaFrm();
            tienda.Show();
        }

        private void contratosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ContratosFrm contratos = new ContratosFrm();
            contratos.Show();
        }

        private void carritoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CarritoFrm carrito = new CarritoFrm();
            carrito.Show();
        }
    }
}
