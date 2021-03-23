using System;
using System.Data;
using System.Windows.Forms;

namespace ProyectoDB{
    public partial class Login : Form{
        public Login(){
            InitializeComponent();

        }

        private void Login_Load(object sender, EventArgs e){
            // TODO: esta línea de código carga datos en la tabla 'clientesDataSet.ClienteFrecuente' Puede moverla o quitarla según sea necesario.
            this.clienteFrecuenteTableAdapter.Fill(this.clientesDataSet.ClienteFrecuente);
            // TODO: esta línea de código carga datos en la tabla 'clientesDataSet.ClienteVirtual' Puede moverla o quitarla según sea necesario.
            this.clienteVirtualTableAdapter.Fill(this.clientesDataSet.ClienteVirtual);
            // TODO: esta línea de código carga datos en la tabla 'usuarioDataSet.Usuarios' Puede moverla o quitarla según sea necesario.
            this.usuariosTableAdapter.Fill(this.usuarioDataSet.Usuarios);
        }

        private void btn_cancelar_Click(object sender, EventArgs e){
            Close();
        }

        private void btn_aceptar_Click(object sender, EventArgs e){
            try
            {
                PrincipalBindingSource.Filter = "nombreUsuario = '" + tb_nombreUsuario.Text + "' and " + " Contrasena = '" + tb_Contraseña.Text + "'";
                DataRowView dr = (DataRowView)PrincipalBindingSource.Current;
                if (dr != null)
                {
                    tb_Contraseña.Text = "";
                    tb_nombreUsuario.Text = "";
                    Principal principal = new Principal();
                    principal.setTipoUsuario(dr["tipoUsuario"].ToString());
                    principal.setNombre(dr["Nombre"].ToString());
                    principal.setLogin(this);
                    principal.Show();
                }
                else
                {
                    ClienteBindingSource.Filter = "idCliente = '" + Convert.ToInt32(tb_nombreUsuario.Text) + "' and " + " password = '" + tb_Contraseña.Text + "'";
                    DataRowView drC = (DataRowView)ClienteBindingSource.Current;
                    if (drC != null)
                    {
                        Principal principal = new Principal();
                        principal.setTipoUsuario("ClienteV");
                        principal.setIdCliente(Convert.ToInt32(tb_nombreUsuario.Text));
                        principal.setLogin(this);
                        tb_Contraseña.Text = "";
                        tb_nombreUsuario.Text = "";
                        principal.Show();
                        this.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Usuario y/o Contraseña Incorrecta");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(e.ToString());
            }
        }

        
    }
}