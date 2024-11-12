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
    public partial class Clientes : Form
    {
        bool bandera = false;
        int id;
        Datos datos = new Datos();
        public Clientes()
        {
            InitializeComponent();
        }
       // public Clientes(string id, string companyname, string contactname)

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Los datos son correctos?", "Sistema"
                , MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question) == DialogResult.OK)
            {
              //  if ()
            }
        }

       
    }
}
