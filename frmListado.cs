using System;
using System.Collections;
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
    public partial class frmListado : Form
    {
        public string Operacion { get; set; }
        List<Producto> listaProductos;
        List<Venta> listaVentas;
        //public frmListado(string operacion, List<Producto> lista)
        //{
        //    InitializeComponent();
        //    this.Operacion = operacion;
        //    this.listaProductos = lista;
        //}
        //public frmListado(string operacion, List<Venta> lista)
        //{
        //    InitializeComponent();
        //    this.Operacion = operacion;
        //    this.listaVentas = lista;
        //}

        private void frmListado_Load(object sender, EventArgs e)
        {
            if (Operacion == "Productos")
            {
                dgvListado.DataSource = listaProductos;
                this.Text = "Listado de Productos";
                lblTituloChico.Text = "Listado de Productos";
                lblInstrucciones.Visible = true;
            }
            else
            {
                dgvListado.DataSource = listaVentas;
                this.Text = "Listado de Ventas";
                lblTituloChico.Text = "Listado de Ventas";
                gbFiltros.Visible = true;
            }
        }

        private void dgvListado_RowHeaderMouseDoubleClickdgvListado_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Seleccion de Productos (Consigna del Formulario listado)
            if (Operacion == "Productos")
            {
                Producto seleccion = (Producto)dgvListado.CurrentRow.DataBoundItem;
                MessageBox.Show("ID: " + seleccion.ID + "\nNombre: " + seleccion.Nombre + "\nFecha de Registro: " + seleccion.FechaRegistro.ToString("dd/MM/yyyy"), "Informacion del Producto", MessageBoxButtons.OK);
            }
        }

        private void filtrarCantidad()
        {
            List<Venta> filtro = new List<Venta>();
            for (int i = 0; i < listaVentas.Count; i++)
            {
                if (listaVentas[i].Cantidad > int.Parse(txtBusqueda.Text)) filtro.Add(listaVentas[i]);
            }
            dgvListado.DataSource = filtro;
        }

        private void filtrarProducto()
        {
            List<Venta> filtro = new List<Venta>();
            for (int i = 0; i < listaVentas.Count; i++)
            {
                if (listaVentas[i].Producto == txtBusqueda.Text) filtro.Add(listaVentas[i]);
            }
            dgvListado.DataSource = filtro;
        }

        private void cmdFiltrar_Click(object sender, EventArgs e)
        {
            if (optCantidad.Checked) filtrarCantidad();
            else filtrarProducto();
        }

        private void cmdVerTodo_Click(object sender, EventArgs e)
        {
            dgvListado.DataSource = listaVentas;
        }
    }     

    

   
}
