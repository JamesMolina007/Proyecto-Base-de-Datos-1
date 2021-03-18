﻿using System;
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
            // TODO: esta línea de código carga datos en la tabla 'carritoClienteDataSet.Producto' Puede moverla o quitarla según sea necesario.
            this.productoTableAdapter.Fill(this.carritoClienteDataSet.Producto);
            this.carritoTableAdapter.FillByCliente(this.carritoClienteDataSet.Carrito,id_Cliente);
            ne_Cantidad.Value = 1;
            

        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            this.Validate();
            DataRowView drv = (DataRowView)ProductosBindingSource.Current;
            DataRowView drvC = (DataRowView)CarritoBindingSource.AddNew();
            drvC.Row["cantidadProductoCarrito"] = ne_Cantidad.Value;
            drvC.Row["idProducto"] = Convert.ToInt32(drv.Row["idProducto"]);
            drvC.Row["idCliente"] = id_Cliente;
            CarritoBindingSource.EndEdit();
            carritoTableAdapter.Update(this.carritoClienteDataSet.Carrito);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            CarritoBindingSource.EndEdit();
            carritoTableAdapter.Update(this.carritoClienteDataSet.Carrito);
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
            ClienteProcesaOrdenFrm clienteprocesaorden = new ClienteProcesaOrdenFrm();
            clienteprocesaorden.Show();
            clienteprocesaorden.setId_Cliente(id_Cliente);
        }
    }
}