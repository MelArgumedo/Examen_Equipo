using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Examen_Equipo
{
    public partial class frmEmpleados : Form
    {
        bool bandera = false;
        int employeeid;
        Datos datos = new Datos();

        public frmEmpleados()
        {
            InitializeComponent();
        }

        public frmEmpleados(string employeeid, string lastname, string firstname, string title, string titleofcourtesy,
            string birthdate, string hiredate, string address, string city, string region, string postalcode, string country,
            string homephone, string extension, byte[] photoData, string notes, string photopath,
            int reportsto)
        {
            InitializeComponent();
            this.employeeid = Convert.ToInt32(employeeid);
            txtLastName.Text = lastname;
            txtFirstName.Text = firstname;
            txtTitle.Text = title;
            txtTitleOfCourtesy.Text = titleofcourtesy;
            dtpBirthDate.Text = birthdate;
            dtpHireDate.Text = hiredate;
            txtAddress.Text = address;
            txtCity.Text = city;
            txtRegion.Text = region;
            txtPostalCode.Text = postalcode;
            txtCountry.Text = country;
            mtbHomePhone.Text = homephone;
            txtExtension.Text = extension;
            txtPhotoPath.Text = photopath;
            txtNotes.Text = notes;
            cmbReportsTo.Text = reportsto.ToString();

            bandera = true;

            if (photoData != null && photoData.Length > 0)
            {
                pbPhoto.Image = ByteArrayToImage(photoData);
            }

        }


        private void frmEmpleados_Load(object sender, EventArgs e)
        {
            ActualizarGrid();
        }

        //private byte[] ImageToByteArray(Image image)
        //{
        //    using (MemoryStream ms = new MemoryStream())
        //    {
        //        image.Save(ms, image.RawFormat);
        //        return ms.ToArray();
        //    }
        //}
        private void btnAceptar_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("¿Los datos son correctos?", "Sistema"
                , MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question) == DialogResult.OK)
            {
                byte[] photoData = null;
                if (pbPhoto.Image != null)
                {
                    photoData = ImageToByteArray(pbPhoto.Image);
                }

                if (bandera == true)
                {
                    bool j = datos.ejecutar("Update Employees Set lastname='" + txtLastName.Text +
                        "',firstname='" + txtFirstName.Text + "',title='" + txtTitle.Text +
                        "',titleofcourtesy='" + txtTitleOfCourtesy.Text + "',birthdate='" + dtpBirthDate.Value.ToString("yyyy-MM-dd HH:mm:ss.fff") + "',hiredate='" + dtpHireDate.Value.ToString("yyyy-MM-dd HH:mm:ss.fff") +
                        "',address='" + txtAddress.Text + "',city='" + txtCity.Text + "',region='" + txtRegion.Text + "',postalcode='" + txtPostalCode.Text + "',country='" +
                        txtCountry.Text + "',homephone='" + mtbHomePhone.Text + "',extension='" + txtExtension.Text + "', photo = '" + Convert.ToBase64String(photoData) + "',notes='" + txtNotes.Text + "',reportsto='" + cmbReportsTo.Text + "',photopath='" + txtPhotoPath.Text + "'Where employeeid=" + employeeid);

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
                    bool j = datos.ejecutar("Insert Into Employees(lastname,firstname,title,titleofcourtesy,birthdate, hiredate,address,city,region,postalcode,country,homephone,extension,photo, notes, reportsto,photopath)" +
                        "Values('" + txtLastName.Text + "','" + txtFirstName.Text + "','" + txtTitle.Text + "'," + "'" + txtTitleOfCourtesy.Text + "','" + dtpBirthDate.Value.ToShortDateString() + "','" + dtpHireDate.Value.ToShortDateString() +
                        "','" + txtAddress.Text + "','" + txtCity.Text + "','" + txtRegion.Text + "','" + txtPostalCode.Text + "','" + txtCountry.Text + "','" + mtbHomePhone.Text + "','" + txtExtension.Text + "','" + Convert.ToBase64String(photoData) + "','" + txtNotes.Text + "','" + cmbReportsTo.Text + "','" + txtPhotoPath.Text + "')");
                    if (j == true)
                    {

                        MessageBox.Show("Datos Agregados Correctamente", "Sistema",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtLastName.Clear();
                        txtFirstName.Clear();
                        txtTitle.Clear();
                        txtTitleOfCourtesy.Clear();

                        txtAddress.Clear();
                        txtCity.Clear();
                        txtRegion.Clear();
                        txtPostalCode.Clear();
                        txtCountry.Clear();
                        mtbHomePhone.Clear();
                        txtExtension.Clear();
                        cmbReportsTo.Text = "";
                        pbPhoto.Image = null;

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
            ds = datos.consulta("Select EmployeeID,LastName,FirstName,Title,TitleOfCourtesy,BirthDate,HireDate,Address,City,Region,PostalCode,Country," +
                "HomePhone,Extension,Photo,Notes,ReportsTo,PhotoPath  From Employees");
            if (ds != null)
            {
                dgvEmployees.DataSource = ds.Tables[0];
            }
        }

        private byte[] ImageToByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, image.RawFormat);
                return ms.ToArray();
            }
        }

        private Image ByteArrayToImage(byte[] byteArray)
        {
            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                return Image.FromStream(ms);
            }
        }
        private void frmEmpleados_Activated(object sender, EventArgs e)
        {
            ActualizarGrid();
        }

        private void btnPhone_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pbPhoto.Image = new Bitmap(openFileDialog.FileName);
            }
        }

        private void tpAlta_Click(object sender, EventArgs e)
        {

        }
    }
}
