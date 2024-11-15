namespace Examen_Equipo
{
    partial class frmCategorias
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
            txtCategoryName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            txtDescripcion = new TextBox();
            label1 = new Label();
            tpMostrar = new TabPage();
            dgvCategories = new DataGridView();
            btnAceptar = new Button();
            tabControl1.SuspendLayout();
            tpAlta.SuspendLayout();
            tpMostrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategories).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tpAlta);
            tabControl1.Controls.Add(tpMostrar);
            tabControl1.Location = new Point(79, 39);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(625, 219);
            tabControl1.TabIndex = 0;
            // 
            // tpAlta
            // 
            tpAlta.Controls.Add(btnAceptar);
            tpAlta.Controls.Add(txtCategoryName);
            tpAlta.Controls.Add(label3);
            tpAlta.Controls.Add(label2);
            tpAlta.Controls.Add(txtDescripcion);
            tpAlta.Controls.Add(label1);
            tpAlta.Location = new Point(4, 24);
            tpAlta.Name = "tpAlta";
            tpAlta.Padding = new Padding(3);
            tpAlta.Size = new Size(617, 191);
            tpAlta.TabIndex = 0;
            tpAlta.Text = "Alta";
            tpAlta.UseVisualStyleBackColor = true;
            // 
            // txtCategoryName
            // 
            txtCategoryName.Location = new Point(21, 53);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(100, 23);
            txtCategoryName.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(341, 23);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 3;
            label3.Text = "Imagen";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(211, 23);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 2;
            label2.Text = "Descripción";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(198, 53);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(100, 23);
            txtDescripcion.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 23);
            label1.Name = "label1";
            label1.Size = new Size(119, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre de categoría";
            // 
            // tpMostrar
            // 
            tpMostrar.Controls.Add(dgvCategories);
            tpMostrar.Location = new Point(4, 24);
            tpMostrar.Name = "tpMostrar";
            tpMostrar.Padding = new Padding(3);
            tpMostrar.Size = new Size(617, 191);
            tpMostrar.TabIndex = 1;
            tpMostrar.Text = "Mostrar";
            tpMostrar.UseVisualStyleBackColor = true;
            // 
            // dgvCategories
            // 
            dgvCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategories.Location = new Point(6, 20);
            dgvCategories.Name = "dgvCategories";
            dgvCategories.Size = new Size(624, 150);
            dgvCategories.TabIndex = 0;
            dgvCategories.CellContentClick += dgvCategories_CellContentClick;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(313, 162);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 5;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // frmCategorias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "frmCategorias";
            Text = "frmCategorias";
            Activated += frmCategorias_Activated;
            Load += frmCategorias_Load;
            tabControl1.ResumeLayout(false);
            tpAlta.ResumeLayout(false);
            tpAlta.PerformLayout();
            tpMostrar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCategories).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tpAlta;
        private TabPage tpMostrar;
        private DataGridView dgvCategories;
        private TextBox txtDescripcion;
        private Label label1;
        private Label label3;
        private Label label2;
        private TextBox txtCategoryName;
        private Button btnAceptar;
    }
}