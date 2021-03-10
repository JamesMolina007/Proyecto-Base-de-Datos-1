using System;
using System.Windows.Forms;

namespace ProyectoDB{
    public partial class Login : Form{
        public Login(){
            InitializeComponent();

        }

        private void Login_Load(object sender, EventArgs e){
            this.usuariosTableAdapter.Fill(this.loginDataSet.Usuarios);
        }

        private void btn_cancelar_Click(object sender, EventArgs e){
            Close();
        }

        private void btn_aceptar_Click(object sender, EventArgs e){
            if ( tb_nombreUsuario.Text.Equals( "admin") & tb_Contraseña.Text.Equals("erp94128") )
            {
                Principal principal = new Principal();
                principal.Show();
                this.Dispose();
            }
        }

    }
}