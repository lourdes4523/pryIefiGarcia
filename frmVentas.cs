using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryIefiGarcia
{
    public partial class frmVentas : Form
    {
        List<Venta> listaVentas = new List<Venta>();
        public frmVentas()
        {
            InitializeComponent();
            txtProducto.Focus();
        }

        private void cmdCargar_Click(object sender, EventArgs e)
        {
            if (txtProducto.Text != "")
            {
                if (int.Parse(txtCantidad.Text) > 0)
                {
                    Venta nuevaVenta = new Venta();
                    nuevaVenta.ID = (listaVentas.Count + 1);
                    nuevaVenta.FechaVenta = dtpFechaVenta.Value;
                    nuevaVenta.Producto = txtProducto.Text;
                    nuevaVenta.Cantidad = int.Parse(txtCantidad.Text);
                    listaVentas.Add(nuevaVenta);
                    MessageBox.Show("Venta agregada exitosamente.", "Venta agregada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cbVentas.DataSource = null;
                    cbVentas.DataSource = listaVentas;
                    cbVentas.DisplayMember = "Producto";
                    txtProducto.Focus();
                }
                else
                {
                    MessageBox.Show("No se pudo cargar la venta, indique una cantidad valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No se pudo cargar la venta, indique un Producto valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmdFiltrar_Click(object sender, EventArgs e)
        {
            if (optCantidad.Checked) filtrarCantidad();
            else filtrarProducto();
        }
        private void filtrarCantidad()
        {
            List<Venta> filtro = new List<Venta>();
            for (int i = 0; i < listaVentas.Count; i++)
            {
                if (listaVentas[i].Cantidad > int.Parse(txtBusqueda.Text)) filtro.Add(listaVentas[i]);
            }
            cbVentas.DataSource = filtro;
            cbVentas.DisplayMember = "Producto";
        }

        private void filtrarProducto()
        {
            List<Venta> filtro = new List<Venta>();
            for (int i = 0; i < listaVentas.Count; i++)
            {
                if (listaVentas[i].Producto == txtBusqueda.Text) filtro.Add(listaVentas[i]);
            }
            cbVentas.DataSource = filtro;
            cbVentas.DisplayMember = "Producto";
        }

        private void cbVentas_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvVentas.Items.Clear();
            Venta seleccion = (Venta)cbVentas.SelectedItem;
            if (seleccion != null)
            {
                ListViewItem item = new ListViewItem(seleccion.ID.ToString());
                item.SubItems.Add(seleccion.Producto); item.SubItems.Add(seleccion.FechaVenta.ToString()); item.SubItems.Add(seleccion.Cantidad.ToString());
                lvVentas.Items.Add(item);
            }
        }

        private void cmdListado_Click(object sender, EventArgs e)
        {
            
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void frmVentas_Load(object sender, EventArgs e)
        {

        }
    }
}
