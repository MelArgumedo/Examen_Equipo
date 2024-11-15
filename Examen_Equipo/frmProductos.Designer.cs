namespace Examen_Equipo
{
    partial class frmProductos
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
            label7 = new Label();
            label5 = new Label();
            label6 = new Label();
            label3 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            cmbProductName = new ComboBox();
            txtQuantityPerUnit = new TextBox();
            txtUnitPrice = new TextBox();
            cmbUnitsInStock = new ComboBox();
            cmbUnitsOnOrder = new ComboBox();
            cmbReorderLevel = new ComboBox();
            dudDiscontinued = new DomainUpDown();
            tabControl1.SuspendLayout();
            tpAlta.SuspendLayout();
            tpMostrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tpAlta);
            tabControl1.Controls.Add(tpMostrar);
            tabControl1.Location = new Point(58, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(461, 288);
            tabControl1.TabIndex = 0;
            // 
            // tpAlta
            // 
            tpAlta.Controls.Add(dudDiscontinued);
            tpAlta.Controls.Add(cmbReorderLevel);
            tpAlta.Controls.Add(cmbUnitsOnOrder);
            tpAlta.Controls.Add(cmbUnitsInStock);
            tpAlta.Controls.Add(txtUnitPrice);
            tpAlta.Controls.Add(txtQuantityPerUnit);
            tpAlta.Controls.Add(cmbProductName);
            tpAlta.Controls.Add(label7);
            tpAlta.Controls.Add(label5);
            tpAlta.Controls.Add(label6);
            tpAlta.Controls.Add(label3);
            tpAlta.Controls.Add(label4);
            tpAlta.Controls.Add(label2);
            tpAlta.Controls.Add(label1);
            tpAlta.Location = new Point(4, 24);
            tpAlta.Name = "tpAlta";
            tpAlta.Padding = new Padding(3);
            tpAlta.Size = new Size(453, 260);
            tpAlta.TabIndex = 0;
            tpAlta.Text = "Alta";
            tpAlta.UseVisualStyleBackColor = true;
            // 
            // tpMostrar
            // 
            tpMostrar.Controls.Add(dataGridView1);
            tpMostrar.Location = new Point(4, 24);
            tpMostrar.Name = "tpMostrar";
            tpMostrar.Padding = new Padding(3);
            tpMostrar.Size = new Size(453, 260);
            tpMostrar.TabIndex = 1;
            tpMostrar.Text = "Mostrar";
            tpMostrar.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(249, 99);
            label7.Name = "label7";
            label7.Size = new Size(87, 15);
            label7.TabIndex = 26;
            label7.Text = "Descontinuado";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(247, 52);
            label5.Name = "label5";
            label5.Size = new Size(89, 15);
            label5.TabIndex = 24;
            label5.Text = "Reordenar nivel";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(247, 7);
            label6.Name = "label6";
            label6.Size = new Size(106, 15);
            label6.TabIndex = 22;
            label6.Text = "Unidades en orden";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 148);
            label3.Name = "label3";
            label3.Size = new Size(103, 15);
            label3.TabIndex = 20;
            label3.Text = "Unidades en stock";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 99);
            label4.Name = "label4";
            label4.Size = new Size(84, 15);
            label4.TabIndex = 18;
            label4.Text = "Precio unitario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 52);
            label2.Name = "label2";
            label2.Size = new Size(116, 15);
            label2.TabIndex = 16;
            label2.Text = "Cantidad por unidad";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 7);
            label1.Name = "label1";
            label1.Size = new Size(122, 15);
            label1.TabIndex = 14;
            label1.Text = "Nombre del producto";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(20, 20);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(414, 221);
            dataGridView1.TabIndex = 0;
            // 
            // cmbProductName
            // 
            cmbProductName.FormattingEnabled = true;
            cmbProductName.Items.AddRange(new object[] { "Chai", "Chang", "Aniseed Syrup", "Chef Anton's Cajun Seasoning", "Chef Anton's Gumbo Mix", "Grandma's Boysenberry Spread", "Uncle Bob's Organic Dried Pears", "Northwoods Cranberry Sauce", "Mishi Kobe Niku", "Ikura", "Queso Cabrales", "Queso Manchego La Pastora", "Konbu", "Tofu", "Genen Shouyu", "Pavlova", "Alice Mutton", "Carnarvon Tigers", "Teatime Chocolate Biscuits", "Sir Rodney's Marmalade", "Sir Rodney's Scones", "Gustaf's Knäckebröd", "Tunnbröd", "Guaraná Fantástica", "NuNuCa Nuß-Nougat-Creme", "Gumbär Gummibärchen", "Schoggi Schokolade", "Rössle Sauerkraut", "Thüringer Rostbratwurst", "Nord-Ost Matjeshering", "Gorgonzola Telino", "Mascarpone Fabioli", "Geitost", "Sasquatch Ale", "Steeleye Stout", "Inlagd Sill", "Gravad lax", "Côte de Blaye", "Chartreuse verte", "Boston Crab Meat", "Jack's New England Clam Chowder", "Singaporean Hokkien Fried Mee", "Ipoh Coffee", "Gula Malacca", "Rogede sild", "Spegesild", "Zaanse koeken", "Chocolade", "Maxilaku", "Valkoinen suklaa", "Manjimup Dried Apples", "Filo Mix", "Perth Pasties", "Tourtière", "Pâté chinois", "Gnocchi di nonna Alice", "Ravioli Angelo", "Escargots de Bourgogne", "Raclette Courdavault", "Camembert Pierrot", "Sirop d'érable", "Tarte au sucre", "Vegie-spread", "Wimmers gute Semmelknödel", "Louisiana Fiery Hot Pepper Sauce", "Louisiana Hot Spiced Okra", "Laughing Lumberjack Lager", "Scottish Longbreads", "Gudbrandsdalsost", "Outback Lager", "Flotemysost", "Mozzarella di Giovanni", "Röd Kaviar", "Longlife Tofu", "Rhönbräu Klosterbier", "Lakkalikööri", "Original Frankfurter grüne Soße" });
            cmbProductName.Location = new Point(21, 25);
            cmbProductName.Name = "cmbProductName";
            cmbProductName.Size = new Size(121, 23);
            cmbProductName.TabIndex = 27;
            // 
            // txtQuantityPerUnit
            // 
            txtQuantityPerUnit.Location = new Point(38, 73);
            txtQuantityPerUnit.Name = "txtQuantityPerUnit";
            txtQuantityPerUnit.Size = new Size(100, 23);
            txtQuantityPerUnit.TabIndex = 28;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(38, 122);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(100, 23);
            txtUnitPrice.TabIndex = 29;
            // 
            // cmbUnitsInStock
            // 
            cmbUnitsInStock.FormattingEnabled = true;
            cmbUnitsInStock.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59", "60", "61", "62", "63", "64", "65", "66", "67", "68", "69", "70", "71", "72", "73", "74", "75", "76", "77", "78", "79", "80", "81", "82", "83", "84", "85", "86", "87", "88", "89", "90", "91", "92", "93", "94", "95", "96", "97", "98", "99", "100", "101", "102", "103", "104", "105", "106", "107", "108", "109", "110", "111", "112", "113", "114", "115", "116", "117", "118", "119", "120", "121", "122", "123", "124", "125", "126", "127", "128", "129", "130", "131", "132", "133", "134", "135", "136", "137", "138", "139", "140", "141", "142", "143", "144", "145", "146", "147", "148", "149", "150", "151", "152", "153", "154", "155", "156", "157", "158", "159", "160", "161", "162", "163", "164", "165", "166", "167", "168", "169", "170", "171", "172", "173", "174", "175", "176", "177", "178", "179", "180", "181", "182", "183", "184", "185", "186", "187", "188", "189", "190", "191", "192", "193", "194", "195", "196", "197", "198", "199", "200" });
            cmbUnitsInStock.Location = new Point(38, 178);
            cmbUnitsInStock.Name = "cmbUnitsInStock";
            cmbUnitsInStock.Size = new Size(121, 23);
            cmbUnitsInStock.TabIndex = 32;
            // 
            // cmbUnitsOnOrder
            // 
            cmbUnitsOnOrder.FormattingEnabled = true;
            cmbUnitsOnOrder.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59", "60", "61", "62", "63", "64", "65", "66", "67", "68", "69", "70", "71", "72", "73", "74", "75", "76", "77", "78", "79", "80", "81", "82", "83", "84", "85", "86", "87", "88", "89", "90", "91", "92", "93", "94", "95", "96", "97", "98", "99", "100", "101", "102", "103", "104", "105", "106", "107", "108", "109", "110", "111", "112", "113", "114", "115", "116", "117", "118", "119", "120", "121", "122", "123", "124", "125", "126", "127", "128", "129", "130", "131", "132", "133", "134", "135", "136", "137", "138", "139", "140", "141", "142", "143", "144", "145", "146", "147", "148", "149", "150", "151", "152", "153", "154", "155", "156", "157", "158", "159", "160", "161", "162", "163", "164", "165", "166", "167", "168", "169", "170", "171", "172", "173", "174", "175", "176", "177", "178", "179", "180", "181", "182", "183", "184", "185", "186", "187", "188", "189", "190", "191", "192", "193", "194", "195", "196", "197", "198", "199", "200" });
            cmbUnitsOnOrder.Location = new Point(249, 25);
            cmbUnitsOnOrder.Name = "cmbUnitsOnOrder";
            cmbUnitsOnOrder.Size = new Size(121, 23);
            cmbUnitsOnOrder.TabIndex = 33;
            // 
            // cmbReorderLevel
            // 
            cmbReorderLevel.FormattingEnabled = true;
            cmbReorderLevel.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59", "60", "61", "62", "63", "64", "65", "66", "67", "68", "69", "70", "71", "72", "73", "74", "75", "76", "77", "78", "79", "80", "81", "82", "83", "84", "85", "86", "87", "88", "89", "90", "91", "92", "93", "94", "95", "96", "97", "98", "99", "100" });
            cmbReorderLevel.Location = new Point(249, 70);
            cmbReorderLevel.Name = "cmbReorderLevel";
            cmbReorderLevel.Size = new Size(121, 23);
            cmbReorderLevel.TabIndex = 34;
            // 
            // dudDiscontinued
            // 
            dudDiscontinued.Items.Add("0");
            dudDiscontinued.Items.Add("1");
            dudDiscontinued.Items.Add("2");
            dudDiscontinued.Items.Add("3");
            dudDiscontinued.Items.Add("4");
            dudDiscontinued.Items.Add("5");
            dudDiscontinued.Items.Add("6");
            dudDiscontinued.Items.Add("7");
            dudDiscontinued.Items.Add("8");
            dudDiscontinued.Items.Add("9");
            dudDiscontinued.Items.Add("10");
            dudDiscontinued.Location = new Point(250, 123);
            dudDiscontinued.Name = "dudDiscontinued";
            dudDiscontinued.Size = new Size(120, 23);
            dudDiscontinued.TabIndex = 36;
            // 
            // frmProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "frmProductos";
            Text = "frmProductos";
            tabControl1.ResumeLayout(false);
            tpAlta.ResumeLayout(false);
            tpAlta.PerformLayout();
            tpMostrar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tpAlta;
        private TabPage tpMostrar;
        private Label label7;
        private Label label5;
        private Label label6;
        private Label label3;
        private Label label4;
        private Label label2;
        private Label label1;
        private DataGridView dataGridView1;
        private ComboBox cmbProductName;
        private TextBox txtQuantityPerUnit;
        private TextBox txtUnitInStock;
        private TextBox txtUnitPrice;
        private ComboBox cmbUnitsInStock;
        private ComboBox cmbUnitsOnOrder;
        private ComboBox cmbReorderLevel;
        private DomainUpDown dudDiscontinued;
    }
}