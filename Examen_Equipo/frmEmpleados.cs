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
    public partial class frmEmpleados : Form
    {
        public frmEmpleados()
        {
            InitializeComponent();
        }

        private TabControl tabControl1;
        private TabPage tpAlta;
        private TextBox txtLastName;
        private Label label1;
        private TabPage tpMostrar;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox10;
        private Label label11;
        private TextBox textBox11;
        private Label label12;
        private TextBox textBox8;
        private Label label9;
        private TextBox textBox9;
        private Label label10;
        private TextBox textBox6;
        private Label label7;
        private TextBox textBox7;
        private Label label8;
        private TextBox textBox4;
        private Label label5;
        private TextBox textBox5;
        private Label label6;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox16;
        private Label label17;
        private TextBox textBox17;
        private Label label18;
        private TextBox textBox12;
        private Label label13;
        private TextBox textBox13;
        private Label label14;
        private TextBox textBox14;
        private Label label15;
        private DataGridView dataGridView1;

        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tpAlta = new TabPage();
            textBox16 = new TextBox();
            label17 = new Label();
            textBox17 = new TextBox();
            label18 = new Label();
            textBox12 = new TextBox();
            label13 = new Label();
            textBox13 = new TextBox();
            label14 = new Label();
            textBox14 = new TextBox();
            label15 = new Label();
            textBox10 = new TextBox();
            label11 = new Label();
            textBox11 = new TextBox();
            label12 = new Label();
            textBox8 = new TextBox();
            label9 = new Label();
            textBox9 = new TextBox();
            label10 = new Label();
            textBox6 = new TextBox();
            label7 = new Label();
            textBox7 = new TextBox();
            label8 = new Label();
            textBox4 = new TextBox();
            label5 = new Label();
            textBox5 = new TextBox();
            label6 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            txtLastName = new TextBox();
            label1 = new Label();
            tpMostrar = new TabPage();
            dataGridView1 = new DataGridView();
            tabControl1.SuspendLayout();
            tpAlta.SuspendLayout();
            tpMostrar.SuspendLayout();
            ((ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tpAlta);
            tabControl1.Controls.Add(tpMostrar);
            tabControl1.Location = new Point(27, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(753, 278);
            tabControl1.TabIndex = 0;
            // 
            // tpAlta
            // 
            tpAlta.Controls.Add(textBox16);
            tpAlta.Controls.Add(label17);
            tpAlta.Controls.Add(textBox17);
            tpAlta.Controls.Add(label18);
            tpAlta.Controls.Add(textBox12);
            tpAlta.Controls.Add(label13);
            tpAlta.Controls.Add(textBox13);
            tpAlta.Controls.Add(label14);
            tpAlta.Controls.Add(textBox14);
            tpAlta.Controls.Add(label15);
            tpAlta.Controls.Add(textBox10);
            tpAlta.Controls.Add(label11);
            tpAlta.Controls.Add(textBox11);
            tpAlta.Controls.Add(label12);
            tpAlta.Controls.Add(textBox8);
            tpAlta.Controls.Add(label9);
            tpAlta.Controls.Add(textBox9);
            tpAlta.Controls.Add(label10);
            tpAlta.Controls.Add(textBox6);
            tpAlta.Controls.Add(label7);
            tpAlta.Controls.Add(textBox7);
            tpAlta.Controls.Add(label8);
            tpAlta.Controls.Add(textBox4);
            tpAlta.Controls.Add(label5);
            tpAlta.Controls.Add(textBox5);
            tpAlta.Controls.Add(label6);
            tpAlta.Controls.Add(textBox2);
            tpAlta.Controls.Add(label3);
            tpAlta.Controls.Add(textBox3);
            tpAlta.Controls.Add(label4);
            tpAlta.Controls.Add(textBox1);
            tpAlta.Controls.Add(label2);
            tpAlta.Controls.Add(txtLastName);
            tpAlta.Controls.Add(label1);
            tpAlta.Location = new Point(4, 24);
            tpAlta.Name = "tpAlta";
            tpAlta.Padding = new Padding(3);
            tpAlta.Size = new Size(745, 250);
            tpAlta.TabIndex = 0;
            tpAlta.Text = "Alta";
            tpAlta.UseVisualStyleBackColor = true;
            tpAlta.Click += tpAlta_Click;
            // 
            // textBox16
            // 
            textBox16.Location = new Point(563, 98);
            textBox16.Name = "textBox16";
            textBox16.Size = new Size(100, 23);
            textBox16.TabIndex = 33;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(567, 73);
            label17.Name = "label17";
            label17.Size = new Size(55, 15);
            label17.TabIndex = 32;
            label17.Text = "FotoPath";
            // 
            // textBox17
            // 
            textBox17.Location = new Point(559, 40);
            textBox17.Name = "textBox17";
            textBox17.Size = new Size(100, 23);
            textBox17.TabIndex = 31;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(563, 15);
            label18.Name = "label18";
            label18.Size = new Size(57, 15);
            label18.TabIndex = 30;
            label18.Text = "Reporta a";
            // 
            // textBox12
            // 
            textBox12.Location = new Point(428, 158);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(100, 23);
            textBox12.TabIndex = 29;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(432, 133);
            label13.Name = "label13";
            label13.Size = new Size(38, 15);
            label13.TabIndex = 28;
            label13.Text = "Notas";
            // 
            // textBox13
            // 
            textBox13.Location = new Point(428, 98);
            textBox13.Name = "textBox13";
            textBox13.Size = new Size(100, 23);
            textBox13.TabIndex = 27;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(432, 73);
            label14.Name = "label14";
            label14.Size = new Size(31, 15);
            label14.TabIndex = 26;
            label14.Text = "Foto";
            // 
            // textBox14
            // 
            textBox14.Location = new Point(424, 40);
            textBox14.Name = "textBox14";
            textBox14.Size = new Size(100, 23);
            textBox14.TabIndex = 25;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(428, 15);
            label15.Name = "label15";
            label15.Size = new Size(59, 15);
            label15.TabIndex = 24;
            label15.Text = "Extención";
            // 
            // textBox10
            // 
            textBox10.Location = new Point(280, 216);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(100, 23);
            textBox10.TabIndex = 23;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(284, 191);
            label11.Name = "label11";
            label11.Size = new Size(94, 15);
            label11.TabIndex = 22;
            label11.Text = "Teléfono de casa";
            // 
            // textBox11
            // 
            textBox11.Location = new Point(276, 158);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(100, 23);
            textBox11.TabIndex = 21;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(280, 133);
            label12.Name = "label12";
            label12.Size = new Size(28, 15);
            label12.TabIndex = 20;
            label12.Text = "País";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(276, 98);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(100, 23);
            textBox8.TabIndex = 19;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(280, 73);
            label9.Name = "label9";
            label9.Size = new Size(81, 15);
            label9.TabIndex = 18;
            label9.Text = "Código Postal";
            // 
            // textBox9
            // 
            textBox9.Location = new Point(272, 40);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(100, 23);
            textBox9.TabIndex = 17;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(276, 15);
            label10.Name = "label10";
            label10.Size = new Size(44, 15);
            label10.TabIndex = 16;
            label10.Text = "Región";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(149, 216);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(153, 191);
            label7.Name = "label7";
            label7.Size = new Size(45, 15);
            label7.TabIndex = 14;
            label7.Text = "Cuidad";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(145, 158);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(100, 23);
            textBox7.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(149, 133);
            label8.Name = "label8";
            label8.Size = new Size(57, 15);
            label8.TabIndex = 12;
            label8.Text = "Dirección";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(149, 98);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(153, 73);
            label5.Name = "label5";
            label5.Size = new Size(126, 15);
            label5.TabIndex = 10;
            label5.Text = "Fecha de Contratación";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(145, 40);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(149, 15);
            label6.Name = "label6";
            label6.Size = new Size(119, 15);
            label6.TabIndex = 8;
            label6.Text = "Fecha de Nacimiento";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(28, 216);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 191);
            label3.Name = "label3";
            label3.Size = new Size(106, 15);
            label3.TabIndex = 6;
            label3.Text = "Tñitulo de Cortesía";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(24, 158);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 133);
            label4.Name = "label4";
            label4.Size = new Size(37, 15);
            label4.TabIndex = 4;
            label4.Text = "Título";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(28, 98);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 73);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 2;
            label2.Text = "Nombre";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(24, 40);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(100, 23);
            txtLastName.TabIndex = 1;
            txtLastName.TextChanged += txtLastName_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 15);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Apellido";
            // 
            // tpMostrar
            // 
            tpMostrar.Controls.Add(dataGridView1);
            tpMostrar.Location = new Point(4, 24);
            tpMostrar.Name = "tpMostrar";
            tpMostrar.Padding = new Padding(3);
            tpMostrar.Size = new Size(745, 250);
            tpMostrar.TabIndex = 1;
            tpMostrar.Text = "Mostrar";
            tpMostrar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(26, 41);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(361, 186);
            dataGridView1.TabIndex = 0;
            // 
            // frmEmpleados
            // 
            ClientSize = new Size(852, 302);
            Controls.Add(tabControl1);
            Name = "frmEmpleados";
            Load += frmEmpleados_Load;
            tabControl1.ResumeLayout(false);
            tpAlta.ResumeLayout(false);
            tpAlta.PerformLayout();
            tpMostrar.ResumeLayout(false);
            ((ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        private void tpAlta_Click(object sender, EventArgs e)
        {

        }

        private void frmEmpleados_Load(object sender, EventArgs e)
        {

        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
