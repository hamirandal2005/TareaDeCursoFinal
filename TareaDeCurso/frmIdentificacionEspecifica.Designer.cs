namespace pjContabilidadMetodosValuacion
{
    partial class frmIdentificacionEspecifica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIdentificacionEspecifica));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnRegistrarCompras = new System.Windows.Forms.Button();
            this.DTPEntrada = new System.Windows.Forms.DateTimePicker();
            this.txtCostoUnitario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUnidadesCompradas = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DTP = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCostoUnitarioSalida = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnRegistrarSalidas = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.DTPSalida = new System.Windows.Forms.DateTimePicker();
            this.txtUnidadesUsadas = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DTPTransaccion = new System.Windows.Forms.GroupBox();
            this.lvDatosIngresados = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lvDatosSalidas = new System.Windows.Forms.ListView();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader9 = new System.Windows.Forms.ColumnHeader();
            this.btnFinalizarPeriodo = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.DTPTransaccion.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnRegistrarCompras);
            this.groupBox1.Controls.Add(this.DTPEntrada);
            this.groupBox1.Controls.Add(this.txtCostoUnitario);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtUnidadesCompradas);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Sitka Banner", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(256, 125);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(1015, 93);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Compras";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(4, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 22);
            this.label6.TabIndex = 11;
            this.label6.Text = "Fecha :";
            // 
            // btnRegistrarCompras
            // 
            this.btnRegistrarCompras.Font = new System.Drawing.Font("Mongolian Baiti", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRegistrarCompras.ForeColor = System.Drawing.Color.Black;
            this.btnRegistrarCompras.Location = new System.Drawing.Point(821, 35);
            this.btnRegistrarCompras.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRegistrarCompras.Name = "btnRegistrarCompras";
            this.btnRegistrarCompras.Size = new System.Drawing.Size(101, 35);
            this.btnRegistrarCompras.TabIndex = 10;
            this.btnRegistrarCompras.Text = "Registrar";
            this.btnRegistrarCompras.UseVisualStyleBackColor = true;
            this.btnRegistrarCompras.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // DTPEntrada
            // 
            this.DTPEntrada.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DTPEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPEntrada.Location = new System.Drawing.Point(80, 35);
            this.DTPEntrada.Name = "DTPEntrada";
            this.DTPEntrada.Size = new System.Drawing.Size(122, 30);
            this.DTPEntrada.TabIndex = 8;
            this.DTPEntrada.Value = new System.DateTime(2022, 10, 10, 0, 0, 0, 0);
            // 
            // txtCostoUnitario
            // 
            this.txtCostoUnitario.Location = new System.Drawing.Point(668, 41);
            this.txtCostoUnitario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCostoUnitario.Name = "txtCostoUnitario";
            this.txtCostoUnitario.Size = new System.Drawing.Size(114, 29);
            this.txtCostoUnitario.TabIndex = 5;
            this.txtCostoUnitario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCostoUnitario_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(528, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Costo Unitario :";
            // 
            // txtUnidadesCompradas
            // 
            this.txtUnidadesCompradas.Location = new System.Drawing.Point(408, 35);
            this.txtUnidadesCompradas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUnidadesCompradas.Name = "txtUnidadesCompradas";
            this.txtUnidadesCompradas.Size = new System.Drawing.Size(114, 29);
            this.txtUnidadesCompradas.TabIndex = 1;
            this.txtUnidadesCompradas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUnidadesCompradas_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(216, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Unidades Compradas :";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.DTP);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtCostoUnitarioSalida);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.btnRegistrarSalidas);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.DTPSalida);
            this.groupBox2.Controls.Add(this.txtUnidadesUsadas);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Sitka Banner", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(124, 234);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1173, 93);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos Salidas";
            // 
            // DTP
            // 
            this.DTP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTP.Location = new System.Drawing.Point(80, 40);
            this.DTP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DTP.Name = "DTP";
            this.DTP.Size = new System.Drawing.Size(122, 30);
            this.DTP.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(505, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(150, 22);
            this.label9.TabIndex = 18;
            this.label9.Text = "Fecha de Salida :";
            // 
            // txtCostoUnitarioSalida
            // 
            this.txtCostoUnitarioSalida.Location = new System.Drawing.Point(923, 44);
            this.txtCostoUnitarioSalida.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCostoUnitarioSalida.Name = "txtCostoUnitarioSalida";
            this.txtCostoUnitarioSalida.Size = new System.Drawing.Size(115, 29);
            this.txtCostoUnitarioSalida.TabIndex = 19;
            this.txtCostoUnitarioSalida.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCostoUnitarioSalida_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(786, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 24);
            this.label8.TabIndex = 18;
            this.label8.Text = "CostoUnitario :";
            // 
            // btnRegistrarSalidas
            // 
            this.btnRegistrarSalidas.Font = new System.Drawing.Font("Mongolian Baiti", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRegistrarSalidas.ForeColor = System.Drawing.Color.Black;
            this.btnRegistrarSalidas.Location = new System.Drawing.Point(1065, 37);
            this.btnRegistrarSalidas.Name = "btnRegistrarSalidas";
            this.btnRegistrarSalidas.Size = new System.Drawing.Size(101, 35);
            this.btnRegistrarSalidas.TabIndex = 14;
            this.btnRegistrarSalidas.Text = "Registrar";
            this.btnRegistrarSalidas.UseVisualStyleBackColor = true;
            this.btnRegistrarSalidas.Click += new System.EventHandler(this.btnRegistrarSalidas_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(8, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 22);
            this.label7.TabIndex = 13;
            this.label7.Text = "Fecha :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DTPSalida
            // 
            this.DTPSalida.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DTPSalida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPSalida.Location = new System.Drawing.Point(658, 44);
            this.DTPSalida.Name = "DTPSalida";
            this.DTPSalida.Size = new System.Drawing.Size(122, 30);
            this.DTPSalida.TabIndex = 12;
            this.DTPSalida.Value = new System.DateTime(2022, 10, 10, 0, 0, 0, 0);
            // 
            // txtUnidadesUsadas
            // 
            this.txtUnidadesUsadas.Location = new System.Drawing.Point(384, 44);
            this.txtUnidadesUsadas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUnidadesUsadas.Name = "txtUnidadesUsadas";
            this.txtUnidadesUsadas.Size = new System.Drawing.Size(115, 29);
            this.txtUnidadesUsadas.TabIndex = 8;
            this.txtUnidadesUsadas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUnidadesUsadas_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(216, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Unidades Usadas :";
            // 
            // DTPTransaccion
            // 
            this.DTPTransaccion.BackColor = System.Drawing.Color.Transparent;
            this.DTPTransaccion.Controls.Add(this.lvDatosIngresados);
            this.DTPTransaccion.Controls.Add(this.groupBox6);
            this.DTPTransaccion.Font = new System.Drawing.Font("Sitka Banner", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DTPTransaccion.ForeColor = System.Drawing.Color.White;
            this.DTPTransaccion.Location = new System.Drawing.Point(28, 324);
            this.DTPTransaccion.Name = "DTPTransaccion";
            this.DTPTransaccion.Size = new System.Drawing.Size(666, 273);
            this.DTPTransaccion.TabIndex = 14;
            this.DTPTransaccion.TabStop = false;
            this.DTPTransaccion.Text = "Datos Ingresados";
            // 
            // lvDatosIngresados
            // 
            this.lvDatosIngresados.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvDatosIngresados.Font = new System.Drawing.Font("Sitka Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lvDatosIngresados.GridLines = true;
            this.lvDatosIngresados.Location = new System.Drawing.Point(39, 31);
            this.lvDatosIngresados.Name = "lvDatosIngresados";
            this.lvDatosIngresados.Size = new System.Drawing.Size(562, 211);
            this.lvDatosIngresados.TabIndex = 0;
            this.lvDatosIngresados.UseCompatibleStateImageBehavior = false;
            this.lvDatosIngresados.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Fecha";
            this.columnHeader1.Width = 110;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Unidades Compradas";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 220;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "C/U";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 75;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Costo Total";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 120;
            // 
            // groupBox6
            // 
            this.groupBox6.Location = new System.Drawing.Point(0, 0);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(200, 100);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.lvDatosSalidas);
            this.groupBox4.Font = new System.Drawing.Font("Sitka Banner", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(720, 324);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(714, 273);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Datos Salidas";
            // 
            // lvDatosSalidas
            // 
            this.lvDatosSalidas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader5,
            this.columnHeader8,
            this.columnHeader9});
            this.lvDatosSalidas.Font = new System.Drawing.Font("Sitka Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lvDatosSalidas.GridLines = true;
            this.lvDatosSalidas.Location = new System.Drawing.Point(7, 29);
            this.lvDatosSalidas.Name = "lvDatosSalidas";
            this.lvDatosSalidas.Size = new System.Drawing.Size(671, 213);
            this.lvDatosSalidas.TabIndex = 2;
            this.lvDatosSalidas.UseCompatibleStateImageBehavior = false;
            this.lvDatosSalidas.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Fecha";
            this.columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Unidades Usadas";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader7.Width = 180;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Fecha Salida";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 130;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "C/U";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader8.Width = 100;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Costo Total";
            this.columnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader9.Width = 120;
            // 
            // btnFinalizarPeriodo
            // 
            this.btnFinalizarPeriodo.Font = new System.Drawing.Font("Mongolian Baiti", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFinalizarPeriodo.Location = new System.Drawing.Point(28, 642);
            this.btnFinalizarPeriodo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFinalizarPeriodo.Name = "btnFinalizarPeriodo";
            this.btnFinalizarPeriodo.Size = new System.Drawing.Size(162, 33);
            this.btnFinalizarPeriodo.TabIndex = 0;
            this.btnFinalizarPeriodo.Text = "Finalizar Período";
            this.btnFinalizarPeriodo.UseVisualStyleBackColor = true;
            this.btnFinalizarPeriodo.Click += new System.EventHandler(this.btnFinalizarPeriodo_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(90)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(629, 50);
            this.panel1.TabIndex = 27;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::pjContabilidadMetodosValuacion.Properties.Resources.Captura_de_pantalla__23_;
            this.pictureBox1.Location = new System.Drawing.Point(84, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(457, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(33)))), ((int)(((byte)(225)))));
            this.panel7.Location = new System.Drawing.Point(0, 67);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(250, 5);
            this.panel7.TabIndex = 32;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(33)))), ((int)(((byte)(225)))));
            this.panel6.Location = new System.Drawing.Point(0, 56);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(310, 5);
            this.panel6.TabIndex = 31;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(45)))), ((int)(((byte)(44)))));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(468, 56);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(540, 62);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 33;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(260, 610);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(978, 119);
            this.groupBox3.TabIndex = 34;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Resultados";
            // 
            // frmIdentificacionEspecifica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1508, 741);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnFinalizarPeriodo);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.DTPTransaccion);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmIdentificacionEspecifica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmIdentificacionEspecifica";
            this.Load += new System.EventHandler(this.frmIdentificacionEspecifica_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.DTPTransaccion.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private DateTimePicker DTPEntrada;
        private TextBox txtCostoUnitario;
        private Label label3;
        private TextBox txtUnidadesCompradas;
        private Label label1;
        private Button btnRegistrarCompras;
        private Label label6;
        private GroupBox groupBox2;
        private Button btnRegistrarSalidas;
        private Label label7;
        private DateTimePicker DTPSalida;
        private TextBox txtUnidadesUsadas;
        private Label label2;
        private GroupBox DTPTransaccion;
        private ListView lvDatosIngresados;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private GroupBox groupBox4;
        private ListView lvDatosSalidas;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private GroupBox groupBox6;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader8;
        private Button btnFinalizarPeriodo;
        private Label label8;
        private TextBox txtCostoUnitarioSalida;
        private DateTimePicker DTP;
        private Label label9;
        private ColumnHeader columnHeader9;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel7;
        private Panel panel6;
        private PictureBox pictureBox2;
        private GroupBox groupBox3;
    }
}