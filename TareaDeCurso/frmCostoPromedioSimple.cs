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
            lblCostoMaterialesUsados.Text = "0.00";
            lblInventarioFinal.Text = "0.00";
            lblSaldo.Text = "0.00";

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
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

            //Imprimir Resultados
            
   

 

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
            fecha2 = dtFecha2.Text;
            unidadesUtilizadas = double.Parse(txtUnidadesUtilizadas.Text);
            ListViewItem fila = new ListViewItem(fecha2);
            fila.SubItems.Add(unidadesUtilizadas.ToString("0.00"));
            lvDatos2.Items.Add(fila);
            txtUnidadesUtilizadas.Clear();
        }

       
    }
}
