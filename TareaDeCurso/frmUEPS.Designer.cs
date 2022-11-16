namespace pjContabilidadMetodosValuacion
{
    partial class frmUEPS
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gbCompras = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCompras = new System.Windows.Forms.TextBox();
            this.btnRegistrarCompras = new System.Windows.Forms.Button();
            this.DTPCompras = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCostoCompras = new System.Windows.Forms.TextBox();
            this.gbSalidas = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUsadas = new System.Windows.Forms.TextBox();
            this.DTPUsadas = new System.Windows.Forms.DateTimePicker();
            this.btnRegistrarUsadas = new System.Windows.Forms.Button();
            this.gbDatosIngresados = new System.Windows.Forms.GroupBox();
            this.lvUnidadesCompradas = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.lvUnidadesUsadas = new System.Windows.Forms.ListView();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbCompras.SuspendLayout();
            this.gbSalidas.SuspendLayout();
            this.gbDatosIngresados.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::pjContabilidadMetodosValuacion.Properties.Resources.calculadora__1_;
            this.pictureBox1.Location = new System.Drawing.Point(186, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(311, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(381, 51);
            this.label3.TabIndex = 12;
            this.label3.Text = "Sistema Valuación";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(413, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 51);
            this.label4.TabIndex = 13;
            this.label4.Text = "UEPS";
            // 
            // gbCompras
            // 
            this.gbCompras.BackColor = System.Drawing.Color.Transparent;
            this.gbCompras.Controls.Add(this.label5);
            this.gbCompras.Controls.Add(this.label1);
            this.gbCompras.Controls.Add(this.txtCompras);
            this.gbCompras.Controls.Add(this.btnRegistrarCompras);
            this.gbCompras.Controls.Add(this.DTPCompras);
            this.gbCompras.Controls.Add(this.label2);
            this.gbCompras.Controls.Add(this.txtCostoCompras);
            this.gbCompras.Font = new System.Drawing.Font("Sitka Banner", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbCompras.Location = new System.Drawing.Point(14, 147);
            this.gbCompras.Name = "gbCompras";
            this.gbCompras.Size = new System.Drawing.Size(818, 93);
            this.gbCompras.TabIndex = 14;
            this.gbCompras.TabStop = false;
            this.gbCompras.Text = "Datos Compras";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(9, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 22);
            this.label5.TabIndex = 6;
            this.label5.Text = "Fecha :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(213, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Unidades Compradas : ";
            // 
            // txtCompras
            // 
            this.txtCompras.Location = new System.Drawing.Point(399, 45);
            this.txtCompras.Name = "txtCompras";
            this.txtCompras.Size = new System.Drawing.Size(100, 29);
            this.txtCompras.TabIndex = 2;
            // 
            // btnRegistrarCompras
            // 
            this.btnRegistrarCompras.AutoSize = true;
            this.btnRegistrarCompras.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRegistrarCompras.Location = new System.Drawing.Point(685, 45);
            this.btnRegistrarCompras.Name = "btnRegistrarCompras";
            this.btnRegistrarCompras.Size = new System.Drawing.Size(105, 37);
            this.btnRegistrarCompras.TabIndex = 0;
            this.btnRegistrarCompras.Text = "Registrar";
            this.btnRegistrarCompras.UseVisualStyleBackColor = true;
            this.btnRegistrarCompras.Click += new System.EventHandler(this.btnRegistrarCompras_Click);
            // 
            // DTPCompras
            // 
            this.DTPCompras.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DTPCompras.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPCompras.Location = new System.Drawing.Point(75, 44);
            this.DTPCompras.Name = "DTPCompras";
            this.DTPCompras.Size = new System.Drawing.Size(121, 27);
            this.DTPCompras.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(506, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "C/U :";
            // 
            // txtCostoCompras
            // 
            this.txtCostoCompras.Location = new System.Drawing.Point(557, 43);
            this.txtCostoCompras.Name = "txtCostoCompras";
            this.txtCostoCompras.Size = new System.Drawing.Size(100, 29);
            this.txtCostoCompras.TabIndex = 3;
            // 
            // gbSalidas
            // 
            this.gbSalidas.BackColor = System.Drawing.Color.Transparent;
            this.gbSalidas.Controls.Add(this.label6);
            this.gbSalidas.Controls.Add(this.label7);
            this.gbSalidas.Controls.Add(this.txtUsadas);
            this.gbSalidas.Controls.Add(this.DTPUsadas);
            this.gbSalidas.Controls.Add(this.btnRegistrarUsadas);
            this.gbSalidas.Font = new System.Drawing.Font("Sitka Banner", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbSalidas.Location = new System.Drawing.Point(14, 245);
            this.gbSalidas.Name = "gbSalidas";
            this.gbSalidas.Size = new System.Drawing.Size(818, 95);
            this.gbSalidas.TabIndex = 15;
            this.gbSalidas.TabStop = false;
            this.gbSalidas.Text = "Datos Salidas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(9, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 22);
            this.label6.TabIndex = 10;
            this.label6.Text = "Fecha :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(213, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(183, 22);
            this.label7.TabIndex = 9;
            this.label7.Text = "Unidades Utilizadas : ";
            // 
            // txtUsadas
            // 
            this.txtUsadas.Location = new System.Drawing.Point(387, 36);
            this.txtUsadas.Name = "txtUsadas";
            this.txtUsadas.Size = new System.Drawing.Size(100, 29);
            this.txtUsadas.TabIndex = 8;
            // 
            // DTPUsadas
            // 
            this.DTPUsadas.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DTPUsadas.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPUsadas.Location = new System.Drawing.Point(75, 37);
            this.DTPUsadas.Name = "DTPUsadas";
            this.DTPUsadas.Size = new System.Drawing.Size(121, 27);
            this.DTPUsadas.TabIndex = 7;
            // 
            // btnRegistrarUsadas
            // 
            this.btnRegistrarUsadas.AutoSize = true;
            this.btnRegistrarUsadas.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRegistrarUsadas.Location = new System.Drawing.Point(549, 39);
            this.btnRegistrarUsadas.Name = "btnRegistrarUsadas";
            this.btnRegistrarUsadas.Size = new System.Drawing.Size(105, 37);
            this.btnRegistrarUsadas.TabIndex = 4;
            this.btnRegistrarUsadas.Text = "Registrar";
            this.btnRegistrarUsadas.UseVisualStyleBackColor = true;
            this.btnRegistrarUsadas.Click += new System.EventHandler(this.btnRegistrarUsadas_Click);
            // 
            // gbDatosIngresados
            // 
            this.gbDatosIngresados.BackColor = System.Drawing.Color.Transparent;
            this.gbDatosIngresados.Controls.Add(this.lvUnidadesCompradas);
            this.gbDatosIngresados.Font = new System.Drawing.Font("Sitka Banner", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbDatosIngresados.Location = new System.Drawing.Point(14, 347);
            this.gbDatosIngresados.Name = "gbDatosIngresados";
            this.gbDatosIngresados.Size = new System.Drawing.Size(430, 247);
            this.gbDatosIngresados.TabIndex = 16;
            this.gbDatosIngresados.TabStop = false;
            this.gbDatosIngresados.Text = "Datos Compras";
            // 
            // lvUnidadesCompradas
            // 
            this.lvUnidadesCompradas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader7});
            this.lvUnidadesCompradas.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lvUnidadesCompradas.GridLines = true;
            this.lvUnidadesCompradas.Location = new System.Drawing.Point(7, 29);
            this.lvUnidadesCompradas.Name = "lvUnidadesCompradas";
            this.lvUnidadesCompradas.Size = new System.Drawing.Size(417, 197);
            this.lvUnidadesCompradas.TabIndex = 7;
            this.lvUnidadesCompradas.UseCompatibleStateImageBehavior = false;
            this.lvUnidadesCompradas.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Fecha";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Unidades Compradas";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 140;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "C/U";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Costo Total";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader7.Width = 80;
            // 
            // lvUnidadesUsadas
            // 
            this.lvUnidadesUsadas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader8});
            this.lvUnidadesUsadas.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lvUnidadesUsadas.GridLines = true;
            this.lvUnidadesUsadas.Location = new System.Drawing.Point(17, 32);
            this.lvUnidadesUsadas.Name = "lvUnidadesUsadas";
            this.lvUnidadesUsadas.Size = new System.Drawing.Size(438, 197);
            this.lvUnidadesUsadas.TabIndex = 8;
            this.lvUnidadesUsadas.UseCompatibleStateImageBehavior = false;
            this.lvUnidadesUsadas.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Fecha";
            this.columnHeader4.Width = 80;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Unidades Utilizadas";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 140;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "C/U";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Costo Total";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader8.Width = 100;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lvUnidadesUsadas);
            this.groupBox1.Font = new System.Drawing.Font("Sitka Banner", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(450, 347);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(463, 247);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Usadas";
            // 
            // frmUEPS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 644);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbDatosIngresados);
            this.Controls.Add(this.gbSalidas);
            this.Controls.Add(this.gbCompras);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmUEPS";
            this.Text = "frmUEPS";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbCompras.ResumeLayout(false);
            this.gbCompras.PerformLayout();
            this.gbSalidas.ResumeLayout(false);
            this.gbSalidas.PerformLayout();
            this.gbDatosIngresados.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Label label3;
        private Label label4;
        private GroupBox gbCompras;
        private Label label5;
        private Label label1;
        private TextBox txtCompras;
        private Button btnRegistrarCompras;
        private DateTimePicker DTPCompras;
        private Label label2;
        private TextBox txtCostoCompras;
        private GroupBox gbSalidas;
        private Label label6;
        private Label label7;
        private TextBox txtUsadas;
        private DateTimePicker DTPUsadas;
        private Button btnRegistrarUsadas;
        private GroupBox gbDatosIngresados;
        private ListView lvUnidadesCompradas;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ListView lvUnidadesUsadas;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private GroupBox groupBox1;
    }
}