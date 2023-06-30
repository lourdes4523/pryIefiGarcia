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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void cmdProductos_Click(object sender, EventArgs e)
        {
            frmProductos productos = new frmProductos();
            productos.ShowDialog();
        }

        private void cmdVentas_Click(object sender, EventArgs e)
        {
            frmVentas ventas = new frmVentas();
            ventas.ShowDialog();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
