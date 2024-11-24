using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_Equipo
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            //YO
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void contenidoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void contenidoToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void clientesToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Clientes clientes = new Clientes();
            clientes.Show();
        }

        private void categoriasToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmCategorias categorias = new frmCategorias();
            categorias.Show();
        }

        private void detallesDelPedidoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmDetallesPedido detallesPedido = new frmDetallesPedido();
            detallesPedido.Show();
        }

        private void demografiaDelClienteToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmDemografiaCliente demografiaCliente = new frmDemografiaCliente();
            demografiaCliente.Show();

        }

        private void empleadoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmEmpleados empleados = new frmEmpleados();
            empleados.Show();

        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
