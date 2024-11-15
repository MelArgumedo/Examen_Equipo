namespace Examen_Equipo
{
    partial class frmEmpleados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tpAlta = new TabPage();
            btnAceptar = new Button();
            btnPhone = new Button();
            pbPhoto = new PictureBox();
            txtTitle = new TextBox();
            mtbHomePhone = new MaskedTextBox();
            cmbReportsTo = new ComboBox();
            dtpHireDate = new DateTimePicker();
            dtpBirthDate = new DateTimePicker();
            txtPhotoPath = new TextBox();
            label17 = new Label();
            label18 = new Label();
            txtNotes = new TextBox();
            label13 = new Label();
            label14 = new Label();
            txtExtension = new TextBox();
            label15 = new Label();
            label12 = new Label();
            txtCountry = new TextBox();
            label16 = new Label();
            txtPostalCode = new TextBox();
            label19 = new Label();
            txtRegion = new TextBox();
            label20 = new Label();
            txtCity = new TextBox();
            label21 = new Label();
            txtAddress = new TextBox();
            label22 = new Label();
            label23 = new Label();
            label24 = new Label();
            txtTitleOfCourtesy = new TextBox();
            label25 = new Label();
            label26 = new Label();
            txtFirstName = new TextBox();
            label27 = new Label();
            txtLastName = new TextBox();
            label28 = new Label();
            tpMostrar = new TabPage();
            dgvEmployees = new DataGridView();
            tabControl1.SuspendLayout();
            tpAlta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbPhoto).BeginInit();
            tpMostrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tpAlta);
            tabControl1.Controls.Add(tpMostrar);
            tabControl1.Location = new Point(34, 26);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(772, 354);
            tabControl1.TabIndex = 0;
            // 
            // tpAlta
            // 
            tpAlta.Controls.Add(btnAceptar);
            tpAlta.Controls.Add(btnPhone);
            tpAlta.Controls.Add(pbPhoto);
            tpAlta.Controls.Add(txtTitle);
            tpAlta.Controls.Add(mtbHomePhone);
            tpAlta.Controls.Add(cmbReportsTo);
            tpAlta.Controls.Add(dtpHireDate);
            tpAlta.Controls.Add(dtpBirthDate);
            tpAlta.Controls.Add(txtPhotoPath);
            tpAlta.Controls.Add(label17);
            tpAlta.Controls.Add(label18);
            tpAlta.Controls.Add(txtNotes);
            tpAlta.Controls.Add(label13);
            tpAlta.Controls.Add(label14);
            tpAlta.Controls.Add(txtExtension);
            tpAlta.Controls.Add(label15);
            tpAlta.Controls.Add(label12);
            tpAlta.Controls.Add(txtCountry);
            tpAlta.Controls.Add(label16);
            tpAlta.Controls.Add(txtPostalCode);
            tpAlta.Controls.Add(label19);
            tpAlta.Controls.Add(txtRegion);
            tpAlta.Controls.Add(label20);
            tpAlta.Controls.Add(txtCity);
            tpAlta.Controls.Add(label21);
            tpAlta.Controls.Add(txtAddress);
            tpAlta.Controls.Add(label22);
            tpAlta.Controls.Add(label23);
            tpAlta.Controls.Add(label24);
            tpAlta.Controls.Add(txtTitleOfCourtesy);
            tpAlta.Controls.Add(label25);
            tpAlta.Controls.Add(label26);
            tpAlta.Controls.Add(txtFirstName);
            tpAlta.Controls.Add(label27);
            tpAlta.Controls.Add(txtLastName);
            tpAlta.Controls.Add(label28);
            tpAlta.Location = new Point(4, 24);
            tpAlta.Name = "tpAlta";
            tpAlta.Padding = new Padding(3);
            tpAlta.Size = new Size(764, 326);
            tpAlta.TabIndex = 0;
            tpAlta.Text = "Alta";
            tpAlta.UseVisualStyleBackColor = true;
            tpAlta.Click += tpAlta_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(194, 294);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 109;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnPhone
            // 
            btnPhone.Location = new Point(473, 169);
            btnPhone.Name = "btnPhone";
            btnPhone.Size = new Size(121, 23);
            btnPhone.TabIndex = 108;
            btnPhone.Text = "Seleccionar imagen";
            btnPhone.UseVisualStyleBackColor = true;
            btnPhone.Click += btnPhone_Click;
            // 
            // pbPhoto
            // 
            pbPhoto.Location = new Point(477, 112);
            pbPhoto.Name = "pbPhoto";
            pbPhoto.Size = new Size(100, 50);
            pbPhoto.TabIndex = 107;
            pbPhoto.TabStop = false;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(7, 169);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(100, 23);
            txtTitle.TabIndex = 106;
            // 
            // mtbHomePhone
            // 
            mtbHomePhone.Location = new Point(345, 236);
            mtbHomePhone.Mask = "(999)000-0000";
            mtbHomePhone.Name = "mtbHomePhone";
            mtbHomePhone.Size = new Size(100, 23);
            mtbHomePhone.TabIndex = 105;
            // 
            // cmbReportsTo
            // 
            cmbReportsTo.FormattingEnabled = true;
            cmbReportsTo.Items.AddRange(new object[] { "2", "5" });
            cmbReportsTo.Location = new Point(591, 48);
            cmbReportsTo.Name = "cmbReportsTo";
            cmbReportsTo.Size = new Size(121, 23);
            cmbReportsTo.TabIndex = 104;
            // 
            // dtpHireDate
            // 
            dtpHireDate.Location = new Point(113, 109);
            dtpHireDate.Name = "dtpHireDate";
            dtpHireDate.Size = new Size(200, 23);
            dtpHireDate.TabIndex = 103;
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.Location = new Point(113, 48);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(200, 23);
            dtpBirthDate.TabIndex = 102;
            // 
            // txtPhotoPath
            // 
            txtPhotoPath.Location = new Point(612, 112);
            txtPhotoPath.Name = "txtPhotoPath";
            txtPhotoPath.Size = new Size(100, 23);
            txtPhotoPath.TabIndex = 101;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(616, 87);
            label17.Name = "label17";
            label17.Size = new Size(55, 15);
            label17.TabIndex = 100;
            label17.Text = "FotoPath";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(612, 29);
            label18.Name = "label18";
            label18.Size = new Size(57, 15);
            label18.TabIndex = 99;
            label18.Text = "Reporta a";
            // 
            // txtNotes
            // 
            txtNotes.Location = new Point(481, 262);
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new Size(100, 23);
            txtNotes.TabIndex = 98;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(485, 237);
            label13.Name = "label13";
            label13.Size = new Size(38, 15);
            label13.TabIndex = 97;
            label13.Text = "Notas";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(481, 87);
            label14.Name = "label14";
            label14.Size = new Size(31, 15);
            label14.TabIndex = 95;
            label14.Text = "Foto";
            // 
            // txtExtension
            // 
            txtExtension.Location = new Point(473, 54);
            txtExtension.Name = "txtExtension";
            txtExtension.Size = new Size(100, 23);
            txtExtension.TabIndex = 94;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(477, 29);
            label15.Name = "label15";
            label15.Size = new Size(59, 15);
            label15.TabIndex = 93;
            label15.Text = "Extención";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(345, 202);
            label12.Name = "label12";
            label12.Size = new Size(94, 15);
            label12.TabIndex = 92;
            label12.Text = "Teléfono de casa";
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(345, 169);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(100, 23);
            txtCountry.TabIndex = 91;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(345, 147);
            label16.Name = "label16";
            label16.Size = new Size(28, 15);
            label16.TabIndex = 90;
            label16.Text = "País";
            // 
            // txtPostalCode
            // 
            txtPostalCode.Location = new Point(345, 109);
            txtPostalCode.Name = "txtPostalCode";
            txtPostalCode.Size = new Size(100, 23);
            txtPostalCode.TabIndex = 89;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(345, 84);
            label19.Name = "label19";
            label19.Size = new Size(81, 15);
            label19.TabIndex = 88;
            label19.Text = "Código Postal";
            // 
            // txtRegion
            // 
            txtRegion.Location = new Point(345, 51);
            txtRegion.Name = "txtRegion";
            txtRegion.Size = new Size(100, 23);
            txtRegion.TabIndex = 87;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(368, 26);
            label20.Name = "label20";
            label20.Size = new Size(44, 15);
            label20.TabIndex = 86;
            label20.Text = "Región";
            // 
            // txtCity
            // 
            txtCity.Location = new Point(132, 227);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(100, 23);
            txtCity.TabIndex = 85;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(136, 202);
            label21.Name = "label21";
            label21.Size = new Size(45, 15);
            label21.TabIndex = 84;
            label21.Text = "Cuidad";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(128, 169);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(100, 23);
            txtAddress.TabIndex = 83;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(132, 144);
            label22.Name = "label22";
            label22.Size = new Size(57, 15);
            label22.TabIndex = 82;
            label22.Text = "Dirección";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(136, 84);
            label23.Name = "label23";
            label23.Size = new Size(126, 15);
            label23.TabIndex = 81;
            label23.Text = "Fecha de Contratación";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(132, 26);
            label24.Name = "label24";
            label24.Size = new Size(119, 15);
            label24.TabIndex = 80;
            label24.Text = "Fecha de Nacimiento";
            // 
            // txtTitleOfCourtesy
            // 
            txtTitleOfCourtesy.Location = new Point(11, 227);
            txtTitleOfCourtesy.Name = "txtTitleOfCourtesy";
            txtTitleOfCourtesy.Size = new Size(100, 23);
            txtTitleOfCourtesy.TabIndex = 79;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(15, 202);
            label25.Name = "label25";
            label25.Size = new Size(99, 15);
            label25.TabIndex = 78;
            label25.Text = "Título de Cortesía";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new Point(11, 144);
            label26.Name = "label26";
            label26.Size = new Size(37, 15);
            label26.TabIndex = 77;
            label26.Text = "Título";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(11, 109);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(100, 23);
            txtFirstName.TabIndex = 76;
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Location = new Point(15, 84);
            label27.Name = "label27";
            label27.Size = new Size(51, 15);
            label27.TabIndex = 75;
            label27.Text = "Nombre";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(7, 51);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(100, 23);
            txtLastName.TabIndex = 74;
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Location = new Point(15, 26);
            label28.Name = "label28";
            label28.Size = new Size(51, 15);
            label28.TabIndex = 73;
            label28.Text = "Apellido";
            // 
            // tpMostrar
            // 
            tpMostrar.Controls.Add(dgvEmployees);
            tpMostrar.Location = new Point(4, 24);
            tpMostrar.Name = "tpMostrar";
            tpMostrar.Padding = new Padding(3);
            tpMostrar.Size = new Size(764, 326);
            tpMostrar.TabIndex = 1;
            tpMostrar.Text = "Mostrar";
            tpMostrar.UseVisualStyleBackColor = true;
            // 
            // dgvEmployees
            // 
            dgvEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployees.Location = new Point(6, 23);
            dgvEmployees.Name = "dgvEmployees";
            dgvEmployees.Size = new Size(744, 289);
            dgvEmployees.TabIndex = 0;
            // 
            // frmEmpleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 450);
            Controls.Add(tabControl1);
            Name = "frmEmpleados";
            Text = "frmEmpleados";
            Activated += frmEmpleados_Activated;
            Load += frmEmpleados_Load;
            tabControl1.ResumeLayout(false);
            tpAlta.ResumeLayout(false);
            tpAlta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbPhoto).EndInit();
            tpMostrar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tpAlta;
        private TabPage tpMostrar;
        private TextBox txtTitle;
        private MaskedTextBox mtbHomePhone;
        private ComboBox cmbReportsTo;
        private DateTimePicker dtpHireDate;
        private DateTimePicker dtpBirthDate;
        private TextBox txtPhotoPath;
        private Label label17;
        private Label label18;
        private TextBox txtNotes;
        private Label label13;
        private Label label14;
        private TextBox txtExtension;
        private Label label15;
        private Label label12;
        private TextBox txtCountry;
        private Label label16;
        private TextBox txtPostalCode;
        private Label label19;
        private TextBox txtRegion;
        private Label label20;
        private TextBox txtCity;
        private Label label21;
        private TextBox txtAddress;
        private Label label22;
        private Label label23;
        private Label label24;
        private TextBox txtTitleOfCourtesy;
        private Label label25;
        private Label label26;
        private TextBox txtFirstName;
        private Label label27;
        private TextBox txtLastName;
        private Label label28;
        private PictureBox pbPhoto;
        private Button btnPhone;
        private Button btnAceptar;
        private DataGridView dgvEmployees;
    }
}