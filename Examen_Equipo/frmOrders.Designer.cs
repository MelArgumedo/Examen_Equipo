namespace Examen_Equipo
{
    partial class frmOrders
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
            textBox7 = new TextBox();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            dateTimePicker3 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            tpMostrar = new TabPage();
            dataGridView1 = new DataGridView();
            tabControl2 = new TabControl();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            tabControl1.SuspendLayout();
            tpAlta.SuspendLayout();
            tpMostrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabControl2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tpAlta);
            tabControl1.Controls.Add(tpMostrar);
            tabControl1.Location = new Point(29, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(622, 317);
            tabControl1.TabIndex = 0;
            // 
            // tpAlta
            // 
            tpAlta.Controls.Add(textBox7);
            tpAlta.Controls.Add(textBox6);
            tpAlta.Controls.Add(textBox5);
            tpAlta.Controls.Add(textBox4);
            tpAlta.Controls.Add(textBox3);
            tpAlta.Controls.Add(textBox2);
            tpAlta.Controls.Add(textBox1);
            tpAlta.Controls.Add(dateTimePicker3);
            tpAlta.Controls.Add(dateTimePicker2);
            tpAlta.Controls.Add(label12);
            tpAlta.Controls.Add(label11);
            tpAlta.Controls.Add(label10);
            tpAlta.Controls.Add(label9);
            tpAlta.Controls.Add(label8);
            tpAlta.Controls.Add(label6);
            tpAlta.Controls.Add(label5);
            tpAlta.Controls.Add(label4);
            tpAlta.Controls.Add(label3);
            tpAlta.Controls.Add(label2);
            tpAlta.Controls.Add(label1);
            tpAlta.Controls.Add(dateTimePicker1);
            tpAlta.Location = new Point(4, 24);
            tpAlta.Name = "tpAlta";
            tpAlta.Padding = new Padding(3);
            tpAlta.Size = new Size(614, 289);
            tpAlta.TabIndex = 0;
            tpAlta.Text = "Alta";
            tpAlta.UseVisualStyleBackColor = true;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(261, 93);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(100, 23);
            textBox7.TabIndex = 21;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(277, 173);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 20;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(257, 133);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 19;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(262, 208);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 18;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(262, 252);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 17;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(277, 45);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 16;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(40, 246);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 15;
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Location = new Point(23, 155);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(200, 23);
            dateTimePicker3.TabIndex = 14;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(23, 108);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(200, 23);
            dateTimePicker2.TabIndex = 13;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(28, 137);
            label12.Name = "label12";
            label12.Size = new Size(86, 15);
            label12.TabIndex = 12;
            label12.Text = "Fecha de Envío";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(25, 181);
            label11.Name = "label11";
            label11.Size = new Size(97, 15);
            label11.TabIndex = 11;
            label11.Text = "Método de envío";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(32, 223);
            label10.Name = "label10";
            label10.Size = new Size(90, 15);
            label10.TabIndex = 10;
            label10.Text = "Gastos de envío";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(262, 24);
            label9.Name = "label9";
            label9.Size = new Size(116, 15);
            label9.TabIndex = 9;
            label9.Text = "Nombre destinatario";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(277, 234);
            label8.Name = "label8";
            label8.Size = new Size(76, 15);
            label8.TabIndex = 8;
            label8.Text = "País de Envío";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(261, 192);
            label6.Name = "label6";
            label6.Size = new Size(137, 15);
            label6.TabIndex = 6;
            label6.Text = "Códogo Postad de Envío";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(262, 75);
            label5.Name = "label5";
            label5.Size = new Size(89, 15);
            label5.TabIndex = 5;
            label5.Text = "Dirección Envio";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(262, 116);
            label4.Name = "label4";
            label4.Size = new Size(93, 15);
            label4.TabIndex = 4;
            label4.Text = "Ciudad de envío";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(261, 154);
            label3.Name = "label3";
            label3.Size = new Size(92, 15);
            label3.TabIndex = 3;
            label3.Text = "Región de Envío";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 81);
            label2.Name = "label2";
            label2.Size = new Size(91, 15);
            label2.TabIndex = 2;
            label2.Text = "Fecha requerida";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 24);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 1;
            label1.Text = "Fecha de pedido";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(28, 55);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 0;
            // 
            // tpMostrar
            // 
            tpMostrar.Controls.Add(dataGridView1);
            tpMostrar.Location = new Point(4, 24);
            tpMostrar.Name = "tpMostrar";
            tpMostrar.Padding = new Padding(3);
            tpMostrar.Size = new Size(614, 289);
            tpMostrar.TabIndex = 1;
            tpMostrar.Text = "Mostrar";
            tpMostrar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(22, 31);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(480, 230);
            dataGridView1.TabIndex = 0;
            // 
            // tabControl2
            // 
            tabControl2.Controls.Add(tabPage3);
            tabControl2.Controls.Add(tabPage4);
            tabControl2.Location = new Point(351, 67);
            tabControl2.Name = "tabControl2";
            tabControl2.SelectedIndex = 0;
            tabControl2.Size = new Size(8, 8);
            tabControl2.TabIndex = 1;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(0, 0);
            tabPage3.TabIndex = 0;
            tabPage3.Text = "tabPage3";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(0, 0);
            tabPage4.TabIndex = 1;
            tabPage4.Text = "tabPage4";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // frmOrders
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl2);
            Controls.Add(tabControl1);
            Name = "frmOrders";
            Text = "frmOrders";
            tabControl1.ResumeLayout(false);
            tpAlta.ResumeLayout(false);
            tpAlta.PerformLayout();
            tpMostrar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabControl2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tpAlta;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private TabPage tpMostrar;
        private TabControl tabControl2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private DateTimePicker dateTimePicker3;
        private DateTimePicker dateTimePicker2;
        private TextBox textBox2;
        private TextBox textBox1;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private DataGridView dataGridView1;
    }
}