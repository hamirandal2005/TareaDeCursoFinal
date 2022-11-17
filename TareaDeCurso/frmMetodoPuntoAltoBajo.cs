using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.DirectoryServices.ActiveDirectory;
using Clases;

namespace pjContabilidadMetodosValuacion
{
    public partial class frmMetodoPuntoAltoBajo : Form
    {
        PuntoBajoPuntoAlto altoBajo = new PuntoBajoPuntoAlto();
        int cantidad = 0;


        public frmMetodoPuntoAltoBajo()
        {
            InitializeComponent();
            this.Tmensaje.SetToolTip(this.mtbCostoPeriodo, "Solo números mayores que 0");
            this.Tmensaje.SetToolTip(this.mtbNivelActividad, "Solo números mayores que 0");
        }
        public void iniciar()
        {
            altoBajo.Meses[0] = new Mes("Enero", 166000, 6700);
            altoBajo.Meses[1] = new Mes("Febrero", 170000, 7000);
            altoBajo.Meses[2] = new Mes("Marzo", 175000, 8000);
            altoBajo.Meses[3] = new Mes("Abril", 188000, 9300);
            altoBajo.Meses[4] = new Mes("Mayo", 190000, 10000);
            altoBajo.Meses[5] = new Mes("Junio", 190000, 11000);
            altoBajo.Meses[6] = new Mes("Julio", 165000, 6800);
            altoBajo.Meses[7] = new Mes("Agosto", 200000, 12000);
            altoBajo.Meses[8] = new Mes("Septiembre", 180000, 9800);
            altoBajo.Meses[9] = new Mes("Octubre", 175000, 7600);
            altoBajo.Meses[10] = new Mes("Noviembre", 160000, 6400);
            altoBajo.Meses[11] = new Mes("Diciembre", 155000, 6000);
        }
        private void frmMetodoPuntoAltoBajo_Load(object sender, EventArgs e)
        {

            lblCostoFijo.Text = "0.00";
            lblTasaVariable.Text = "0.00";
            lvInfo.Items.Clear();
            lvAltoBajo.Visible = false;
            for (int i = 0; i < altoBajo.Meses.Length; i++)
            {
                String[] info = new string[3];
                info[0] = altoBajo.Meses[i].Nombre;
                info[1] = altoBajo.Meses[i].Valor.ToString();
                info[2] = altoBajo.Meses[i].Horas.ToString();
                ListViewItem list = new ListViewItem(info);
                lvInfo.Items.Add(list);
            }

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //iniciar();
            Mes a = new Mes();
            a.Nombre = cbMes.Text;
            try
            {
                a.Valor = double.Parse(mtbCostoPeriodo.Text);
                a.Horas = int.Parse(mtbNivelActividad.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Rellene las casillas con información valida", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mtbCostoPeriodo.Clear();
                mtbNivelActividad.Clear();
                return;
            }
            if (double.Parse(mtbCostoPeriodo.Text) < 999999 && int.Parse(mtbNivelActividad.Text) < 999999)
            {
                if (double.Parse(mtbCostoPeriodo.Text) > 0 && int.Parse(mtbNivelActividad.Text) > 0)
                {
                    for (int i = 0; i < altoBajo.Meses.Length; i++)
                    {
                        if (altoBajo.Meses[i].Nombre == cbMes.Text)
                            altoBajo.Meses[i] = a;
                    }
                    frmMetodoPuntoAltoBajo_Load(sender, e);
                    mtbCostoPeriodo.Clear();
                    mtbNivelActividad.Clear();
                    cbMes.Focus();
                }
                else
                {
                    MessageBox.Show("Solo puedes ingresar números mayores que 0", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    mtbCostoPeriodo.Clear();
                    mtbNivelActividad.Clear();
                    return;
                }
                mtbCostoPeriodo.Clear();
                mtbNivelActividad.Clear();
            }
            else
            {
                MessageBox.Show("Números demasiado grandes", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mtbCostoPeriodo.Clear();
                mtbNivelActividad.Clear();
                return;
            }

        }

        private void Calcular()
        {
            double TasaVariable = altoBajo.CostoVariableUnitario();
            double CostoFijo = altoBajo.CostoFijoTotal();
            gbTasaVariable.Visible = true;
            lblTasaVariable.Text = TasaVariable.ToString("0.00");
            lblCostoFijo.Text = CostoFijo.ToString("0.00");
            lvAltoBajo.Items.Clear();
            for (int i = 0; i < altoBajo.Meses.Length; i++)
            {
                if (altoBajo.Meses[i].Valor != 0)
                {
                    String[] info = new string[2];
                    info[0] = altoBajo.Meses[i].Nombre;
                    info[1] = (altoBajo.CostoVariableTotal(i) + CostoFijo).ToString("0.00");
                    ListViewItem list = new ListViewItem(info);
                    lvAltoBajo.Items.Add(list);
                }
                else
                {
                    String[] info = new string[2];
                    info[0] = altoBajo.Meses[i].Nombre;
                    info[1] = 0.ToString("0.00");
                    ListViewItem list = new ListViewItem(info);
                    lvAltoBajo.Items.Add(list);
                }

            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lvAltoBajo.Items.Clear();
            gbTasaVariable.Visible = false;
            lvAltoBajo.Visible = false;
            altoBajo = new PuntoBajoPuntoAlto();
            frmMetodoPuntoAltoBajo_Load(sender, e);
            cbMes.Text = "(Seleccione)";
            panelIngresados.Size = new Size(385, 304);
        }

        private void btnMenú_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Hide();
            frmPrincipal Menu = new frmPrincipal();
            Menu.ShowDialog();

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            altoBajo.OrdenarMeses();

            if (altoBajo.MesAlto != null && altoBajo.MesBajo != null)
            {
                if (altoBajo.MesAlto != altoBajo.MesBajo)
                {
                    lvAltoBajo.Visible = true; Calcular();
                    panelIngresados.Size = new Size(675, 304);
                }
                else
                {
                    MessageBox.Show("Ingrese más valores a la tabla", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Ingrese valores a la tabla", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
