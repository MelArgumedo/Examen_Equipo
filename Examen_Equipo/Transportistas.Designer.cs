namespace Examen_Equipo
{
    partial class Transportistas
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
            components = new System.ComponentModel.Container();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            cmbCompanyName = new ComboBox();
            btnAceptar = new Button();
            mktPhone = new MaskedTextBox();
            label2 = new Label();
            label1 = new Label();
            tabPage2 = new TabPage();
            dgvShippers = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvShippers).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(426, 358);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(cmbCompanyName);
            tabPage1.Controls.Add(btnAceptar);
            tabPage1.Controls.Add(mktPhone);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(418, 330);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Alta";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // cmbCompanyName
            // 
            cmbCompanyName.FormattingEnabled = true;
            cmbCompanyName.Items.AddRange(new object[] { "Speedy Express", "United Package", "Federal Shipping" });
            cmbCompanyName.Location = new Point(18, 79);
            cmbCompanyName.Name = "cmbCompanyName";
            cmbCompanyName.Size = new Size(232, 23);
            cmbCompanyName.TabIndex = 5;
            cmbCompanyName.SelectedIndexChanged += cmbCompanyName_SelectedIndexChanged;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(291, 234);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 4;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // mktPhone
            // 
            mktPhone.Location = new Point(18, 181);
            mktPhone.Mask = "(999)000-0000";
            mktPhone.Name = "mktPhone";
            mktPhone.Size = new Size(232, 23);
            mktPhone.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 145);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 2;
            label2.Text = "Telefono";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 49);
            label1.Name = "label1";
            label1.Size = new Size(144, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre De La Compañia:";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dgvShippers);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(418, 330);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Mostrar";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvShippers
            // 
            dgvShippers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvShippers.Location = new Point(6, 34);
            dgvShippers.Name = "dgvShippers";
            dgvShippers.Size = new Size(406, 262);
            dgvShippers.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // Transportistas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(458, 387);
            Controls.Add(tabControl1);
            Name = "Transportistas";
            Text = "Transportistas";
            Load += Transportistas_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvShippers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private ContextMenuStrip contextMenuStrip1;
        private Label label1;
        private DataGridView dgvShippers;
        private MaskedTextBox mktPhone;
        private Label label2;
        private Button btnAceptar;
        private ComboBox cmbCompanyName;
    }
}