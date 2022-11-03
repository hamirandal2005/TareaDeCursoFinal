using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using Clases;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.DirectoryServices.ActiveDirectory;

namespace pjContabilidadMetodosValuacion
{
    public partial class frmMetodoPuntoAltoBajo : Form
    {
        PuntoBajoPuntoAlto altoBajo = new PuntoBajoPuntoAlto();
        int cantidad = 0;


        public frmMetodoPuntoAltoBajo()
        {
            InitializeComponent();
        }
        public void iniciar() //Pruebas
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
            iniciar();
            Mes a = new Mes();
            a.Nombre = cbMes.Text;
            try
            {
                a.Valor = double.Parse(mtbCostoPeriodo.Text);
                a.Horas = int.Parse(mtbNivelActividad.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese un valor entero", "Notificacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                mtbCostoPeriodo.Clear();
                mtbNivelActividad.Clear();
            }
            for (int i = 0; i < altoBajo.Meses.Length; i++)
            {
                if (altoBajo.Meses[i].Nombre == cbMes.Text)
                    altoBajo.Meses[i] = a;
            }
            if (Comprobando())
            {
                frmMetodoPuntoAltoBajo_Load(sender, e);
                DialogResult r = MessageBox.Show("Verifique la informacion, ¿Desea hacer el calculo con la informacion ingresada?", "Notificacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    lvAltoBajo.Visible = true; Calcular();
                }
                else
                    gbTasaVariable.Visible = false;
            }
            else
            {
                frmMetodoPuntoAltoBajo_Load(sender, e);
                mtbCostoPeriodo.Clear();
                mtbNivelActividad.Clear();
                cbMes.Focus();
            }
        }
        public bool Comprobando()
        {
            bool comprobante = false;
            foreach (Mes a in altoBajo.Meses)
            {
                if (a.Horas > 0 && a.Valor > 0)
                    comprobante = true;
                else
                    return false;
            }
            return comprobante;
        }
        public enum Meses
        {
            Enero = 0,
            Febrero = 1,
            Marzo = 2,
            Abril = 3,
            Mayo = 4,
            Junio = 5,
            Julio = 6,
            Agosto = 7,
            Septiembre = 8,
            Octubre = 9,
            Noviembre = 10,
            Diciembre = 11
        }
        private void Calcular()
        {
            gbTasaVariable.Visible = true;
            lblTasaVariable.Text = altoBajo.CostoVariableUnitario().ToString("0.00");
            lblCostoFijo.Text = altoBajo.CostoFijoTotal().ToString("0.00");
            lvAltoBajo.Items.Clear();
            for (int i = 0; i < altoBajo.Meses.Length; i++)
            {
                String[] info = new string[2];
                info[0] = altoBajo.Meses[i].Nombre;
                info[1] = (altoBajo.CostoVariableTotal(i) + altoBajo.CostoFijoTotal()).ToString("0.00");
                ListViewItem list = new ListViewItem(info);
                lvAltoBajo.Items.Add(list);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lvAltoBajo.Items.Clear();
            gbTasaVariable.Visible = false;
            lvAltoBajo.Visible = false;
            altoBajo = new PuntoBajoPuntoAlto();
            frmMetodoPuntoAltoBajo_Load(sender, e);
        }
        //A
        //B
    }
}
