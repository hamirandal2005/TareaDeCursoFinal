﻿namespace pjContabilidadMetodosValuacion
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnRegistrarCompras = new System.Windows.Forms.Button();
            this.DTPEntrada = new System.Windows.Forms.DateTimePicker();
            this.txtCostoUnitario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUnidadesCompradas = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRegistrarSalidas = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.DTPSalida = new System.Windows.Forms.DateTimePicker();
            this.txtUnidadesUsadas = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lvDatosIngresados = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
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
            this.groupBox1.Location = new System.Drawing.Point(24, 107);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(888, 70);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Compras";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(5, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "Fecha :";
            // 
            // btnRegistrarCompras
            // 
            this.btnRegistrarCompras.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRegistrarCompras.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRegistrarCompras.Location = new System.Drawing.Point(718, 26);
            this.btnRegistrarCompras.Name = "btnRegistrarCompras";
            this.btnRegistrarCompras.Size = new System.Drawing.Size(88, 26);
            this.btnRegistrarCompras.TabIndex = 10;
            this.btnRegistrarCompras.Text = "Registrar";
            this.btnRegistrarCompras.UseVisualStyleBackColor = true;
            this.btnRegistrarCompras.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // DTPEntrada
            // 
            this.DTPEntrada.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DTPEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPEntrada.Location = new System.Drawing.Point(70, 26);
            this.DTPEntrada.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DTPEntrada.Name = "DTPEntrada";
            this.DTPEntrada.Size = new System.Drawing.Size(107, 26);
            this.DTPEntrada.TabIndex = 8;
            this.DTPEntrada.Value = new System.DateTime(2022, 10, 10, 0, 0, 0, 0);
            // 
            // txtCostoUnitario
            // 
            this.txtCostoUnitario.Location = new System.Drawing.Point(576, 32);
            this.txtCostoUnitario.Name = "txtCostoUnitario";
            this.txtCostoUnitario.Size = new System.Drawing.Size(100, 25);
            this.txtCostoUnitario.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(462, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Costo Unitario :";
            // 
            // txtUnidadesCompradas
            // 
            this.txtUnidadesCompradas.Location = new System.Drawing.Point(339, 28);
            this.txtUnidadesCompradas.Name = "txtUnidadesCompradas";
            this.txtUnidadesCompradas.Size = new System.Drawing.Size(100, 25);
            this.txtUnidadesCompradas.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(189, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Unidades Compradas :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(524, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(305, 39);
            this.label4.TabIndex = 10;
            this.label4.Text = "Sistema Valuación";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(486, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(389, 39);
            this.label5.TabIndex = 11;
            this.label5.Text = "Identificación Especifica";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::pjContabilidadMetodosValuacion.Properties.Resources.teneduria_de_libros;
            this.pictureBox1.Location = new System.Drawing.Point(341, 25);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnRegistrarSalidas);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.DTPSalida);
            this.groupBox2.Controls.Add(this.txtUnidadesUsadas);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Sitka Banner", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(24, 191);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(888, 70);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos Salidas";
            // 
            // btnRegistrarSalidas
            // 
            this.btnRegistrarSalidas.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRegistrarSalidas.Location = new System.Drawing.Point(717, 30);
            this.btnRegistrarSalidas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegistrarSalidas.Name = "btnRegistrarSalidas";
            this.btnRegistrarSalidas.Size = new System.Drawing.Size(88, 26);
            this.btnRegistrarSalidas.TabIndex = 14;
            this.btnRegistrarSalidas.Text = "Registrar";
            this.btnRegistrarSalidas.UseVisualStyleBackColor = true;
            this.btnRegistrarSalidas.Click += new System.EventHandler(this.btnRegistrarSalidas_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(5, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 18);
            this.label7.TabIndex = 13;
            this.label7.Text = "Fecha :";
            // 
            // DTPSalida
            // 
            this.DTPSalida.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DTPSalida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPSalida.Location = new System.Drawing.Point(70, 28);
            this.DTPSalida.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DTPSalida.Name = "DTPSalida";
            this.DTPSalida.Size = new System.Drawing.Size(107, 26);
            this.DTPSalida.TabIndex = 12;
            this.DTPSalida.Value = new System.DateTime(2022, 10, 10, 0, 0, 0, 0);
            // 
            // txtUnidadesUsadas
            // 
            this.txtUnidadesUsadas.Location = new System.Drawing.Point(317, 33);
            this.txtUnidadesUsadas.Name = "txtUnidadesUsadas";
            this.txtUnidadesUsadas.Size = new System.Drawing.Size(100, 25);
            this.txtUnidadesUsadas.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(189, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Unidades Usadas :";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.lvDatosIngresados);
            this.groupBox3.Font = new System.Drawing.Font("Sitka Banner", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(30, 281);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(637, 205);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos Ingresados";
            // 
            // lvDatosIngresados
            // 
            this.lvDatosIngresados.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvDatosIngresados.Font = new System.Drawing.Font("Sitka Text", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lvDatosIngresados.GridLines = true;
            this.lvDatosIngresados.Location = new System.Drawing.Point(8, 35);
            this.lvDatosIngresados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvDatosIngresados.Name = "lvDatosIngresados";
            this.lvDatosIngresados.Size = new System.Drawing.Size(623, 159);
            this.lvDatosIngresados.TabIndex = 0;
            this.lvDatosIngresados.UseCompatibleStateImageBehavior = false;
            this.lvDatosIngresados.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Fecha";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Unidades Compradas";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 120;
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
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.listView1);
            this.groupBox4.Font = new System.Drawing.Font("Sitka Banner", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox4.Location = new System.Drawing.Point(685, 281);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(559, 205);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Datos Especificaciones";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7});
            this.listView1.Font = new System.Drawing.Font("Sitka Text", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(49, 34);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(488, 161);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Fecha";
            this.columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Unidades Utilizadas";
            this.columnHeader7.Width = 160;
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.Transparent;
            this.groupBox6.Font = new System.Drawing.Font("Sitka Banner", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox6.Location = new System.Drawing.Point(1025, 80);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox6.Size = new System.Drawing.Size(219, 194);
            this.groupBox6.TabIndex = 17;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Resultados";
            // 
            // frmIdentificacionEspecifica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chartreuse;
            this.BackgroundImage = global::pjContabilidadMetodosValuacion.Properties.Resources.identificacion;
            this.ClientSize = new System.Drawing.Size(1349, 518);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmIdentificacionEspecifica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmIdentificacionEspecifica";
            this.Load += new System.EventHandler(this.frmIdentificacionEspecifica_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private Label label4;
        private Label label5;
        private PictureBox pictureBox1;
        private GroupBox groupBox2;
        private Button btnRegistrarSalidas;
        private Label label7;
        private DateTimePicker DTPSalida;
        private TextBox txtUnidadesUsadas;
        private Label label2;
        private GroupBox groupBox3;
        private ListView lvDatosIngresados;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private GroupBox groupBox4;
        private ListView listView1;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private GroupBox groupBox6;
        private ColumnHeader columnHeader4;
    }
}