using System;
using System.Data;
using System.Windows.Forms;

namespace ProyectoDB
{
    public partial class BitacoraFrm : Form
    {
        public BitacoraFrm()
        {
            InitializeComponent();
        }

        private void BitacoraFrm_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bitacoraDataSet.Bitacora' Puede moverla o quitarla según sea necesario.
            this.bitacoraTableAdapter.Fill(this.bitacoraDataSet.Bitacora);

        }

        private void btn_Filtrar_Click(object sender, EventArgs e)
        {
            PrincipalBindingSource.RemoveFilter();
            DataRowView drv = (DataRowView)PrincipalBindingSource.Current;
            //try
            //{
                if( cb_Tabla.SelectedIndex >= 0 && tb_Accion.SelectedIndex >= 0 )
                {
                    if (cb_Tabla.SelectedItem.ToString().Equals("TODAS"))
                    {
                        if (tb_Accion.SelectedItem.ToString().Equals("TODAS"))
                        {
                            PrincipalBindingSource.RemoveFilter();
                        }
                        else
                        {
                            PrincipalBindingSource.Filter = "Consulta like '*" + tb_Accion.SelectedItem.ToString() + "*'";
                        }
                    }
                    else
                    {
                    if (tb_Accion.SelectedItem.ToString().Equals("TODAS"))
                    {
                        PrincipalBindingSource.Filter = "Tabla = '" + cb_Tabla.SelectedItem.ToString() + "'";
                    }
                    else
                    {
                        PrincipalBindingSource.Filter = "Consulta like '*" + tb_Accion.SelectedItem.ToString() + "*' and Tabla = '" + cb_Tabla.SelectedItem.ToString() + "'";
                    }
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese parámetros validos!");
                }
            //}catch(Exception ex)
            //{

            //}
        }
    }
}
