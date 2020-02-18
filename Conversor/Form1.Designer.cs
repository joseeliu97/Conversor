namespace Conversor
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Longitud = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblLongitud = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboLongitudA = new System.Windows.Forms.ComboBox();
            this.cboLongitudDE = new System.Windows.Forms.ComboBox();
            this.Peso = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.txtpeso = new System.Windows.Forms.TextBox();
            this.lblPeso = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cboPesoA = new System.Windows.Forms.ComboBox();
            this.cboPesoDe = new System.Windows.Forms.ComboBox();
            this.Volumen = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.txtVolumen = new System.Windows.Forms.TextBox();
            this.lblVolumen = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cboVolumenA = new System.Windows.Forms.ComboBox();
            this.cboVolumenDe = new System.Windows.Forms.ComboBox();
            this.Almacenamiento = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAlmacenamiento = new System.Windows.Forms.TextBox();
            this.lblAlmacenamiento = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cboAlmacenamientoA = new System.Windows.Forms.ComboBox();
            this.cboAlmacenamientoDe = new System.Windows.Forms.ComboBox();
            this.Divisas = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDivisas = new System.Windows.Forms.TextBox();
            this.lblDivisas = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.cboDivisasA = new System.Windows.Forms.ComboBox();
            this.cboDivisasDe = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.Longitud.SuspendLayout();
            this.Peso.SuspendLayout();
            this.Volumen.SuspendLayout();
            this.Almacenamiento.SuspendLayout();
            this.Divisas.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Longitud);
            this.tabControl1.Controls.Add(this.Peso);
            this.tabControl1.Controls.Add(this.Volumen);
            this.tabControl1.Controls.Add(this.Almacenamiento);
            this.tabControl1.Controls.Add(this.Divisas);
            this.tabControl1.Location = new System.Drawing.Point(-4, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(693, 372);
            this.tabControl1.TabIndex = 0;
            // 
            // Longitud
            // 
            this.Longitud.BackColor = System.Drawing.Color.White;
            this.Longitud.Controls.Add(this.label4);
            this.Longitud.Controls.Add(this.txtValor);
            this.Longitud.Controls.Add(this.lblLongitud);
            this.Longitud.Controls.Add(this.button1);
            this.Longitud.Controls.Add(this.label2);
            this.Longitud.Controls.Add(this.label1);
            this.Longitud.Controls.Add(this.cboLongitudA);
            this.Longitud.Controls.Add(this.cboLongitudDE);
            this.Longitud.Location = new System.Drawing.Point(4, 22);
            this.Longitud.Name = "Longitud";
            this.Longitud.Padding = new System.Windows.Forms.Padding(3);
            this.Longitud.Size = new System.Drawing.Size(685, 346);
            this.Longitud.TabIndex = 0;
            this.Longitud.Text = "Longitud";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label4.Location = new System.Drawing.Point(228, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(207, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ingrese valor a convertir:";
            // 
            // txtValor
            // 
            this.txtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.ForeColor = System.Drawing.Color.Teal;
            this.txtValor.Location = new System.Drawing.Point(185, 73);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(290, 22);
            this.txtValor.TabIndex = 6;
            this.txtValor.Text = "1";
            // 
            // lblLongitud
            // 
            this.lblLongitud.AutoSize = true;
            this.lblLongitud.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLongitud.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblLongitud.Location = new System.Drawing.Point(85, 261);
            this.lblLongitud.Name = "lblLongitud";
            this.lblLongitud.Size = new System.Drawing.Size(31, 29);
            this.lblLongitud.TabIndex = 5;
            this.lblLongitud.Text = "?:";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.button1.Location = new System.Drawing.Point(290, 178);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = "Convertir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(360, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "A:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(12, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "De:";
            // 
            // cboLongitudA
            // 
            this.cboLongitudA.AllowDrop = true;
            this.cboLongitudA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLongitudA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLongitudA.ForeColor = System.Drawing.Color.RoyalBlue;
            this.cboLongitudA.FormattingEnabled = true;
            this.cboLongitudA.Items.AddRange(new object[] {
            "Kilometro",
            "Metro",
            "Centimetro",
            "Milimetro",
            "Micrometro",
            "Nanometro",
            "Milla",
            "Yarda",
            "Pie",
            "Pulgada",
            "Varas"});
            this.cboLongitudA.Location = new System.Drawing.Point(364, 148);
            this.cboLongitudA.Name = "cboLongitudA";
            this.cboLongitudA.Size = new System.Drawing.Size(315, 24);
            this.cboLongitudA.TabIndex = 1;
            // 
            // cboLongitudDE
            // 
            this.cboLongitudDE.AllowDrop = true;
            this.cboLongitudDE.BackColor = System.Drawing.Color.White;
            this.cboLongitudDE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLongitudDE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLongitudDE.ForeColor = System.Drawing.Color.RoyalBlue;
            this.cboLongitudDE.FormattingEnabled = true;
            this.cboLongitudDE.Items.AddRange(new object[] {
            "Kilometro",
            "Metro",
            "Centimetro",
            "Milimetro",
            "Micrometro",
            "Nanometro",
            "Milla",
            "Yarda",
            "Pie",
            "Pulgada",
            "Varas"});
            this.cboLongitudDE.Location = new System.Drawing.Point(12, 148);
            this.cboLongitudDE.Name = "cboLongitudDE";
            this.cboLongitudDE.Size = new System.Drawing.Size(315, 24);
            this.cboLongitudDE.TabIndex = 0;
            // 
            // Peso
            // 
            this.Peso.Controls.Add(this.label5);
            this.Peso.Controls.Add(this.txtpeso);
            this.Peso.Controls.Add(this.lblPeso);
            this.Peso.Controls.Add(this.button2);
            this.Peso.Controls.Add(this.label7);
            this.Peso.Controls.Add(this.label8);
            this.Peso.Controls.Add(this.cboPesoA);
            this.Peso.Controls.Add(this.cboPesoDe);
            this.Peso.Location = new System.Drawing.Point(4, 22);
            this.Peso.Name = "Peso";
            this.Peso.Padding = new System.Windows.Forms.Padding(3);
            this.Peso.Size = new System.Drawing.Size(685, 346);
            this.Peso.TabIndex = 1;
            this.Peso.Text = "Peso";
            this.Peso.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(250, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(207, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Ingrese valor a convertir:";
            // 
            // txtpeso
            // 
            this.txtpeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpeso.ForeColor = System.Drawing.Color.Teal;
            this.txtpeso.Location = new System.Drawing.Point(210, 70);
            this.txtpeso.Name = "txtpeso";
            this.txtpeso.Size = new System.Drawing.Size(290, 22);
            this.txtpeso.TabIndex = 14;
            this.txtpeso.Text = "1";
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeso.ForeColor = System.Drawing.Color.Teal;
            this.lblPeso.Location = new System.Drawing.Point(74, 254);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(31, 29);
            this.lblPeso.TabIndex = 13;
            this.lblPeso.Text = "?:";
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Teal;
            this.button2.Location = new System.Drawing.Point(291, 167);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 29);
            this.button2.TabIndex = 12;
            this.button2.Text = "Convertir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Teal;
            this.label7.Location = new System.Drawing.Point(372, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "A:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Teal;
            this.label8.Location = new System.Drawing.Point(6, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "De:";
            // 
            // cboPesoA
            // 
            this.cboPesoA.AllowDrop = true;
            this.cboPesoA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPesoA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPesoA.ForeColor = System.Drawing.Color.RoyalBlue;
            this.cboPesoA.FormattingEnabled = true;
            this.cboPesoA.Items.AddRange(new object[] {
            "Tonelada",
            "Kilogramo",
            "Gramo ",
            "Miligramo",
            "Microgramo",
            "Tonelada Larga",
            "Tonelada Corta",
            "Stone",
            "Libra",
            "Onza"});
            this.cboPesoA.Location = new System.Drawing.Point(364, 137);
            this.cboPesoA.Name = "cboPesoA";
            this.cboPesoA.Size = new System.Drawing.Size(315, 24);
            this.cboPesoA.TabIndex = 9;
            // 
            // cboPesoDe
            // 
            this.cboPesoDe.AllowDrop = true;
            this.cboPesoDe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPesoDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPesoDe.ForeColor = System.Drawing.Color.RoyalBlue;
            this.cboPesoDe.FormattingEnabled = true;
            this.cboPesoDe.Items.AddRange(new object[] {
            "Tonelada",
            "Kilogramo",
            "Gramo ",
            "Miligramo",
            "Microgramo",
            "Tonelada Larga",
            "Tonelada Corta",
            "Stone",
            "Libra",
            "Onza"});
            this.cboPesoDe.Location = new System.Drawing.Point(6, 137);
            this.cboPesoDe.Name = "cboPesoDe";
            this.cboPesoDe.Size = new System.Drawing.Size(315, 24);
            this.cboPesoDe.TabIndex = 8;
            // 
            // Volumen
            // 
            this.Volumen.Controls.Add(this.label9);
            this.Volumen.Controls.Add(this.txtVolumen);
            this.Volumen.Controls.Add(this.lblVolumen);
            this.Volumen.Controls.Add(this.button3);
            this.Volumen.Controls.Add(this.label11);
            this.Volumen.Controls.Add(this.label12);
            this.Volumen.Controls.Add(this.cboVolumenA);
            this.Volumen.Controls.Add(this.cboVolumenDe);
            this.Volumen.Location = new System.Drawing.Point(4, 22);
            this.Volumen.Name = "Volumen";
            this.Volumen.Size = new System.Drawing.Size(685, 346);
            this.Volumen.TabIndex = 2;
            this.Volumen.Text = "Volumen";
            this.Volumen.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.MediumPurple;
            this.label9.Location = new System.Drawing.Point(245, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(207, 20);
            this.label9.TabIndex = 23;
            this.label9.Text = "Ingrese valor a convertir:";
            // 
            // txtVolumen
            // 
            this.txtVolumen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVolumen.ForeColor = System.Drawing.Color.Teal;
            this.txtVolumen.Location = new System.Drawing.Point(210, 83);
            this.txtVolumen.Name = "txtVolumen";
            this.txtVolumen.Size = new System.Drawing.Size(290, 22);
            this.txtVolumen.TabIndex = 22;
            this.txtVolumen.Text = "1";
            // 
            // lblVolumen
            // 
            this.lblVolumen.AutoSize = true;
            this.lblVolumen.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVolumen.ForeColor = System.Drawing.Color.MediumPurple;
            this.lblVolumen.Location = new System.Drawing.Point(95, 256);
            this.lblVolumen.Name = "lblVolumen";
            this.lblVolumen.Size = new System.Drawing.Size(31, 29);
            this.lblVolumen.TabIndex = 21;
            this.lblVolumen.Text = "?:";
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.MediumPurple;
            this.button3.Location = new System.Drawing.Point(293, 179);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 29);
            this.button3.TabIndex = 20;
            this.button3.Text = "Convertir";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.MediumPurple;
            this.label11.Location = new System.Drawing.Point(363, 126);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 20);
            this.label11.TabIndex = 19;
            this.label11.Text = "A:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.MediumPurple;
            this.label12.Location = new System.Drawing.Point(12, 126);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 20);
            this.label12.TabIndex = 18;
            this.label12.Text = "De:";
            // 
            // cboVolumenA
            // 
            this.cboVolumenA.AllowDrop = true;
            this.cboVolumenA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVolumenA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboVolumenA.ForeColor = System.Drawing.Color.RoyalBlue;
            this.cboVolumenA.FormattingEnabled = true;
            this.cboVolumenA.Items.AddRange(new object[] {
            "Litro",
            "Galon Estadounidense",
            "Cuarto Estadounidense ",
            "Pinta Estadounidense",
            "Taza Americana Oficial",
            "Onza Liquida Estadounidense ",
            "Cucharada Estadounidense ",
            "Cucharadita Estadounidense ",
            "Metro Cubico ",
            "Mililitro",
            "Galon Imperial ",
            "Cuarto Imperial ",
            "Pinta Imperial ",
            "Taza Imperial ",
            "Onza Liquida Imperial ",
            "Cuchara Imperial ",
            "Cucharadita Imperial ",
            "Pie Cubico ",
            "Pulgada Cubica"});
            this.cboVolumenA.Location = new System.Drawing.Point(357, 149);
            this.cboVolumenA.Name = "cboVolumenA";
            this.cboVolumenA.Size = new System.Drawing.Size(315, 24);
            this.cboVolumenA.TabIndex = 17;
            // 
            // cboVolumenDe
            // 
            this.cboVolumenDe.AllowDrop = true;
            this.cboVolumenDe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVolumenDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboVolumenDe.ForeColor = System.Drawing.Color.RoyalBlue;
            this.cboVolumenDe.FormattingEnabled = true;
            this.cboVolumenDe.Items.AddRange(new object[] {
            "Litro",
            "Galon Estadounidense",
            "Cuarto Estadounidense ",
            "Pinta Estadounidense",
            "Taza Americana Oficial",
            "Onza Liquida Estadounidense ",
            "Cucharada Estadounidense ",
            "Cucharadita Estadounidense ",
            "Metro Cubico ",
            "Mililitro",
            "Galon Imperial ",
            "Cuarto Imperial ",
            "Pinta Imperial ",
            "Taza Imperial ",
            "Onza Liquida Imperial ",
            "Cuchara Imperial ",
            "Cucharadita Imperial ",
            "Pie Cubico ",
            "Pulgada Cubica"});
            this.cboVolumenDe.Location = new System.Drawing.Point(12, 149);
            this.cboVolumenDe.Name = "cboVolumenDe";
            this.cboVolumenDe.Size = new System.Drawing.Size(315, 24);
            this.cboVolumenDe.TabIndex = 16;
            // 
            // Almacenamiento
            // 
            this.Almacenamiento.Controls.Add(this.label3);
            this.Almacenamiento.Controls.Add(this.txtAlmacenamiento);
            this.Almacenamiento.Controls.Add(this.lblAlmacenamiento);
            this.Almacenamiento.Controls.Add(this.button4);
            this.Almacenamiento.Controls.Add(this.label10);
            this.Almacenamiento.Controls.Add(this.label13);
            this.Almacenamiento.Controls.Add(this.cboAlmacenamientoA);
            this.Almacenamiento.Controls.Add(this.cboAlmacenamientoDe);
            this.Almacenamiento.Location = new System.Drawing.Point(4, 22);
            this.Almacenamiento.Name = "Almacenamiento";
            this.Almacenamiento.Size = new System.Drawing.Size(685, 346);
            this.Almacenamiento.TabIndex = 3;
            this.Almacenamiento.Text = "Almacenamiento";
            this.Almacenamiento.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.label3.Location = new System.Drawing.Point(244, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 20);
            this.label3.TabIndex = 31;
            this.label3.Text = "Ingrese valor a convertir:";
            // 
            // txtAlmacenamiento
            // 
            this.txtAlmacenamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAlmacenamiento.ForeColor = System.Drawing.Color.Teal;
            this.txtAlmacenamiento.Location = new System.Drawing.Point(213, 89);
            this.txtAlmacenamiento.Name = "txtAlmacenamiento";
            this.txtAlmacenamiento.Size = new System.Drawing.Size(290, 22);
            this.txtAlmacenamiento.TabIndex = 30;
            this.txtAlmacenamiento.Text = "1";
            // 
            // lblAlmacenamiento
            // 
            this.lblAlmacenamiento.AutoSize = true;
            this.lblAlmacenamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlmacenamiento.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.lblAlmacenamiento.Location = new System.Drawing.Point(91, 256);
            this.lblAlmacenamiento.Name = "lblAlmacenamiento";
            this.lblAlmacenamiento.Size = new System.Drawing.Size(31, 29);
            this.lblAlmacenamiento.TabIndex = 29;
            this.lblAlmacenamiento.Text = "?:";
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.button4.Location = new System.Drawing.Point(296, 187);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(96, 29);
            this.button4.TabIndex = 28;
            this.button4.Text = "Convertir";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.label10.Location = new System.Drawing.Point(366, 134);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 20);
            this.label10.TabIndex = 27;
            this.label10.Text = "A:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.label13.Location = new System.Drawing.Point(12, 134);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 20);
            this.label13.TabIndex = 26;
            this.label13.Text = "De:";
            // 
            // cboAlmacenamientoA
            // 
            this.cboAlmacenamientoA.AllowDrop = true;
            this.cboAlmacenamientoA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAlmacenamientoA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboAlmacenamientoA.ForeColor = System.Drawing.Color.RoyalBlue;
            this.cboAlmacenamientoA.FormattingEnabled = true;
            this.cboAlmacenamientoA.Items.AddRange(new object[] {
            "bit",
            "Kilobit",
            "Kibibit",
            "Megabit",
            "Mebibit",
            "Gigabit",
            "Gibibit",
            "Terabit",
            "Tebibit",
            "Petabit",
            "Pebibit",
            "Byte",
            "Kilobyte",
            "Kibibyte",
            "Megabyte",
            "Mebibyte",
            "GigaByte",
            "Gibibyte",
            "Terabyte",
            "Tebibyte",
            "Petabyte",
            "Petabibyte"});
            this.cboAlmacenamientoA.Location = new System.Drawing.Point(357, 157);
            this.cboAlmacenamientoA.Name = "cboAlmacenamientoA";
            this.cboAlmacenamientoA.Size = new System.Drawing.Size(315, 24);
            this.cboAlmacenamientoA.TabIndex = 25;
            // 
            // cboAlmacenamientoDe
            // 
            this.cboAlmacenamientoDe.AllowDrop = true;
            this.cboAlmacenamientoDe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAlmacenamientoDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboAlmacenamientoDe.ForeColor = System.Drawing.Color.RoyalBlue;
            this.cboAlmacenamientoDe.FormattingEnabled = true;
            this.cboAlmacenamientoDe.Items.AddRange(new object[] {
            "bit",
            "Kilobit",
            "Kibibit",
            "Megabit",
            "Mebibit",
            "Gigabit",
            "Gibibit",
            "Terabit",
            "Tebibit",
            "Petabit",
            "Pebibit",
            "Byte",
            "Kilobyte",
            "Kibibyte",
            "Megabyte",
            "Mebibyte",
            "GigaByte",
            "Gibibyte",
            "Terabyte",
            "Tebibyte",
            "Petabyte",
            "Petabibyte"});
            this.cboAlmacenamientoDe.Location = new System.Drawing.Point(12, 157);
            this.cboAlmacenamientoDe.Name = "cboAlmacenamientoDe";
            this.cboAlmacenamientoDe.Size = new System.Drawing.Size(315, 24);
            this.cboAlmacenamientoDe.TabIndex = 24;
            // 
            // Divisas
            // 
            this.Divisas.Controls.Add(this.label6);
            this.Divisas.Controls.Add(this.txtDivisas);
            this.Divisas.Controls.Add(this.lblDivisas);
            this.Divisas.Controls.Add(this.button5);
            this.Divisas.Controls.Add(this.label15);
            this.Divisas.Controls.Add(this.label16);
            this.Divisas.Controls.Add(this.cboDivisasA);
            this.Divisas.Controls.Add(this.cboDivisasDe);
            this.Divisas.Location = new System.Drawing.Point(4, 22);
            this.Divisas.Name = "Divisas";
            this.Divisas.Size = new System.Drawing.Size(685, 346);
            this.Divisas.TabIndex = 4;
            this.Divisas.Text = "Divisas";
            this.Divisas.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label6.Location = new System.Drawing.Point(229, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(207, 20);
            this.label6.TabIndex = 39;
            this.label6.Text = "Ingrese valor a convertir:";
            // 
            // txtDivisas
            // 
            this.txtDivisas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDivisas.ForeColor = System.Drawing.Color.Teal;
            this.txtDivisas.Location = new System.Drawing.Point(196, 91);
            this.txtDivisas.Name = "txtDivisas";
            this.txtDivisas.Size = new System.Drawing.Size(290, 22);
            this.txtDivisas.TabIndex = 38;
            this.txtDivisas.Text = "1";
            // 
            // lblDivisas
            // 
            this.lblDivisas.AutoSize = true;
            this.lblDivisas.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDivisas.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblDivisas.Location = new System.Drawing.Point(91, 256);
            this.lblDivisas.Name = "lblDivisas";
            this.lblDivisas.Size = new System.Drawing.Size(31, 29);
            this.lblDivisas.TabIndex = 37;
            this.lblDivisas.Text = "?:";
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.button5.Location = new System.Drawing.Point(288, 186);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(96, 29);
            this.button5.TabIndex = 36;
            this.button5.Text = "Convertir";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label15.Location = new System.Drawing.Point(358, 133);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(26, 20);
            this.label15.TabIndex = 35;
            this.label15.Text = "A:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label16.Location = new System.Drawing.Point(12, 135);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(37, 20);
            this.label16.TabIndex = 34;
            this.label16.Text = "De:";
            // 
            // cboDivisasA
            // 
            this.cboDivisasA.AllowDrop = true;
            this.cboDivisasA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDivisasA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDivisasA.ForeColor = System.Drawing.Color.RoyalBlue;
            this.cboDivisasA.FormattingEnabled = true;
            this.cboDivisasA.Items.AddRange(new object[] {
            "Dolar",
            "Balboa",
            "Bitcoin",
            "Bitcoin Cash",
            "Boliviano",
            "Colon Costarricense",
            "Colon Salvadoreño",
            "Cordoba",
            "Dirham (Emiratos arabes unidos)",
            "Dirham Marroqui",
            "Dolar Canadiense",
            "Dolar de Hong Kong",
            "Dolar de Singapur",
            "Dolar Jamaiquino",
            "Dolar Neozelandes",
            "Euro",
            "Franco Suizo ",
            "Guarani Paraguayo",
            "Lempira Hondureña",
            "Libra Egipcia",
            "Libra Esterlina",
            "Peso Argentino ",
            "peso Chileno ",
            "Peso Colombiano",
            "Peso Dominicano",
            "Peso Filipino",
            "Peso Mexicano",
            "Peso Uruguayo",
            "Quetzal",
            "Real Brasileño",
            "Rial",
            "Rubla Rusa",
            "Rupia India",
            "Yen Japones",
            "Bolivar Venezolano",
            "Peso Cubano",
            "Sol Peruano ",
            "Yuan Chino"});
            this.cboDivisasA.Location = new System.Drawing.Point(357, 156);
            this.cboDivisasA.Name = "cboDivisasA";
            this.cboDivisasA.Size = new System.Drawing.Size(315, 24);
            this.cboDivisasA.TabIndex = 33;
            // 
            // cboDivisasDe
            // 
            this.cboDivisasDe.AllowDrop = true;
            this.cboDivisasDe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDivisasDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDivisasDe.ForeColor = System.Drawing.Color.RoyalBlue;
            this.cboDivisasDe.FormattingEnabled = true;
            this.cboDivisasDe.Items.AddRange(new object[] {
            "Dolar",
            "Balboa",
            "Bitcoin",
            "Bitcoin Cash",
            "Boliviano",
            "Colon Costarricense",
            "Colon Salvadoreño",
            "Cordoba",
            "Dirham (Emiratos arabes unidos)",
            "Dirham Marroqui",
            "Dolar Canadiense",
            "Dolar de Hong Kong",
            "Dolar de Singapur",
            "Dolar Jamaiquino",
            "Dolar Neozelandes",
            "Euro",
            "Franco Suizo ",
            "Guarani Paraguayo",
            "Lempira Hondureña",
            "Libra Egipcia",
            "Libra Esterlina",
            "Peso Argentino ",
            "peso Chileno ",
            "Peso Colombiano",
            "Peso Dominicano",
            "Peso Filipino",
            "Peso Mexicano",
            "Peso Uruguayo",
            "Quetzal",
            "Real Brasileño",
            "Rial",
            "Rubla Rusa",
            "Rupia India",
            "Yen Japones",
            "Bolivar Venezolano",
            "Peso Cubano",
            "Sol Peruano ",
            "Yuan Chino"});
            this.cboDivisasDe.Location = new System.Drawing.Point(12, 156);
            this.cboDivisasDe.Name = "cboDivisasDe";
            this.cboDivisasDe.Size = new System.Drawing.Size(315, 24);
            this.cboDivisasDe.TabIndex = 32;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(684, 386);
            this.Controls.Add(this.tabControl1);
            this.MaximumSize = new System.Drawing.Size(700, 425);
            this.MinimumSize = new System.Drawing.Size(700, 425);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.Longitud.ResumeLayout(false);
            this.Longitud.PerformLayout();
            this.Peso.ResumeLayout(false);
            this.Peso.PerformLayout();
            this.Volumen.ResumeLayout(false);
            this.Volumen.PerformLayout();
            this.Almacenamiento.ResumeLayout(false);
            this.Almacenamiento.PerformLayout();
            this.Divisas.ResumeLayout(false);
            this.Divisas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Longitud;
        private System.Windows.Forms.TabPage Peso;
        private System.Windows.Forms.ComboBox cboLongitudDE;
        private System.Windows.Forms.ComboBox cboLongitudA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblLongitud;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtpeso;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboPesoA;
        private System.Windows.Forms.ComboBox cboPesoDe;
        private System.Windows.Forms.TabPage Volumen;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtVolumen;
        private System.Windows.Forms.Label lblVolumen;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cboVolumenA;
        private System.Windows.Forms.ComboBox cboVolumenDe;
        private System.Windows.Forms.TabPage Almacenamiento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAlmacenamiento;
        private System.Windows.Forms.Label lblAlmacenamiento;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cboAlmacenamientoA;
        private System.Windows.Forms.ComboBox cboAlmacenamientoDe;
        private System.Windows.Forms.TabPage Divisas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDivisas;
        private System.Windows.Forms.Label lblDivisas;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cboDivisasA;
        private System.Windows.Forms.ComboBox cboDivisasDe;
    }
}

