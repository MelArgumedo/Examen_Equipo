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

        Datos datos = new Datos();
        public Clientes()
        {
            InitializeComponent();
        }
        public Clientes(string customerid, string companyname, string contactname, string contacttitle, string address, string city, string region, string postalcode,
            string country, string phone, string fax)
        {
            InitializeComponent();
            mtbCustumerId.Text = customerid;
            txtCompanyName.Text = companyname;
            txtContactName.Text = contactname;
            txtContactTitle.Text = contacttitle;
            txtAddress.Text = address;
            txtCity.Text = city;
            txtRegion.Text = region;
            txtPostalCode.Text = postalcode;
            txtCountry.Text = country;
            mtbPhone.Text = phone;
            mtbFax.Text = fax;
            bandera = true; 

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {



            if (MessageBox.Show("¿Los datos son correctos?", "Sistema"
                , MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (bandera == true)
                {
                    bool j = datos.ejecutar("Update Customers Set companyname='" + txtCompanyName.Text +
                        "',contactname='" + txtContactName.Text + "',contacttitle='" + txtContactTitle.Text +
                        "',address='" + txtAddress.Text + "',city='" + txtCity.Text + "',region='" + txtRegion.Text +
                        "',postalcode='" + txtPostalCode.Text + "',country='" +
                        txtCountry.Text + "',phone='" + mtbPhone.Text + "',fax='" + mtbFax.Text + "'Where customerid=" + mtbCustumerId.Text);

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
                    bool j = datos.ejecutar("Insert Into Customers(customerid, companyname,contactname,contacttitle,address,city,region,postalcode,country,phone,fax)" +
                        "Values('" + mtbCustumerId.Text + "','" + txtCompanyName.Text + "','" + txtContactName.Text + "'," + "'" + txtContactTitle.Text + "','" + txtAddress.Text + "','" + txtCity.Text +
                        "','" + txtRegion.Text + "','" + txtPostalCode.Text + "','" + txtCountry.Text + "','" + mtbPhone.Text + "','" + mtbFax.Text + "')");
                    if (j == true)
                    {

                        MessageBox.Show("Datos Agregados Correctamente", "Sistema",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        mtbCustumerId.Clear();
                        txtCompanyName.Clear();
                        txtContactName.Clear();
                        txtContactTitle.Clear();
                        txtAddress.Clear();
                        txtCity.Clear();
                        txtRegion.Clear();
                        txtPostalCode.Clear();
                        txtCountry.Clear();
                        mtbPhone.Clear();
                        mtbFax.Clear();

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
            ds = datos.consulta("Select CustomerID, CompanyName,ContactName,ContactTitle,Address,City,Region,PostalCode,Country,Phone,Fax  From Customers");
            if (ds != null)
            {
                dgvCustomers.DataSource = ds.Tables[0];
            }
        }
        private void Clientes_Load(object sender, EventArgs e)
        {
            ActualizarGrid();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Clientes_Activated(object sender, EventArgs e)
        {
            ActualizarGrid();

        }
    }
}
