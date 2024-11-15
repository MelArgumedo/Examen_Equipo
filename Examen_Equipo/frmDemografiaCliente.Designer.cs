namespace Examen_Equipo
{
    partial class frmDemografiaCliente
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
            tpMostrar = new TabPage();
            dgvCustomerDemographics = new DataGridView();
            txtDescripcionCliente = new TextBox();
            label2 = new Label();
            tabControl1.SuspendLayout();
            tpAlta.SuspendLayout();
            tpMostrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustomerDemographics).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tpAlta);
            tabControl1.Controls.Add(tpMostrar);
            tabControl1.Location = new Point(54, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(564, 278);
            tabControl1.TabIndex = 0;
            // 
            // tpAlta
            // 
            tpAlta.Controls.Add(txtDescripcionCliente);
            tpAlta.Controls.Add(label2);
            tpAlta.Location = new Point(4, 24);
            tpAlta.Name = "tpAlta";
            tpAlta.Padding = new Padding(3);
            tpAlta.Size = new Size(556, 250);
            tpAlta.TabIndex = 0;
            tpAlta.Text = "Alta";
            tpAlta.UseVisualStyleBackColor = true;
            // 
            // tpMostrar
            // 
            tpMostrar.Controls.Add(dgvCustomerDemographics);
            tpMostrar.Location = new Point(4, 24);
            tpMostrar.Name = "tpMostrar";
            tpMostrar.Padding = new Padding(3);
            tpMostrar.Size = new Size(556, 250);
            tpMostrar.TabIndex = 1;
            tpMostrar.Text = "Mostrar";
            tpMostrar.UseVisualStyleBackColor = true;
            // 
            // dgvCustomerDemographics
            // 
            dgvCustomerDemographics.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomerDemographics.Location = new Point(26, 41);
            dgvCustomerDemographics.Name = "dgvCustomerDemographics";
            dgvCustomerDemographics.Size = new Size(453, 166);
            dgvCustomerDemographics.TabIndex = 0;
            // 
            // txtDescripcionCliente
            // 
            txtDescripcionCliente.Location = new Point(15, 54);
            txtDescripcionCliente.Name = "txtDescripcionCliente";
            txtDescripcionCliente.Size = new Size(100, 23);
            txtDescripcionCliente.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 36);
            label2.Name = "label2";
            label2.Size = new Size(126, 15);
            label2.TabIndex = 2;
            label2.Text = "Descripcion del cliente";
            // 
            // frmDemografiaCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "frmDemografiaCliente";
            Text = "frmDemografiaCliente";
            tabControl1.ResumeLayout(false);
            tpAlta.ResumeLayout(false);
            tpAlta.PerformLayout();
            tpMostrar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCustomerDemographics).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tpAlta;
        private TabPage tpMostrar;
        private DataGridView dgvCustomerDemographics;
        private TextBox txtDescripcionCliente;
        private Label label2;
    }
}