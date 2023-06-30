using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryIefiGarcia
{
    public partial class frmProductos : Form
    {
        List<Producto> listaProductos = new List<Producto>();
        public frmProductos()
        {
            InitializeComponent();
            txtNombre.Focus();
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {

        }

        private void cmdCargar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "")
            {
                if (dtpFechaRegistro.Value < DateTime.Today)
                {
                    MessageBox.Show("No se pudo cargar el producto, indique una fecha valida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Producto nuevoProducto = new Producto();
                    nuevoProducto.ID = (listaProductos.Count + 1);
                    nuevoProducto.Nombre = txtNombre.Text;
                    nuevoProducto.FechaRegistro = dtpFechaRegistro.Value;
                    listaProductos.Add(nuevoProducto);
                    MessageBox.Show(nuevoProducto.Nombre + " agregado exitosamente.", "Producto agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cbProductos.DataSource = null;
                    cbProductos.DataSource = listaProductos;
                    cbProductos.DisplayMember = "Nombre";
                    txtNombre.Focus();
                }
            }
            else
            {
                MessageBox.Show("No se pudo cargar el producto, indique un nombre valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvProductos.Items.Clear();
            Producto seleccion = (Producto)cbProductos.SelectedItem;
            if (seleccion != null)
            {
                ListViewItem item = new ListViewItem(seleccion.ID.ToString());
                item.SubItems.Add(seleccion.Nombre); item.SubItems.Add(seleccion.FechaRegistro.ToString());
                lvProductos.Items.Add(item);
            }
        
        }
        private void cmdListado_Click(object sender, EventArgs e)
        {
            
        }

        private void gbConsulta_Enter(object sender, EventArgs e)
        {

        }
    }
}
