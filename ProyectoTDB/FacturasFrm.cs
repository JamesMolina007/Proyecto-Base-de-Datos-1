using System;
using System.Data;
using System.Windows.Forms;

namespace ProyectoDB
{
    public partial class FacturasFrm : Form
    {
        public FacturasFrm()
        {
            InitializeComponent();
        }

        private void FacturasFrm_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'productosDataSet.Producto' Puede moverla o quitarla según sea necesario.
            this.productoTableAdapter.Fill(this.productosDataSet.Producto);
            this.tiendaTableAdapter.Fill(this.tiendaDataSet.Tienda);
            this.clienteVirtualTableAdapter.Fill(this.clientesDataSet.ClienteVirtual);
            recargar();
        }

        private void recargar()
        {
            this.facturaTableAdapter.Fill(this.facturasDataSet.Factura);
        }

        private void btn_Recargar_Click(object sender, EventArgs e)
        {
            recargar();
        }

        private void EncabezadoFacturaBindingSource_PositionChanged(object sender, EventArgs e)
        {
            try
            {
                DataRowView drvFactura = (DataRowView)EncabezadoFacturaBindingSource.Current;
                detalleFacturaTableAdapter.FillByFactura(this.facturasDataSet.DetalleFactura, Convert.ToInt32(drvFactura["noFactura"]));
            }
            catch (Exception ex)
            {

            }
         }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("¿Está Seguro que quiere eliminar este registro?", "Eliminar", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    DataRowView drvEncabezado = (DataRowView)EncabezadoFacturaBindingSource.Current;
                    detalleFacturaTableAdapter.FillByDeleteFactura(this.facturasDataSet.DetalleFactura, Convert.ToInt32(drvEncabezado["noFactura"]));
                    EncabezadoFacturaBindingSource.RemoveCurrent();
                    this.EncabezadoFacturaBindingSource.EndEdit();
                    this.facturaTableAdapter.Update(this.facturasDataSet.Factura);
                    MessageBox.Show("El registro ha sido eliminado");
                    recargar();
                }
                else if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("El registro no ha sido eliminado");
                }

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }
    }
}
