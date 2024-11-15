namespace Examen_Equipo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            btnSalir = new Button();
            btnLimpiar = new Button();
            btnIngresar = new Button();
            txtContraseña = new TextBox();
            txtUsuario = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSalir);
            groupBox1.Controls.Add(btnLimpiar);
            groupBox1.Controls.Add(btnIngresar);
            groupBox1.Controls.Add(txtContraseña);
            groupBox1.Controls.Add(txtUsuario);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(69, 119);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(662, 315);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ingrese los datos requeridos";
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(478, 194);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(88, 35);
            btnSalir.TabIndex = 6;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(478, 119);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(88, 38);
            btnLimpiar.TabIndex = 5;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(478, 45);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(88, 36);
            btnIngresar.TabIndex = 4;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(164, 164);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '*';
            txtContraseña.Size = new Size(234, 29);
            txtContraseña.TabIndex = 3;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(164, 70);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(234, 29);
            txtUsuario.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 164);
            label3.Name = "label3";
            label3.Size = new Size(96, 21);
            label3.TabIndex = 1;
            label3.Text = "Contraseña :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 70);
            label2.Name = "label2";
            label2.Size = new Size(126, 21);
            label2.TabIndex = 0;
            label2.Text = "Ingrese Usuario :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(285, 17);
            label1.Name = "label1";
            label1.Size = new Size(234, 86);
            label1.TabIndex = 2;
            label1.Text = "LOGIN";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnSalir;
        private Button btnLimpiar;
        private Button btnIngresar;
        private TextBox txtContraseña;
        private TextBox txtUsuario;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}
