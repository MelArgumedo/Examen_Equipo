﻿namespace Examen_Equipo
{
    partial class Clientes
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
            mtbFax = new MaskedTextBox();
            mtbPhone = new MaskedTextBox();
            mtbCustumerId = new MaskedTextBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            btnAceptar = new Button();
            txtPostalCode = new TextBox();
            label8 = new Label();
            txtCountry = new TextBox();
            label7 = new Label();
            txtRegion = new TextBox();
            label6 = new Label();
            txtCity = new TextBox();
            label5 = new Label();
            txtAddress = new TextBox();
            label4 = new Label();
            txtContactTitle = new TextBox();
            label3 = new Label();
            txtContactName = new TextBox();
            label2 = new Label();
            txtCompanyName = new TextBox();
            label1 = new Label();
            tpMostrar = new TabPage();
            dgvCustomers = new DataGridView();
            tabControl1.SuspendLayout();
            tpAlta.SuspendLayout();
            tpMostrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tpAlta);
            tabControl1.Controls.Add(tpMostrar);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(838, 387);
            tabControl1.TabIndex = 0;
            // 
            // tpAlta
            // 
            tpAlta.Controls.Add(mtbFax);
            tpAlta.Controls.Add(mtbPhone);
            tpAlta.Controls.Add(mtbCustumerId);
            tpAlta.Controls.Add(label11);
            tpAlta.Controls.Add(label10);
            tpAlta.Controls.Add(label9);
            tpAlta.Controls.Add(btnAceptar);
            tpAlta.Controls.Add(txtPostalCode);
            tpAlta.Controls.Add(label8);
            tpAlta.Controls.Add(txtCountry);
            tpAlta.Controls.Add(label7);
            tpAlta.Controls.Add(txtRegion);
            tpAlta.Controls.Add(label6);
            tpAlta.Controls.Add(txtCity);
            tpAlta.Controls.Add(label5);
            tpAlta.Controls.Add(txtAddress);
            tpAlta.Controls.Add(label4);
            tpAlta.Controls.Add(txtContactTitle);
            tpAlta.Controls.Add(label3);
            tpAlta.Controls.Add(txtContactName);
            tpAlta.Controls.Add(label2);
            tpAlta.Controls.Add(txtCompanyName);
            tpAlta.Controls.Add(label1);
            tpAlta.Location = new Point(4, 24);
            tpAlta.Name = "tpAlta";
            tpAlta.Padding = new Padding(3);
            tpAlta.Size = new Size(830, 359);
            tpAlta.TabIndex = 0;
            tpAlta.Text = "Alta";
            tpAlta.UseVisualStyleBackColor = true;
            // 
            // mtbFax
            // 
            mtbFax.Location = new Point(213, 277);
            mtbFax.Mask = "(999)000-0000";
            mtbFax.Name = "mtbFax";
            mtbFax.Size = new Size(100, 23);
            mtbFax.TabIndex = 25;
            // 
            // mtbPhone
            // 
            mtbPhone.Location = new Point(212, 189);
            mtbPhone.Mask = "(999)000-0000";
            mtbPhone.Name = "mtbPhone";
            mtbPhone.Size = new Size(100, 23);
            mtbPhone.TabIndex = 24;
            // 
            // mtbCustumerId
            // 
            mtbCustumerId.Location = new Point(46, 30);
            mtbCustumerId.Mask = "AAAAA";
            mtbCustumerId.Name = "mtbCustumerId";
            mtbCustumerId.Size = new Size(100, 23);
            mtbCustumerId.TabIndex = 23;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(55, 7);
            label11.Name = "label11";
            label11.Size = new Size(17, 15);
            label11.TabIndex = 21;
            label11.Text = "Id";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(213, 244);
            label10.Name = "label10";
            label10.Size = new Size(25, 15);
            label10.TabIndex = 19;
            label10.Text = "Fax";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(46, 200);
            label9.Name = "label9";
            label9.Size = new Size(106, 15);
            label9.TabIndex = 17;
            label9.Text = "Título del contacto";
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(356, 319);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 16;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // txtPostalCode
            // 
            txtPostalCode.Location = new Point(200, 77);
            txtPostalCode.Name = "txtPostalCode";
            txtPostalCode.Size = new Size(100, 23);
            txtPostalCode.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(47, 259);
            label8.Name = "label8";
            label8.Size = new Size(57, 15);
            label8.TabIndex = 14;
            label8.Text = "Dirección";
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(213, 127);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(100, 23);
            txtCountry.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(46, 139);
            label7.Name = "label7";
            label7.Size = new Size(120, 15);
            label7.TabIndex = 12;
            label7.Text = "Nombre del contacto";
            // 
            // txtRegion
            // 
            txtRegion.Location = new Point(200, 25);
            txtRegion.Name = "txtRegion";
            txtRegion.Size = new Size(100, 23);
            txtRegion.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(213, 171);
            label6.Name = "label6";
            label6.Size = new Size(52, 15);
            label6.TabIndex = 10;
            label6.Text = "Teléfono";
            // 
            // txtCity
            // 
            txtCity.Location = new Point(46, 335);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(100, 23);
            txtCity.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(213, 109);
            label5.Name = "label5";
            label5.Size = new Size(28, 15);
            label5.TabIndex = 8;
            label5.Text = "País";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(46, 277);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(100, 23);
            txtAddress.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(200, 59);
            label4.Name = "label4";
            label4.Size = new Size(81, 15);
            label4.TabIndex = 6;
            label4.Text = "Código Postal";
            // 
            // txtContactTitle
            // 
            txtContactTitle.Location = new Point(46, 218);
            txtContactTitle.Name = "txtContactTitle";
            txtContactTitle.Size = new Size(100, 23);
            txtContactTitle.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(213, 7);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 4;
            label3.Text = "Región";
            // 
            // txtContactName
            // 
            txtContactName.Location = new Point(46, 162);
            txtContactName.Name = "txtContactName";
            txtContactName.Size = new Size(100, 23);
            txtContactName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 317);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 2;
            label2.Text = "Ciudad";
            // 
            // txtCompanyName
            // 
            txtCompanyName.Location = new Point(46, 103);
            txtCompanyName.Name = "txtCompanyName";
            txtCompanyName.Size = new Size(100, 23);
            txtCompanyName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 85);
            label1.Name = "label1";
            label1.Size = new Size(107, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre compañia";
            // 
            // tpMostrar
            // 
            tpMostrar.Controls.Add(dgvCustomers);
            tpMostrar.Location = new Point(4, 24);
            tpMostrar.Name = "tpMostrar";
            tpMostrar.Padding = new Padding(3);
            tpMostrar.Size = new Size(830, 359);
            tpMostrar.TabIndex = 1;
            tpMostrar.Text = "Mostrar";
            tpMostrar.UseVisualStyleBackColor = true;
            // 
            // dgvCustomers
            // 
            dgvCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomers.Location = new Point(6, 51);
            dgvCustomers.Name = "dgvCustomers";
            dgvCustomers.Size = new Size(700, 209);
            dgvCustomers.TabIndex = 0;
            dgvCustomers.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Clientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(862, 450);
            Controls.Add(tabControl1);
            Name = "Clientes";
            Text = "Clientes";
            Activated += Clientes_Activated;
            Load += Clientes_Load;
            tabControl1.ResumeLayout(false);
            tpAlta.ResumeLayout(false);
            tpAlta.PerformLayout();
            tpMostrar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tpAlta;
        private TextBox txtPostalCode;
        private Label label8;
        private TextBox txtCountry;
        private Label label7;
        private TextBox txtRegion;
        private Label label6;
        private TextBox txtCity;
        private Label label5;
        private TextBox txtAddress;
        private Label label4;
        private TextBox txtContactTitle;
        private Label label3;
        private TextBox txtContactName;
        private Label label2;
        private TextBox txtCompanyName;
        private Label label1;
        private TabPage tpMostrar;
        private DataGridView dgvCustomers;
        private Button btnAceptar;
        private TextBox txtPhone;
        private Label label9;
        private Label label10;
        private Label label11;
        private MaskedTextBox mtbCustumerId;
        private MaskedTextBox mtbPhone;
        private MaskedTextBox mtbFax;
    }
}