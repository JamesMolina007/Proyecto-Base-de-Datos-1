using System;
using System.Data;
using System.Windows.Forms;

namespace ProyectoDB{
    public partial class Login : Form{
        public Login(){
            InitializeComponent();

        }

        private void Login_Load(object sender, EventArgs e){
            // TODO: esta línea de código carga datos en la tabla 'usuarioDataSet.Usuarios' Puede moverla o quitarla según sea necesario.
            this.usuariosTableAdapter.Fill(this.usuarioDataSet.Usuarios);
        }

        private void btn_cancelar_Click(object sender, EventArgs e){
            Close();
        }

        private void btn_aceptar_Click(object sender, EventArgs e){
            PrincipalBindingSource.Filter = "nombreUsuario = '" + tb_nombreUsuario.Text + "' and " + " Contrasena = '" + tb_Contraseña.Text + "'";
            DataRowView dr = (DataRowView)PrincipalBindingSource.Current;
            if ( dr != null){
                tb_Contraseña.Text = "";
                tb_nombreUsuario.Text = "";
                Principal principal = new Principal();
                principal.setTipoUsuario(dr["tipoUsuario"].ToString());
                principal.setLogin(this);
                principal.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Usuario y/o Contraseña Incorrecta");
            }
        }

        
    }
}