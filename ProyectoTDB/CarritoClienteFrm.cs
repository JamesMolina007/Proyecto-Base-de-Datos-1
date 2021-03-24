using System;
using System.Data;
using System.Windows.Forms;

namespace ProyectoDB
{
    public partial class CarritoClienteFrm : Form
    {

        private int id_Cliente; 
        public void setId_Cliente( int id_Cliente)
        {
            this.id_Cliente = id_Cliente;
        }

        public CarritoClienteFrm()
        {
            InitializeComponent();
        }

        private void CarritoClienteFrm_Load(object sender, EventArgs e)
        {
            this.tiendaTableAdapter.Fill(this.tiendaDataSet.Tienda);
            this.productoTableAdapter.Fill(this.carritoClienteDataSet.Producto);
            this.inventarioTableAdapter.Fill(this.inventarioDataSet.Inventario);
            this.carritoTableAdapter.FillByCliente(this.carritoClienteDataSet.Carrito,id_Cliente);
           // ne_Cantidad.Value = 1;
            

        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            try
            {
                if ( ne_Cantidad.Value > 0)
                {
                    this.Validate();
                    DataRowView drv = (DataRowView)ProductosBindingSource.Current;
                    DataRowView drvC = (DataRowView)CarritoBindingSource.AddNew();
                    DataRowView drvT = (DataRowView)TiendaBindingSource.Current;
                    drvC.Row["cantidadProductoCarrito"] = ne_Cantidad.Value;
                    drvC.Row["idProducto"] = Convert.ToInt32(drv.Row["idProducto"]);
                    drvC.Row["idCliente"] = id_Cliente;
                    drvC.Row["Tienda"] = Convert.ToInt32(drvT["codigoTienda"]);
                    CarritoBindingSource.EndEdit();
                    carritoTableAdapter.Update(this.carritoClienteDataSet.Carrito);
                }

            }catch(Exception ex)
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            //CarritoBindingSource.EndEdit();
            //carritoTableAdapter.Update(this.carritoClienteDataSet.Carrito);
            this.productoTableAdapter.Fill(this.carritoClienteDataSet.Producto);
            this.carritoTableAdapter.FillByCliente(this.carritoClienteDataSet.Carrito, id_Cliente);
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("¿Está Seguro que quiere eliminar este registro?", "Eliminar", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    CarritoBindingSource.RemoveCurrent();
                    this.CarritoBindingSource.EndEdit();
                    carritoTableAdapter.Update(this.carritoClienteDataSet.Carrito);
                }

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }

        private void btn_Comprar_Click(object sender, EventArgs e)
        {
            double subTotal = 0.00, isv = 0.00, total = 0.00;
            for (int i = 0; i < dataGridView1.RowCount; i++){
                string idProducto = dataGridView1.Rows[i].Cells[0].Value.ToString();
                ProductosBindingSource.Filter = string.Format("convert(idProducto, 'System.String') = '{0}' ", idProducto);

                DataRowView drvProducto = (DataRowView)ProductosBindingSource.Current;
                subTotal += Convert.ToInt32(drvProducto.Row["Precio"]) * Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value);
            }
            isv = subTotal * 0.15;
            total = isv + subTotal;
            tb_ISV.Text = isv.ToString();
            tb_subTotal.Text = subTotal.ToString();
            textBox3.Text = total.ToString();
            ClienteProcesaOrdenFrm clienteprocesaorden = new ClienteProcesaOrdenFrm();
            clienteprocesaorden.setTotal(total);
            clienteprocesaorden.setIsv(isv);
            clienteprocesaorden.setCarrito(dataGridView1);
            ProductosBindingSource.RemoveFilter();
            clienteprocesaorden.setId_Cliente(id_Cliente);
            clienteprocesaorden.Show();
           
            //this.Close();
        }

        private void ProductosBindingSource_PositionChanged(object sender, EventArgs e)
        {
            //if(tb_Cantidad.Text.Length > 1)
            //    ne_Cantidad.Maximum = Convert.ToInt32(tb_Cantidad.Text);
        }

        private void InventarioBindingSource_PositionChanged(object sender, EventArgs e)
        {
            try
            {
                DataRowView drvI = (DataRowView)InventarioBindingSource.Current;
                ProductosBindingSource.Filter = string.Format("convert(idProducto, 'System.String') Like '{0}' ", drvI["idProducto"]);
                ne_Cantidad.Maximum = Convert.ToInt32(drvI["Cantidad"]);
            }catch(Exception ex)
            {

            }
        }


        private void TiendaBindingSource_PositionChanged(object sender, EventArgs e)
        {
            DataRowView drvTienda = (DataRowView)TiendaBindingSource.Current;
            this.InventarioBindingSource.Filter = string.Format("convert(codigoTienda, 'System.String') = '{0}' ", drvTienda["codigoTienda"]);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_CambiarTienda_Click(object sender, EventArgs e)
        {
            if( comboBox1.SelectedItem.ToString() != null)
            {
                MessageBox.Show("hola cabezas de huevo");
            }
        }
    }
}
