namespace Examen_Equipo
{
    partial class frmRegión
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
            tabPage1 = new TabPage();
            cmbRegionDescription = new ComboBox();
            btnAceptar = new Button();
            label1 = new Label();
            tabPage2 = new TabPage();
            dgvRegion = new DataGridView();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRegion).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(24, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(389, 232);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(cmbRegionDescription);
            tabPage1.Controls.Add(btnAceptar);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(381, 204);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Alta";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // cmbRegionDescription
            // 
            cmbRegionDescription.FormattingEnabled = true;
            cmbRegionDescription.Items.AddRange(new object[] { "Norte", "Sur", "Este", "Oeste" });
            cmbRegionDescription.Location = new Point(20, 78);
            cmbRegionDescription.Name = "cmbRegionDescription";
            cmbRegionDescription.Size = new Size(189, 23);
            cmbRegionDescription.TabIndex = 3;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(258, 77);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 2;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 48);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 0;
            label1.Text = "Descripción";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dgvRegion);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(381, 204);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Mostrar";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvRegion
            // 
            dgvRegion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRegion.Location = new Point(17, 25);
            dgvRegion.Name = "dgvRegion";
            dgvRegion.Size = new Size(335, 153);
            dgvRegion.TabIndex = 0;
            // 
            // frmRegión
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(449, 272);
            Controls.Add(tabControl1);
            Name = "frmRegión";
            Text = "Región";
            Load += frmRegión_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRegion).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView dgvRegion;
        private Label label1;
        private Button btnAceptar;
        private ComboBox cmbRegionDescription;
    }
}