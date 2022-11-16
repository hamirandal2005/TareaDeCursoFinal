using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pjContabilidadMetodosValuacion
{
    public partial class frmMétodoEstadístico : Form
    {
        //Capturando datos Global
        double variableX;
        double variableY;
        string mes;
        public frmMétodoEstadístico()
        {
            InitializeComponent();

            this.ttMensajeVariable.SetToolTip(this.txtVariableX, "* X * es la actividad en torno a la cual cambia el costo Variable");
            this.ttMensajeVariable.SetToolTip(this.txtVariableY, "* Y * son los Costos Totales");

            
        }

        private void frmMétodoEstadístico_Load(object sender, EventArgs e)
        {
            txtCostoUnitario.Text = "0.00";
            txtCostoTotal.Text = "0.00";

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {

                    if (double.Parse(txtVariableX.Text)>0 && double.Parse(txtVariableY.Text) > 0)
                    {

                        //Capturando Datos
                        variableX = double.Parse(this.txtVariableX.Text);
                        variableY = double.Parse(this.txtVariableY.Text);
                        mes = cboMes.Text;

                        //Pasando Datos a lv
                        ListViewItem fila = new ListViewItem(mes);
                        fila.SubItems.Add(variableX.ToString("0.00"));
                        fila.SubItems.Add(variableY.ToString("0.00"));
                        lvDatos.Items.Add(fila);
                        txtVariableX.Clear();
                        txtVariableY.Clear();
                        txtVariableX.Focus();

                    }
                    else
                    {

                    }

                }
                catch (OverflowException)
                {
                    MessageBox.Show("Numeros muy Grandes", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtVariableX.Clear();
                    txtVariableY.Clear();
                    txtVariableX.Focus();
                }

            }
            catch (FormatException)
            {
                MessageBox.Show ("Ingrese los datos en un formato Valido ", "¡Error!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtVariableX.Clear();
                txtVariableY.Clear();
                txtVariableX.Focus();
            }
           

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            //Calculos para Costo Variable Unitario

            //Primer Dato sumatoria de X por Y
            double sumatoriaXY = 0;

            for (int i=0; i < lvDatos.Items.Count; i++)
            {
                sumatoriaXY+= double.Parse(lvDatos.Items[i].SubItems[1].Text) *
                    double.Parse(lvDatos.Items[i].SubItems[2].Text);
            }

            //Segundo Dato Sumatoria de X por la Sumatoria de Y
               
            double sumasXY = CalculoSumatoria(variableX, 1)*CalculoSumatoria(variableY, 2);
            //Tercer Dato la sumatoria de Variables X al cuadrado

            double sumatoriasdeXCuadrada = 0;
            
            for(int j = 0; j < lvDatos.Items.Count; j++)
            {
                if (lvDatos.Items[j].SubItems[0].Text != "")
                {
                    double variables = double.Parse(lvDatos.Items[j].SubItems[1].Text);
                    sumatoriasdeXCuadrada+= Math.Pow(variables, 2); 
                }
            }
            //Cuarto Dato la sumatoria de X elevada al Cuadrado
            double sumaX2 = Math.Pow(CalculoSumatoria(variableX,1),2);

            //Quinto Dato Contar datos 
            int n = lvDatos.Items.Count;
              

            //  **FORMULA DE COSTO VARIABLE UNITARIO**

            double numerador = (n*sumatoriaXY)-sumasXY;
          double denominador = (n * sumatoriasdeXCuadrada) - sumaX2;
          double costoVariableUnitario = numerador/ denominador;


            //DATOS DE COSTO FIJO TOTAL

            //Primer Dato el Producto de sumatoria de Y por sumatoria de las variables x al cuadrado
            double dato1 = CalculoSumatoria(variableY,2) * sumatoriasdeXCuadrada;
            //Segundo Dato producto de sumatoria de X por sumatoria de X por Y
            double dato2 = CalculoSumatoria(variableX,1) * sumatoriaXY;
            //Tercer Dato sumatoria de variables X al cuadrado menos sumatoria de X al cuadrado
            double dato3 = (n* sumatoriasdeXCuadrada )- sumaX2;


            //   **FORMULA DE COSTO FIJO TOTAL**
            double numeradorFijoTotal = dato1 - dato2;
            double costoFijoTotal = numeradorFijoTotal / dato3;
            

            //  Imprimiendo Resultados 
            txtCostoTotal.Text = costoFijoTotal.ToString("0.00");
            txtCostoUnitario.Text = costoVariableUnitario.ToString("0.00");


        }

        private double CalculoSumatoria(double variable,int n)
        {
            variable = 0;
            for (int i = 0; i < lvDatos.Items.Count; i++)
            {
                if (lvDatos.Items[i].SubItems[0].Text != "")
                {
                    variable += double.Parse(lvDatos.Items[i].SubItems[n].Text);
                }

            }

            return variable;
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
