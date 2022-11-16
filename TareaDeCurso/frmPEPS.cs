using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clases;
using System.Collections;

namespace pjContabilidadMetodosValuacion
{
    public partial class frmPEPS : Form
    {
        List<MatEntradaSalida> Entrada = new List<MatEntradaSalida>();
        List<MatEntradaSalida> Salida = new List<MatEntradaSalida>();
        int suma = 0;
        public frmPEPS()
        {
            InitializeComponent();
        }

        private void btnRegistrarCompras_Click(object sender, EventArgs e)
        {
            bool confirmacion = true;
            try
            {
                if (int.Parse(txtUnidades.Text) > 0 && double.Parse(txtCosto.Text) > 0)
                {
                    try
                    {
                        for (int i = 0; i < Entrada.Count; i++)
                        {
                            if (Entrada[i].Fecha.ToShortDateString() == dtFechaCompras.Value.ToShortDateString() && Entrada[i].CostoUnitario == double.Parse(txtCosto.Text))
                            {
                                Entrada[i].UnidadesCompradas += int.Parse(txtUnidades.Text);
                                suma += int.Parse(txtUnidades.Text);
                                Entrada.Sort();
                                confirmacion = false;
                                ActualizarTablaEntrada();
                            }
                        }
                        if (confirmacion)
                        {
                            Entrada.Add(new MatEntradaSalida(dtFechaCompras.Value, int.Parse(txtUnidades.Text), double.Parse(txtCosto.Text)));
                            suma += int.Parse(txtUnidades.Text);
                            Entrada.Sort();
                            ActualizarTablaEntrada();
                        }
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Rellene las casillas requeridas", "Notificacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese un valor mayor a 0", "Notificacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;

                }
                dtFechaCompras.ResetText();
                txtUnidades.Clear();
                txtCosto.Clear();
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese un valor entero", "Notificacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        private void btnRegistrarUtilizadas_Click(object sender, EventArgs e)
        {
            int utilizadas = 0;
            try
            {
                utilizadas = int.Parse(txtUnidadesUtilizadas.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese un valor entero", "Notificacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (utilizadas <= 0)
            {
                MessageBox.Show("Ingrese un valor mayor a 0", "Notificacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                if (suma >= utilizadas)
                {
                    for (int i = 100; i != 0; i++)
                    {
                        if (Entrada.Count > 0)
                        {
                            if (Entrada.First().UnidadesCompradas > utilizadas)
                            {
                                Salida.Add(new MatEntradaSalida(DateTime.Parse(dtFechaUtilizadas.Text), utilizadas));
                                Entrada.First().UnidadesCompradas -= utilizadas;
                                suma -= utilizadas;
                                Salida.Last().CostoUnitario = Entrada.First().CostoUnitario;
                                utilizadas = 0;
                                i = -1;
                            }
                            else if (Entrada.First().UnidadesCompradas <= utilizadas)
                            {
                                for (int j = 100; j != 0; j++)
                                {
                                    Salida.Add(new MatEntradaSalida(DateTime.Parse(dtFechaUtilizadas.Text), utilizadas));
                                    if (utilizadas < Entrada.First().UnidadesCompradas)
                                    {
                                        Entrada.First().UnidadesCompradas -= utilizadas;
                                        suma -= utilizadas;
                                        Salida.Last().CostoUnitario = Entrada.First().CostoUnitario;
                                        utilizadas = 0;
                                    }
                                    else
                                    {
                                        Salida.Last().CostoUnitario = Entrada.First().CostoUnitario;
                                        utilizadas -= Entrada.First().UnidadesCompradas;
                                        Salida.Last().UnidadesUtilizadas -= utilizadas;
                                        suma -= Salida.Last().UnidadesUtilizadas;
                                        Entrada.RemoveAt(0);
                                    }

                                    if (utilizadas == 0)
                                    {
                                        i = -1;
                                        j = -1;
                                    }
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("No cuenta con las unidades requeridas, solo tiene: " + suma, "Notificacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                    }
                }
                else
                {
                    MessageBox.Show("No cuenta con las unidades requeridas, solo tiene: " + suma, "Notificacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                Salida.Sort();
                lvUnidadesUtilizadas.Items.Clear();
                ActualizarTablaSalida();
                ActualizarTablaEntrada();
                dtFechaUtilizadas.ResetText();
                txtUnidadesUtilizadas.Clear();
            }
            //Incompleto

        }

        public void ActualizarTablaEntrada()
        {
            lvUnidadesCompradas.Items.Clear();
            foreach (MatEntradaSalida elemento in Entrada)
            {
                ListViewItem compradas = new ListViewItem(elemento.Fecha.ToShortDateString());
                compradas.SubItems.Add(elemento.UnidadesCompradas.ToString());
                compradas.SubItems.Add(elemento.CostoUnitario.ToString("0.00"));
                lvUnidadesCompradas.Items.Add(compradas);
            }
        }
        public void ActualizarTablaSalida()
        {
            foreach (MatEntradaSalida elemento in Salida)
            {
                ListViewItem info = new ListViewItem(elemento.Fecha.ToShortDateString());
                info.SubItems.Add(elemento.UnidadesUtilizadas.ToString());
                info.SubItems.Add(elemento.CostoUnitario.ToString("0.00"));
                lvUnidadesUtilizadas.Items.Add(info);
            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            double costoInvFinal = 0;
            double costoSalidas = 0;
            int unidades = 0;
            gbDatosIngresados.Text = "Inventario Final";
            gbCompras.Enabled = false;
            gbSalidas.Enabled = false;
            foreach(MatEntradaSalida elemento in Entrada)
            {
                costoInvFinal += elemento.UnidadesCompradas * elemento.CostoUnitario;
                unidades += elemento.UnidadesCompradas;
            }
            lblInvFinal.Text = costoInvFinal.ToString("C"); 
            foreach (MatEntradaSalida elemento in Salida)
            {
                costoSalidas += elemento.UnidadesUtilizadas * elemento.CostoUnitario;
                unidades += elemento.UnidadesUtilizadas;
            }
            lblMatUtilizados.Text = costoSalidas.ToString("C");
            lblCostoPeriodo.Text = (costoInvFinal + costoSalidas).ToString("C");
            lblUnidadesCompradas.Text = unidades.ToString();

            gbTotales.Visible = true;
            pTotales.Visible = true;
        }

      
    }
}
