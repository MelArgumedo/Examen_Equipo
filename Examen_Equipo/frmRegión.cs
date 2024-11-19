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
    public partial class frmRegión : Form
    {
        bool bandera = false;
        int RegionID;
        Datos datos = new Datos();
        public frmRegión()
        {
            InitializeComponent();
        }

        public frmRegión(string RegionID, string RegionDescription)
        {
            InitializeComponent();
            this.RegionID = Convert.ToInt32(RegionID);
            cmbRegionDescription.Text = RegionDescription;

            bandera = true;
        }

        private void frmRegión_Load(object sender, EventArgs e)
        {
            ActualizarGrid();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Los datos son correctos?", "Sistema"
                , MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (bandera == true)
                {
                    bool j = datos.ejecutar("Update Region Set RegionDescription='" + cmbRegionDescription.Text + "'Where RegionID=" + RegionID);
                    if (j == true)
                    {
                        MessageBox.Show("Datos Actualizados", "Sistema", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error", "Sistema", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
                else
                {
                    bool j = datos.ejecutar("Update Region Set RegionDescription='" + cmbRegionDescription.Text + "'Where RegionID=" + RegionID);
                    if (j == true)
                    {
                        MessageBox.Show("Datos agregados correctamente", "Sistema",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cmbRegionDescription.Items.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Error", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void ActualizarGrid()
        {
            DataSet ds;
            ds = datos.consulta("Select RegionID, RegionDescription");
            if (ds != null)
            {
                dgvRegion.DataSource = ds.Tables[0];
            }
        }
    }
}
