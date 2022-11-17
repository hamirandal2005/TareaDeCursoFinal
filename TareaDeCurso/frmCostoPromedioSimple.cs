using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pjContabilidadMetodosValuacion
{
    public partial class frmCostoPromedioSimple : Form
    {

        //Variables Globales
        string fecha;
        double unidadesCompradas;
        double costoUnitario;
        double unidadesUtilizadas;
        string fecha2;

        public frmCostoPromedioSimple()
        {
            InitializeComponent();
        }
        private void frmCostoPromedioSimple_Load(object sender, EventArgs e)
        {
            lblCostoMaterialesUsados.Text="C";
            lblInventarioFinal.Text = "C";
            lblSaldo.Text = "C";

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {


            try
            {
                try
                {
                    if(double.Parse(txtUnidadesCompradas.Text )>0 && double.Parse(txtCostoUnitario.Text)>0 )
                    {
                        //Obteniendo Datos

                        fecha = dtFecha.Text;
                        unidadesCompradas = double.Parse(txtUnidadesCompradas.Text);
                        costoUnitario = double.Parse(txtCostoUnitario.Text);

                        ListViewItem fila = new ListViewItem(fecha);
                        fila.SubItems.Add(unidadesCompradas.ToString("0.00"));
                        fila.SubItems.Add(costoUnitario.ToString("0.00"));
                        lvDatosIngresados.Items.Add(fila);

                        //Limpiar Controles
                        txtUnidadesCompradas.Clear();
                        txtCostoUnitario.Clear();
                        txtUnidadesCompradas.Focus();
                    }

                }
                catch (OverflowException)
                {
                    MessageBox.Show("Numeros muy Grandes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //Limpiar Controles
                    txtUnidadesCompradas.Clear();
                    txtCostoUnitario.Clear();
                    txtUnidadesCompradas.Focus();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese un valor entero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //Limpiar Controles
                txtUnidadesCompradas.Clear();
                txtCostoUnitario.Clear();
                txtUnidadesCompradas.Focus();

            }
              


        }


        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Sacar el Saldo
            double  totalUnidadesCompradas = 0;
            double totalunidadesUtilizadas = 0;
            double saldo = SumatoriasRegistro1(totalUnidadesCompradas, 1)- SumatoriasRegistro2(totalunidadesUtilizadas, 1); ;
            //Sacar costo Promedio Ponderado 
            int numeroCompras= lvDatosIngresados.Items.Count;
            double costoUnitario = 0;
            double costoPromedioSimple = SumatoriasRegistro1(costoUnitario, 2) / numeroCompras;
            //Calcular los Costos
            //Costo de Materiales Utilizados
            double costoMaterialesUsados= costoPromedioSimple*SumatoriasRegistro2(totalunidadesUtilizadas, 1);
            double costoInventarioFinal = costoPromedioSimple * saldo;
            double costoTotalCompra = costoPromedioSimple * SumatoriasRegistro1(totalUnidadesCompradas, 1);

            //Imprimir Resultados
            lblCostoMaterialesUsados.Text = costoMaterialesUsados.ToString("C");
            lblInventarioFinal.Text = costoInventarioFinal.ToString("C");
            lblSaldo.Text = saldo.ToString("C");
            lblCostoTotalCompra.Text = costoTotalCompra.ToString("C");
            
            
   

 

        }
        private double SumatoriasRegistro1(double variable, int n)
        {
            variable = 0;
            for (int i = 0; i < lvDatosIngresados.Items.Count; i++)
            {
                if (lvDatosIngresados.Items[i].SubItems[0].Text != "")
                {
                    variable += double.Parse(lvDatosIngresados.Items[i].SubItems[n].Text);
                }

            }

            return variable;
        }
        private double SumatoriasRegistro2(double variable, int n)
        {
            variable = 0;
            for (int i = 0; i < lvDatos2.Items.Count; i++)
            {
                if (lvDatos2.Items[i].SubItems[0].Text != "")
                {
                    variable += double.Parse(lvDatos2.Items[i].SubItems[n].Text);
                }

            }

            return variable;
        }

        private void btnRegistrarUU_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    if (double.Parse(txtUnidadesUtilizadas.Text) > 0) 
                        {
                        fecha2 = dtFecha2.Text;
                        unidadesUtilizadas = double.Parse(txtUnidadesUtilizadas.Text);
                        ListViewItem fila = new ListViewItem(fecha2);
                        fila.SubItems.Add(unidadesUtilizadas.ToString("0.00"));
                        lvDatos2.Items.Add(fila);
                        txtUnidadesUtilizadas.Clear();
                    } 

                }
                catch (OverflowException)
                {
                    MessageBox.Show("Numeros muy Grandes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtUnidadesUtilizadas.Clear();
                    txtUnidadesUtilizadas.Focus();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese un valor entero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtUnidadesUtilizadas.Clear();
                txtUnidadesUtilizadas.Focus();
            }
            
        }

        private void btnMenú_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Hide();
            frmPrincipal Menu = new frmPrincipal();
            Menu.ShowDialog();

        }
    }
}
