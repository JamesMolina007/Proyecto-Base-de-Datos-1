using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace ProyectoDB
{
    public partial class SQLFrm : Form
    {
        public SQLFrm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand Query = new MySqlCommand();
                MySqlDataReader consultar;
                MySqlConnection Conexion = new MySqlConnection();
                Conexion.ConnectionString = "server=proyecto.ctsyzs4hbov3.us-east-1.rds.amazonaws.com;user id=admin;password=erp94128;database=ventas;port=3306;pooling=false";
                Conexion.Open();
                Query.CommandText = tb_SQL.Text;
                Query.Connection = Conexion;
                consultar = Query.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(consultar);
                dbGrid_sql.DataSource = dt;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
