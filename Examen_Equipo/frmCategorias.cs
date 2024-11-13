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
    public partial class frmCategorias : Form
    {

        bool bandera = false;


        Datos datos = new Datos();
        public frmCategorias()
        {
            InitializeComponent();
        }


        private void ActualizarGrid()
        {
            DataSet ds;
            ds = datos.consulta("Select CategoryID, CategoryName,Description,Picture  From Categories");
            if (ds != null)
            {
                dgvCategories.DataSource = ds.Tables[0];
            }
        }

        private void frmCategorias_Load(object sender, EventArgs e)
        {
            ActualizarGrid();
        }

        private void dgvCategories_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ActualizarGrid();
        }

        private void frmCategorias_Activated(object sender, EventArgs e)
        {

        }
    }
}
