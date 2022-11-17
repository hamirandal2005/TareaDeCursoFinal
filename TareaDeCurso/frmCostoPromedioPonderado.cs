using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Clases;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pjContabilidadMetodosValuacion
{
    public partial class frmCostoPromedioPonderado : Form
    {
        List<PromedioPonderado> ponderado = new List<PromedioPonderado>();
        int num = 0;
        double promedio;
        int unidadesCompradas = 0;
        public frmCostoPromedioPonderado()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    if(int.Parse(mtbCantidad.Text)>0&& double.Parse(mtbCosto.Text) > 0)
                    {
                        ponderado.Add(new PromedioPonderado(int.Parse(mtbCantidad.Text), double.Parse(mtbCosto.Text)));
                        PromedioPonderado[] listview = ponderado.ToArray();
                        ListViewItem a = new ListViewItem(num.ToString());
                        num++;
                        a.SubItems.Add(ponderado.Last().UnidadesCompradas.ToString());
                        a.SubItems.Add(ponderado.Last().PrecioDeCompra.ToString());
                        a.SubItems.Add(ponderado.Last().Calculo(listview).ToString("0.00"));
                        promedio = ponderado.Last().Calculo(listview);
                        lvPromedio.Items.Add(a);
                        unidadesCompradas += ponderado.Last().UnidadesCompradas;
                        mtbCantidad.Clear();
                        mtbCosto.Clear();
                        mtbCantidad.Focus();
                    }
                }catch (OverflowException)
                {
                    MessageBox.Show("Numeros muy Grandes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    mtbCantidad.Clear();
                    mtbCosto.Clear();
                    mtbCantidad.Focus();
                }
               
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese un valor entero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                mtbCantidad.Clear();
                mtbCosto.Clear();
                mtbCantidad.Focus();
            }


        }

        private void btnCalculaar_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    double prom = double.Parse(promedio.ToString("0.00"));
                    if (mtbUsadas.Text.Trim().Length != 0)
                    {
                        lvCostos.Items.Clear();
                        String[] costos = new String[3];
                        costos[0] = (int.Parse(mtbUsadas.Text) * promedio).ToString("0.00");
                        costos[1] = ((unidadesCompradas - int.Parse(mtbUsadas.Text)) * prom).ToString("0.00");
                        costos[2] = (unidadesCompradas * prom).ToString("0.00");
                        ListViewItem info = new ListViewItem(costos);
                        lvCostos.Items.Add(info);
                    }
                    else
                    {
                        MessageBox.Show("Rellene todos los campos necesarios", "Notificacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        mtbUsadas.Clear();
                        mtbUsadas.Focus();
                    }
                }
                catch (OverflowException)
                {
                    MessageBox.Show("Numeros muy Grandes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    mtbUsadas.Clear();
                    mtbUsadas.Focus();
                }
            }catch (FormatException)
            {
                MessageBox.Show("Ingrese un valor entero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                mtbUsadas.Clear();
                mtbUsadas.Focus();
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
