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
    public partial class frmTransportistas : Form
    {
        bool bandera = false;
        int ShipperID;
        Datos datos = new Datos();
        public frmTransportistas()
        {
            InitializeComponent();
        }
        public frmTransportistas(string ShipperID,string companyname, string phone)
        {
            InitializeComponent();
            this.ShipperID = Convert.ToInt32(ShipperID);
            cmbCompanyName.Text = companyname;
            mktPhone.Text = phone;
        }

        private Dictionary<string, string> phoneNumbers = new Dictionary<string, string>
        {
            { "Speedy Express", "(503)555-9831" },
            { "United Package", "(503)555-3199" },
            { "Federal Shipping", "(503)555-9931" }
        };
        private void Transportistas_Load(object sender, EventArgs e)
        {
            ActualizarGrid();
        }

        private void cmbCompanyName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCompanyName.SelectedItem != null)
            {
                string companyName = cmbCompanyName.SelectedItem.ToString();
                if (phoneNumbers.ContainsKey(companyName))
                {
                    mktPhone.Text = phoneNumbers[companyName];
                }
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Los datos son correctos?", "Sistema"
                , MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (bandera == true)
                {
                    bool j = datos.ejecutar("Update Shippers Set CompanyName ='" + cmbCompanyName.Text + "',Phone='" + mktPhone.Text + "',Where ShipperID=" + ShipperID);
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
                    bool j = datos.ejecutar("Insert Into Shippers(companyname,phone)" +
                        "Values('" + cmbCompanyName.Text + mktPhone.Text +  "')");
                    if (j == true)
                    {

                        MessageBox.Show("Datos Agregados Correctamente", "Sistema",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        mktPhone.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Error", "Sistema", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
            }
            
        }
        private void ActualizarGrid()
        {
            DataSet ds;
            ds = datos.consulta("Select ShipperID, CompanyName,Phone From Shippers");
            if (ds != null)
            {
                dgvShippers.DataSource = ds.Tables[0];
            }
        }
    }
}
