namespace pjContabilidadMetodosValuacion
{
    partial class frmPEPS
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
            this.btnRegistrarCompras = new System.Windows.Forms.Button();
            this.dtFechaCompras = new System.Windows.Forms.DateTimePicker();
            this.txtUnidades = new System.Windows.Forms.TextBox();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.btnRegistrarUtilizados = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gbCompras = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.lvUnidadesCompradas = new System.Windows.Forms.ListView();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.gbSalidas = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUnidadesUtilizadas = new System.Windows.Forms.TextBox();
            this.dtFechaUtilizadas = new System.Windows.Forms.DateTimePicker();
            this.gbDatosIngresados = new System.Windows.Forms.GroupBox();
            this.lvUnidadesUtilizadas = new System.Windows.Forms.ListView();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.gbTotales = new System.Windows.Forms.GroupBox();
            this.lblUnidadesCompradas = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblCostoPeriodo = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblMatUtilizados = new System.Windows.Forms.Label();
            this.lblInvFinal = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.pTotales = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gbCompras.SuspendLayout();
            this.gbSalidas.SuspendLayout();
            this.gbDatosIngresados.SuspendLayout();
            this.gbTotales.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pTotales.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRegistrarCompras
            // 
            this.btnRegistrarCompras.AutoSize = true;
            this.btnRegistrarCompras.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRegistrarCompras.ForeColor = System.Drawing.Color.Black;
            this.btnRegistrarCompras.Location = new System.Drawing.Point(217, 219);
            this.btnRegistrarCompras.Name = "btnRegistrarCompras";
            this.btnRegistrarCompras.Size = new System.Drawing.Size(95, 30);
            this.btnRegistrarCompras.TabIndex = 0;
            this.btnRegistrarCompras.Text = "Registrar";
            this.btnRegistrarCompras.UseVisualStyleBackColor = true;
            this.btnRegistrarCompras.Click += new System.EventHandler(this.btnRegistrarCompras_Click);
            // 
            // dtFechaCompras
            // 
            this.dtFechaCompras.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dtFechaCompras.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaCompras.Location = new System.Drawing.Point(75, 40);
            this.dtFechaCompras.Name = "dtFechaCompras";
            this.dtFechaCompras.Size = new System.Drawing.Size(121, 23);
            this.dtFechaCompras.TabIndex = 1;
            // 
            // txtUnidades
            // 
            this.txtUnidades.Location = new System.Drawing.Point(183, 87);
            this.txtUnidades.Name = "txtUnidades";
            this.txtUnidades.Size = new System.Drawing.Size(100, 26);
            this.txtUnidades.TabIndex = 2;
            // 
            // txtCosto
            // 
            this.txtCosto.Location = new System.Drawing.Point(60, 138);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(100, 26);
            this.txtCosto.TabIndex = 3;
            // 
            // btnRegistrarUtilizados
            // 
            this.btnRegistrarUtilizados.AutoSize = true;
            this.btnRegistrarUtilizados.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRegistrarUtilizados.ForeColor = System.Drawing.Color.Black;
            this.btnRegistrarUtilizados.Location = new System.Drawing.Point(518, 219);
            this.btnRegistrarUtilizados.Name = "btnRegistrarUtilizados";
            this.btnRegistrarUtilizados.Size = new System.Drawing.Size(95, 30);
            this.btnRegistrarUtilizados.TabIndex = 4;
            this.btnRegistrarUtilizados.Text = "Registrar";
            this.btnRegistrarUtilizados.UseVisualStyleBackColor = true;
            this.btnRegistrarUtilizados.Click += new System.EventHandler(this.btnRegistrarUtilizadas_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(9, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Unidades Compradas : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(9, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "C/U :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Candara", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(45, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 42);
            this.label3.TabIndex = 8;
            this.label3.Text = "Sistema V";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Candara", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Tomato;
            this.label4.Location = new System.Drawing.Point(-8, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 42);
            this.label4.TabIndex = 9;
            this.label4.Text = "aluacion";
            // 
            // gbCompras
            // 
            this.gbCompras.BackColor = System.Drawing.Color.Transparent;
            this.gbCompras.Controls.Add(this.label5);
            this.gbCompras.Controls.Add(this.label1);
            this.gbCompras.Controls.Add(this.txtUnidades);
            this.gbCompras.Controls.Add(this.dtFechaCompras);
            this.gbCompras.Controls.Add(this.label2);
            this.gbCompras.Controls.Add(this.txtCosto);
            this.gbCompras.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbCompras.ForeColor = System.Drawing.Color.White;
            this.gbCompras.Location = new System.Drawing.Point(77, 93);
            this.gbCompras.Name = "gbCompras";
            this.gbCompras.Size = new System.Drawing.Size(312, 235);
            this.gbCompras.TabIndex = 11;
            this.gbCompras.TabStop = false;
            this.gbCompras.Text = "Datos Compras";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(9, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Fecha :";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Fecha";
            this.columnHeader1.Width = 80;
            // 
            // lvUnidadesCompradas
            // 
            this.lvUnidadesCompradas.BackColor = System.Drawing.Color.White;
            this.lvUnidadesCompradas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvUnidadesCompradas.Font = new System.Drawing.Font("Candara", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lvUnidadesCompradas.GridLines = true;
            this.lvUnidadesCompradas.Location = new System.Drawing.Point(22, 35);
            this.lvUnidadesCompradas.Name = "lvUnidadesCompradas";
            this.lvUnidadesCompradas.Size = new System.Drawing.Size(290, 178);
            this.lvUnidadesCompradas.TabIndex = 7;
            this.lvUnidadesCompradas.UseCompatibleStateImageBehavior = false;
            this.lvUnidadesCompradas.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Unidades Compradas";
            this.columnHeader2.Width = 140;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "C/U";
            // 
            // gbSalidas
            // 
            this.gbSalidas.BackColor = System.Drawing.Color.Transparent;
            this.gbSalidas.Controls.Add(this.label6);
            this.gbSalidas.Controls.Add(this.label7);
            this.gbSalidas.Controls.Add(this.txtUnidadesUtilizadas);
            this.gbSalidas.Controls.Add(this.dtFechaUtilizadas);
            this.gbSalidas.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbSalidas.ForeColor = System.Drawing.Color.White;
            this.gbSalidas.Location = new System.Drawing.Point(413, 93);
            this.gbSalidas.Name = "gbSalidas";
            this.gbSalidas.Size = new System.Drawing.Size(312, 235);
            this.gbSalidas.TabIndex = 12;
            this.gbSalidas.TabStop = false;
            this.gbSalidas.Text = "Datos Salidas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(9, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Fecha :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(9, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 18);
            this.label7.TabIndex = 9;
            this.label7.Text = "Unidades Utilizadas : ";
            // 
            // txtUnidadesUtilizadas
            // 
            this.txtUnidadesUtilizadas.Location = new System.Drawing.Point(183, 98);
            this.txtUnidadesUtilizadas.Name = "txtUnidadesUtilizadas";
            this.txtUnidadesUtilizadas.Size = new System.Drawing.Size(100, 26);
            this.txtUnidadesUtilizadas.TabIndex = 8;
            // 
            // dtFechaUtilizadas
            // 
            this.dtFechaUtilizadas.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dtFechaUtilizadas.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaUtilizadas.Location = new System.Drawing.Point(75, 33);
            this.dtFechaUtilizadas.Name = "dtFechaUtilizadas";
            this.dtFechaUtilizadas.Size = new System.Drawing.Size(121, 23);
            this.dtFechaUtilizadas.TabIndex = 7;
            // 
            // gbDatosIngresados
            // 
            this.gbDatosIngresados.BackColor = System.Drawing.Color.Transparent;
            this.gbDatosIngresados.Controls.Add(this.lvUnidadesCompradas);
            this.gbDatosIngresados.Controls.Add(this.lvUnidadesUtilizadas);
            this.gbDatosIngresados.Controls.Add(this.btnRegistrarCompras);
            this.gbDatosIngresados.Controls.Add(this.btnRegistrarUtilizados);
            this.gbDatosIngresados.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbDatosIngresados.ForeColor = System.Drawing.Color.White;
            this.gbDatosIngresados.Location = new System.Drawing.Point(77, 348);
            this.gbDatosIngresados.Name = "gbDatosIngresados";
            this.gbDatosIngresados.Size = new System.Drawing.Size(648, 272);
            this.gbDatosIngresados.TabIndex = 13;
            this.gbDatosIngresados.TabStop = false;
            this.gbDatosIngresados.Text = "Datos Ingresados";
            // 
            // lvUnidadesUtilizadas
            // 
            this.lvUnidadesUtilizadas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvUnidadesUtilizadas.Font = new System.Drawing.Font("Candara", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lvUnidadesUtilizadas.GridLines = true;
            this.lvUnidadesUtilizadas.Location = new System.Drawing.Point(336, 35);
            this.lvUnidadesUtilizadas.Name = "lvUnidadesUtilizadas";
            this.lvUnidadesUtilizadas.Size = new System.Drawing.Size(277, 178);
            this.lvUnidadesUtilizadas.TabIndex = 8;
            this.lvUnidadesUtilizadas.UseCompatibleStateImageBehavior = false;
            this.lvUnidadesUtilizadas.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Fecha";
            this.columnHeader4.Width = 80;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Unidades Utilizadas";
            this.columnHeader5.Width = 120;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "C/U";
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.AutoSize = true;
            this.btnFinalizar.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFinalizar.Location = new System.Drawing.Point(951, 567);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(150, 30);
            this.btnFinalizar.TabIndex = 15;
            this.btnFinalizar.Text = "Finalizar periodo";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(6, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(154, 19);
            this.label8.TabIndex = 16;
            this.label8.Text = "Materiales Utilizados";
            // 
            // gbTotales
            // 
            this.gbTotales.BackColor = System.Drawing.Color.Transparent;
            this.gbTotales.Controls.Add(this.lblUnidadesCompradas);
            this.gbTotales.Controls.Add(this.label12);
            this.gbTotales.Controls.Add(this.lblCostoPeriodo);
            this.gbTotales.Controls.Add(this.label10);
            this.gbTotales.Controls.Add(this.lblMatUtilizados);
            this.gbTotales.Controls.Add(this.lblInvFinal);
            this.gbTotales.Controls.Add(this.label8);
            this.gbTotales.Controls.Add(this.label9);
            this.gbTotales.Font = new System.Drawing.Font("Candara", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbTotales.ForeColor = System.Drawing.Color.White;
            this.gbTotales.Location = new System.Drawing.Point(17, 41);
            this.gbTotales.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbTotales.Name = "gbTotales";
            this.gbTotales.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbTotales.Size = new System.Drawing.Size(288, 405);
            this.gbTotales.TabIndex = 17;
            this.gbTotales.TabStop = false;
            this.gbTotales.Text = "Valores Totalizados";
            this.gbTotales.Visible = false;
            // 
            // lblUnidadesCompradas
            // 
            this.lblUnidadesCompradas.AutoSize = true;
            this.lblUnidadesCompradas.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUnidadesCompradas.Location = new System.Drawing.Point(217, 227);
            this.lblUnidadesCompradas.Name = "lblUnidadesCompradas";
            this.lblUnidadesCompradas.Size = new System.Drawing.Size(55, 19);
            this.lblUnidadesCompradas.TabIndex = 21;
            this.lblUnidadesCompradas.Text = "label13";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(10, 227);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(192, 19);
            this.label12.TabIndex = 20;
            this.label12.Text = "Total Unidades Compradas";
            // 
            // lblCostoPeriodo
            // 
            this.lblCostoPeriodo.AutoSize = true;
            this.lblCostoPeriodo.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCostoPeriodo.Location = new System.Drawing.Point(220, 156);
            this.lblCostoPeriodo.Name = "lblCostoPeriodo";
            this.lblCostoPeriodo.Size = new System.Drawing.Size(52, 19);
            this.lblCostoPeriodo.TabIndex = 19;
            this.lblCostoPeriodo.Text = "label11";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(6, 156);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 19);
            this.label10.TabIndex = 18;
            this.label10.Text = "Costo del periodo";
            // 
            // lblMatUtilizados
            // 
            this.lblMatUtilizados.AutoSize = true;
            this.lblMatUtilizados.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMatUtilizados.Location = new System.Drawing.Point(220, 104);
            this.lblMatUtilizados.Name = "lblMatUtilizados";
            this.lblMatUtilizados.Size = new System.Drawing.Size(52, 19);
            this.lblMatUtilizados.TabIndex = 17;
            this.lblMatUtilizados.Text = "label11";
            // 
            // lblInvFinal
            // 
            this.lblInvFinal.AutoSize = true;
            this.lblInvFinal.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblInvFinal.Location = new System.Drawing.Point(216, 46);
            this.lblInvFinal.Name = "lblInvFinal";
            this.lblInvFinal.Size = new System.Drawing.Size(56, 19);
            this.lblInvFinal.TabIndex = 1;
            this.lblInvFinal.Text = "label10";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(6, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 19);
            this.label9.TabIndex = 0;
            this.label9.Text = "Inventario Final";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tomato;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(98, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 50);
            this.panel1.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(298, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 50);
            this.panel2.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Candara", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(12, 41);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 23);
            this.label11.TabIndex = 9;
            this.label11.Text = "PEPS";
            // 
            // pTotales
            // 
            this.pTotales.BackColor = System.Drawing.Color.Tomato;
            this.pTotales.Controls.Add(this.gbTotales);
            this.pTotales.Location = new System.Drawing.Point(744, 93);
            this.pTotales.Name = "pTotales";
            this.pTotales.Size = new System.Drawing.Size(333, 495);
            this.pTotales.TabIndex = 20;
            this.pTotales.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Tomato;
            this.panel3.Location = new System.Drawing.Point(396, 99);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 520);
            this.panel3.TabIndex = 21;
            // 
            // frmPEPS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::pjContabilidadMetodosValuacion.Properties.Resources.FondoFranjaRoja;
            this.ClientSize = new System.Drawing.Size(1119, 658);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.pTotales);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.gbDatosIngresados);
            this.Controls.Add(this.gbSalidas);
            this.Controls.Add(this.gbCompras);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmPEPS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PEPS";
            this.gbCompras.ResumeLayout(false);
            this.gbCompras.PerformLayout();
            this.gbSalidas.ResumeLayout(false);
            this.gbSalidas.PerformLayout();
            this.gbDatosIngresados.ResumeLayout(false);
            this.gbDatosIngresados.PerformLayout();
            this.gbTotales.ResumeLayout(false);
            this.gbTotales.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pTotales.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnRegistrarCompras;
        private DateTimePicker dtFechaCompras;
        private TextBox txtUnidades;
        private TextBox txtCosto;
        private Button btnRegistrarUtilizados;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private GroupBox gbCompras;
        private Label label5;
        private ColumnHeader columnHeader1;
        private ListView lvUnidadesCompradas;
        private GroupBox gbSalidas;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Label label6;
        private Label label7;
        private TextBox txtUnidadesUtilizadas;
        private DateTimePicker dtFechaUtilizadas;
        private GroupBox gbDatosIngresados;
        private ListView lvUnidadesUtilizadas;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private Button btnFinalizar;
        private Label label8;
        private GroupBox gbTotales;
        private Label label9;
        private Label lblMatUtilizados;
        private Label lblInvFinal;
        private Label lblUnidadesCompradas;
        private Label label12;
        private Label lblCostoPeriodo;
        private Label label10;
        private Panel panel1;
        private Panel panel2;
        private Label label11;
        private Panel pTotales;
        private Panel panel3;
    }
}