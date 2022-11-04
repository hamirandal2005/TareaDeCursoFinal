﻿using System;
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
        int num = 1;
        double promedio;
        int unidadesCompradas = 0;
        public frmCostoPromedioPonderado()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (mtbCantidad.Text.Trim().Length != 0 && mtbCosto.Text.Trim().Length != 0)
            {
                if (int.Parse(mtbCantidad.Text) != 0 && int.Parse(mtbCosto.Text) != 0)
                {
                        ponderado.Add(new PromedioPonderado(int.Parse(mtbCantidad.Text), double.Parse(mtbCosto.Text)));
                        ListViewItem a = new ListViewItem(num.ToString());
                        num++;
                        a.SubItems.Add(ponderado.Last().UnidadesCompradas.ToString());
                        a.SubItems.Add(ponderado.Last().PrecioDeCompra.ToString());
                        a.SubItems.Add(ponderado.Last().Calculo(ponderado).ToString("0.00"));
                        promedio = ponderado.Last().Calculo(ponderado);
                        lvPromedio.Items.Add(a);
                        unidadesCompradas += ponderado.Last().UnidadesCompradas;
                }
                else
                    MessageBox.Show("Ingrese un valor mayor a 0", "Notificacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
                MessageBox.Show("Rellene las casillas necesarias", "Notificacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double prom = double.Parse(promedio.ToString("0.00"));
            if (mtbUsadas.Text.Trim().Length != 0)
            {
                lvCostos.Items.Clear();
                String[] costos = new String[3];
                costos[0] = (int.Parse(mtbUsadas.Text) * prom).ToString("0.00");
                costos[1] = ((unidadesCompradas - int.Parse(mtbUsadas.Text)) * prom).ToString("0.00");
                costos[2] = (unidadesCompradas * prom).ToString("0.00");
                ListViewItem info = new ListViewItem(costos);
                lvCostos.Items.Add(info);
            }
            else
            {
                MessageBox.Show("Rellene todos los campos necesarios", "Notificacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mtbUsadas.Focus();
            }


        }
    }
}
