using System;
using System.Data;
using System.Windows.Forms;

namespace ProyectoDB
{
    public partial class ClienteCompraFrm : Form
    {

        private int IDCliente;
        public void setIdCliente(int IDCliente)
        {
            this.IDCliente = IDCliente;
        }

        public ClienteCompraFrm()
        {
            InitializeComponent();
        }
        //ID CLIENTE, idProducto, idCliente, cantidadProductoCarrito, Tienda
        private void ClienteCompraFrm_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'productosDataSet.Producto' Puede moverla o quitarla según sea necesario.
            this.productoTableAdapter.Fill(this.productosDataSet.Producto);
            // TODO: esta línea de código carga datos en la tabla 'tiendaDataSet.Tienda' Puede moverla o quitarla según sea necesario.
            this.tiendaTableAdapter.Fill(this.tiendaDataSet.Tienda);
            // TODO: esta línea de código carga datos en la tabla 'inventarioDataSet.Inventario' Puede moverla o quitarla según sea necesario.
            this.inventarioTableAdapter.Fill(this.inventarioDataSet.Inventario);
            // TODO: esta línea de código carga datos en la tabla 'facturasDataSet.DetalleFactura' Puede moverla o quitarla según sea necesario.
            this.detalleFacturaTableAdapter.Fill(this.facturasDataSet.DetalleFactura);
            // TODO: esta línea de código carga datos en la tabla 'facturasDataSet.Factura' Puede moverla o quitarla según sea necesario.
            this.facturaTableAdapter.Fill(this.facturasDataSet.Factura);
            // TODO: esta línea de código carga datos en la tabla 'clientesDataSet.Cliente' Puede moverla o quitarla según sea necesario.
            this.clienteTableAdapter.Fill(this.clientesDataSet.Cliente);

        }

        private void TiendaBindingSource_PositionChanged(object sender, EventArgs e)
        {
            DataRowView drvTienda = (DataRowView)TiendaBindingSource.Current;
            this.InventarioBindingSource.Filter = string.Format("convert(codigoTienda, 'System.String') = '{0}' ", drvTienda["codigoTienda"]);
            if( dataGridView2.RowCount > 0)
            {
                DataRowView drvI = (DataRowView)InventarioBindingSource.Current;
                ne_Cantidad.Maximum = Convert.ToInt32(drvI["Cantidad"]);
                ProductoBindingSource.Filter = string.Format("convert(idProducto, 'System.String') Like '{0}' ", drvI["idProducto"]);
            }
        }

        private void InventarioBindingSource_PositionChanged(object sender, EventArgs e)
        {
            try
            {

                DataRowView drvI = (DataRowView)InventarioBindingSource.Current;
                ProductoBindingSource.Filter = string.Format("convert(idProducto, 'System.String') Like '{0}' ", drvI["idProducto"]);

                if (Convert.ToInt32(drvI["Cantidad"]) > 0)
                    ne_Cantidad.Maximum = Convert.ToInt32(drvI["Cantidad"]);
                else
                    ne_Cantidad.Maximum = 1;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ne_Cantidad.Value > 0)
                {
                    this.Validate();
                    DataRowView drC = (DataRowView)ClienteBindingSource.Current;
                    DataRowView drv = (DataRowView)ProductoBindingSource.Current;
                    DataRowView drvT = (DataRowView)TiendaBindingSource.Current;
                    int fila = 0;
                    if (dg_Carro.RowCount < 1)
                    {
                        fila = 0;
                    }
                    else
                    {
                        fila = dg_Carro.RowCount - 1;
                    }
                    dg_Carro.Rows.Insert(fila, Convert.ToInt32(drv.Row["idProducto"]), Convert.ToInt32(drC["idCliente"]), ne_Cantidad.Value, Convert.ToInt32(drvT["codigoTienda"]));
                    
                }

            }
            catch (Exception ex)
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_Comprar_Click(object sender, EventArgs e)
        {
            DataRowView drC = (DataRowView)ClienteBindingSource.Current;
            PedidoLlamadaFrm pedido = new PedidoLlamadaFrm();
            pedido.idCliente = Convert.ToInt32(drC["idCliente"]);
            pedido.carro = dg_Carro;
            pedido.tienda = Convert.ToInt32(comboBox1.SelectedValue);
            pedido.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dg_Carro.Rows.RemoveAt(dg_Carro.CurrentRow.Index);
        }
    }
}
