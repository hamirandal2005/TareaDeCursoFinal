namespace pjContabilidadMetodosValuacion
{
    partial class frmMetodoPuntoAltoBajo
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mtbNivelActividad = new System.Windows.Forms.MaskedTextBox();
            this.mtbCostoPeriodo = new System.Windows.Forms.MaskedTextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbMes = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lvInfo = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.lvAltoBajo = new System.Windows.Forms.ListView();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.lblTasaVariable = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.gbTasaVariable = new System.Windows.Forms.GroupBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lblCostoFijo = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panelIngresados = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.gbTasaVariable.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Candara", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(145, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Metodo punto alto punto bajo";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.mtbNivelActividad);
            this.groupBox1.Controls.Add(this.mtbCostoPeriodo);
            this.groupBox1.Controls.Add(this.btnRegistrar);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbMes);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Sitka Banner", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(145, 157);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(938, 75);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingresar datos";
            // 
            // mtbNivelActividad
            // 
            this.mtbNivelActividad.Location = new System.Drawing.Point(593, 30);
            this.mtbNivelActividad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mtbNivelActividad.Name = "mtbNivelActividad";
            this.mtbNivelActividad.Size = new System.Drawing.Size(76, 25);
            this.mtbNivelActividad.TabIndex = 5;
            // 
            // mtbCostoPeriodo
            // 
            this.mtbCostoPeriodo.Location = new System.Drawing.Point(338, 34);
            this.mtbCostoPeriodo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mtbCostoPeriodo.Name = "mtbCostoPeriodo";
            this.mtbCostoPeriodo.Size = new System.Drawing.Size(76, 25);
            this.mtbCostoPeriodo.TabIndex = 4;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.AutoSize = true;
            this.btnRegistrar.BackColor = System.Drawing.Color.White;
            this.btnRegistrar.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRegistrar.ForeColor = System.Drawing.Color.Black;
            this.btnRegistrar.Location = new System.Drawing.Point(818, 27);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(77, 28);
            this.btnRegistrar.TabIndex = 4;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Candara", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(454, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nivel de actividad : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(207, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Costo del periodo : ";
            // 
            // cbMes
            // 
            this.cbMes.FormattingEnabled = true;
            this.cbMes.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Noviembre",
            "Diciembre"});
            this.cbMes.Location = new System.Drawing.Point(67, 34);
            this.cbMes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbMes.Name = "cbMes";
            this.cbMes.Size = new System.Drawing.Size(91, 28);
            this.cbMes.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(25, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mes : ";
            // 
            // lvInfo
            // 
            this.lvInfo.BackColor = System.Drawing.Color.White;
            this.lvInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvInfo.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lvInfo.GridLines = true;
            this.lvInfo.Location = new System.Drawing.Point(32, 41);
            this.lvInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvInfo.Name = "lvInfo";
            this.lvInfo.Size = new System.Drawing.Size(360, 265);
            this.lvInfo.TabIndex = 3;
            this.lvInfo.UseCompatibleStateImageBehavior = false;
            this.lvInfo.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mes";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Costo del periodo";
            this.columnHeader2.Width = 140;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Nivel de actividad";
            this.columnHeader3.Width = 120;
            // 
            // lvAltoBajo
            // 
            this.lvAltoBajo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5});
            this.lvAltoBajo.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lvAltoBajo.GridLines = true;
            this.lvAltoBajo.Location = new System.Drawing.Point(405, 42);
            this.lvAltoBajo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvAltoBajo.Name = "lvAltoBajo";
            this.lvAltoBajo.Size = new System.Drawing.Size(265, 264);
            this.lvAltoBajo.TabIndex = 6;
            this.lvAltoBajo.UseCompatibleStateImageBehavior = false;
            this.lvAltoBajo.View = System.Windows.Forms.View.Details;
            this.lvAltoBajo.Visible = false;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Mes";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Costo variable total";
            this.columnHeader5.Width = 150;
            // 
            // lblTasaVariable
            // 
            this.lblTasaVariable.AutoSize = true;
            this.lblTasaVariable.BackColor = System.Drawing.Color.Transparent;
            this.lblTasaVariable.Font = new System.Drawing.Font("Candara", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTasaVariable.Location = new System.Drawing.Point(129, 31);
            this.lblTasaVariable.Name = "lblTasaVariable";
            this.lblTasaVariable.Size = new System.Drawing.Size(46, 18);
            this.lblTasaVariable.TabIndex = 7;
            this.lblTasaVariable.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Candara", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(19, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 18);
            this.label6.TabIndex = 8;
            this.label6.Text = "Tasa variable : ";
            // 
            // gbTasaVariable
            // 
            this.gbTasaVariable.BackColor = System.Drawing.Color.Transparent;
            this.gbTasaVariable.Controls.Add(this.btnLimpiar);
            this.gbTasaVariable.Controls.Add(this.label7);
            this.gbTasaVariable.Controls.Add(this.lblCostoFijo);
            this.gbTasaVariable.Controls.Add(this.label6);
            this.gbTasaVariable.Controls.Add(this.lblTasaVariable);
            this.gbTasaVariable.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbTasaVariable.ForeColor = System.Drawing.Color.White;
            this.gbTasaVariable.Location = new System.Drawing.Point(871, 254);
            this.gbTasaVariable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbTasaVariable.Name = "gbTasaVariable";
            this.gbTasaVariable.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbTasaVariable.Size = new System.Drawing.Size(212, 172);
            this.gbTasaVariable.TabIndex = 9;
            this.gbTasaVariable.TabStop = false;
            this.gbTasaVariable.Text = "Resultados";
            this.gbTasaVariable.Visible = false;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.AutoSize = true;
            this.btnLimpiar.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLimpiar.ForeColor = System.Drawing.Color.Black;
            this.btnLimpiar.Location = new System.Drawing.Point(103, 113);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(66, 28);
            this.btnLimpiar.TabIndex = 10;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Candara", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(27, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 18);
            this.label7.TabIndex = 10;
            this.label7.Text = "Costo fijo : ";
            // 
            // lblCostoFijo
            // 
            this.lblCostoFijo.AutoSize = true;
            this.lblCostoFijo.Font = new System.Drawing.Font("Candara", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCostoFijo.Location = new System.Drawing.Point(129, 75);
            this.lblCostoFijo.Name = "lblCostoFijo";
            this.lblCostoFijo.Size = new System.Drawing.Size(46, 18);
            this.lblCostoFijo.TabIndex = 9;
            this.lblCostoFijo.Text = "label5";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.lvAltoBajo);
            this.groupBox2.Controls.Add(this.lvInfo);
            this.groupBox2.Controls.Add(this.panelIngresados);
            this.groupBox2.Font = new System.Drawing.Font("Sitka Banner", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(144, 245);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(704, 344);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos Ingresados";
            // 
            // panelIngresados
            // 
            this.panelIngresados.BackColor = System.Drawing.Color.Gold;
            this.panelIngresados.Location = new System.Drawing.Point(16, 23);
            this.panelIngresados.Name = "panelIngresados";
            this.panelIngresados.Size = new System.Drawing.Size(385, 304);
            this.panelIngresados.TabIndex = 22;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gold;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(100, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 50);
            this.panel1.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Candara", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(45, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 42);
            this.label5.TabIndex = 8;
            this.label5.Text = "Sistema V";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(300, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 50);
            this.panel2.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Candara", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.Gold;
            this.label8.Location = new System.Drawing.Point(-8, 2);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 42);
            this.label8.TabIndex = 9;
            this.label8.Text = "aluacion";
            // 
            // frmMetodoPuntoAltoBajo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::pjContabilidadMetodosValuacion.Properties.Resources.FondoAmarillo;
            this.ClientSize = new System.Drawing.Size(1172, 658);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbTasaVariable);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmMetodoPuntoAltoBajo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMetodoPuntoAltoBajo";
            this.Load += new System.EventHandler(this.frmMetodoPuntoAltoBajo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbTasaVariable.ResumeLayout(false);
            this.gbTasaVariable.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private GroupBox groupBox1;
        private ComboBox cbMes;
        private Label label2;
        private Label label4;
        private Label label3;
        private MaskedTextBox mtbNivelActividad;
        private MaskedTextBox mtbCostoPeriodo;
        private ListView lvInfo;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Button btnRegistrar;
        private ListView lvAltoBajo;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private Label lblTasaVariable;
        private Label label6;
        private GroupBox gbTasaVariable;
        private Label label7;
        private Label lblCostoFijo;
        private Button btnLimpiar;
        private GroupBox groupBox2;
        private Panel panel1;
        private Label label5;
        private Panel panel2;
        private Label label8;
        private Panel panelIngresados;
    }
}