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

        private int idCliente;
        public void setIdCliente(int idCliente)
        {
            this.idCliente = idCliente;
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
            lbl_Fecha.Text = DateTime.Now.ToShortDateString();
            lbl_Usuario.Text = tipoUsuario; 
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
            }
            else if(tipoUsuario.Equals("ClienteV"))
            {
                opcionesClienteToolStripMenuItem.Visible = true;
                lbl_Usuario.Text = "Cliente Virtual";
            }
            else if (tipoUsuario.Equals("Cliente"))
            {
                opcionesClienteToolStripMenuItem.Visible = true;
                opcionesClienteToolStripMenuItem.Enabled = false;
            }
            else
            {
                //opcionesClienteToolStripMenuItem.Visible = true;
                inventarioToolStripMenuItem.Visible = true;
                clientesToolStripMenuItem.Visible = true;
                pedidosToolStripMenuItem.Visible = true;
                inventarioToolStripMenuItem.Visible = true;
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

        private void miCarritoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            CarritoClienteFrm carritocliente = new CarritoClienteFrm();
            carritocliente.setId_Cliente(idCliente);
            carritocliente.Show();
        }

        private void empresasDeEnvíoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmpresaDeEnvioFrm empresadeenvio = new EmpresaDeEnvioFrm();
            empresadeenvio.Show();
        }

        private void frecuentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientesFrecuentesFrm clientesfrecuentes = new ClientesFrecuentesFrm();
            clientesfrecuentes.Show();
        }

        private void tiendaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ClienteTiendaFrm clientetienda = new ClienteTiendaFrm();
            clientetienda.Show();
        }

        private void virtualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClienteVirtualFrm clientevirtual = new ClienteVirtualFrm();
            clientevirtual.Show();
        }

        private void pocoFrecuenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientePocoFrecuenteFrm clientepocofrecuente = new ClientePocoFrecuenteFrm();
            clientepocofrecuente.Show();
        }

        private void almacenToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            AlmacenFrm almacen = new AlmacenFrm();
            almacen.Show();
        }

        private void porLlamadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CarritoFrm carrito = new CarritoFrm();
            carrito.Show();
        }

        private void pedidosRealizadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcesoOrdenFrm ordenenviada = new ProcesoOrdenFrm();
            ordenenviada.Show();
        }

        private void ordenesProcesadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaOrdenClienteFrm consultaordencliente = new ConsultaOrdenClienteFrm();
            consultaordencliente.setIdCliente(idCliente);
            consultaordencliente.Show();
        }

        private void facturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaFacturaClienteFrm consultafactura = new ConsultaFacturaClienteFrm();
            consultafactura.setIdCliente(idCliente);
            consultafactura.Show();
        }

        private void ordenesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrdenesFrm ordenes = new OrdenesFrm();
            ordenes.Show();
        }

        private void facturasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FacturasFrm facturas = new FacturasFrm();
            facturas.Show();
        }

        private void consulta2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VistaDosFrm consultados = new VistaDosFrm();
            consultados.Show();
        }

        private void consulta4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VistaCuatroFrm consultacuatro = new VistaCuatroFrm();
            consultacuatro.Show();
        }

        private void consulta6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VistaSeisFrm vistaseis = new VistaSeisFrm();
            vistaseis.Show();
        }

        private void consulta3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VistaTresFrm vistatres = new VistaTresFrm();
            vistatres.Show();
        }

        private void consulta5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VistaCincoFrm vistacinco = new VistaCincoFrm();
            vistacinco.Show();
        }

        private void bitacoraToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BitacoraFrm bitacora = new BitacoraFrm();
            bitacora.Show();
        }
    }
}
