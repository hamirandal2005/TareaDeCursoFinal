using Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clases;
using System.Linq.Expressions;

namespace pjContabilidadMetodosValuacion
{
    public partial class frmUEPS : Form
    {
        Stack<MatEntradaSalida> Compradas = new Stack<MatEntradaSalida>();
        Stack<MatEntradaSalida> Usadas = new Stack<MatEntradaSalida>();
        int UnidadesTotales = 0;
        double CostoUnidadesCompradas = 0, CostoUnidadesUsadas = 0;
        public frmUEPS()
        {
            InitializeComponent();
        }
        private void btnRegistrarCompras_Click(object sender, EventArgs e)
        {
            bool Confirmacion = true;
                try
                {
                    if(int.Parse(txtCompras.Text) > 0 && double.Parse(txtCostoCompras.Text) > 0)
                    {
                        foreach (MatEntradaSalida Check in Compradas)
                        {
                            if (Check.CostoUnitario == double.Parse(txtCostoCompras.Text))
                            {
                            Check.UnidadesCompradas += int.Parse(txtCompras.Text);
                            UnidadesTotales += int.Parse(txtCompras.Text);
                            Confirmacion = false;
                            ActualizarCompras();
                            }
                        }

                        if (Confirmacion)
                        {
                        Compradas.Push(new MatEntradaSalida(DTPCompras.Value, int.Parse(txtCompras.Text), double.Parse(txtCostoCompras.Text)));
                        UnidadesTotales += int.Parse(txtCompras.Text);
                        ActualizarCompras();
                        }

                    CostoUnidadesCompradas += (int.Parse(txtCompras.Text) * double.Parse(txtCostoCompras.Text));
                        txtCompras.Clear();
                        txtCostoCompras.Clear();
                    }else
                        MessageBox.Show("Los datos no pueden ser negativos", "¡Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Ingrese las unidades y su costo en un formato valido", "¡Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
        }
        private void btnRegistrarUsadas_Click(object sender, EventArgs e)
        {
            int usadas = 0, temporalU=0, RegistroUsadas=0;
                try
                {
                    usadas = int.Parse(txtUsadas.Text);
                    if(usadas > 0)
                    {
                        temporalU = int.Parse(txtUsadas.Text);
                        if (usadas <= UnidadesTotales)
                        {
                            UnidadesTotales -= usadas;
                                
                            if (usadas <= Compradas.Peek().UnidadesCompradas)
                            {
                                if (usadas == Compradas.Peek().UnidadesCompradas)
                                {
                                    Usadas.Push(new MatEntradaSalida(DTPUsadas.Value, int.Parse(txtUsadas.Text), Compradas.Peek().CostoUnitario));
                                CostoUnidadesUsadas = (int.Parse(txtUsadas.Text) * Compradas.Peek().CostoUnitario);
                                    Compradas.Pop();
                                    usadas -= int.Parse(txtUsadas.Text);
                                }
                                else if (usadas < Compradas.Peek().UnidadesCompradas)
                                {
                                Usadas.Push(new MatEntradaSalida(DTPUsadas.Value, int.Parse(txtUsadas.Text), Compradas.Peek().CostoUnitario));
                                CostoUnidadesUsadas = (int.Parse(txtUsadas.Text) * Compradas.Peek().CostoUnitario);
                                Compradas.Peek().UnidadesCompradas -= usadas;
                                }
                                ActualizarCompras();
                                ActualizarUsadas();
                                txtUsadas.Clear();

                            }
                            else if (usadas > Compradas.Peek().UnidadesCompradas)
                            {
                                while (usadas > 0)
                                {
                                    RegistroUsadas = Compradas.Peek().UnidadesCompradas;
                                    usadas -= Compradas.Peek().UnidadesCompradas;
                                    Compradas.Peek().UnidadesCompradas -= temporalU;
                                    if (Compradas.Peek().UnidadesCompradas <= 0)
                                    {
                                        Usadas.Push(new MatEntradaSalida(DTPUsadas.Value, RegistroUsadas, Compradas.Peek().CostoUnitario));
                                    CostoUnidadesUsadas = (int.Parse(txtUsadas.Text) * Compradas.Peek().CostoUnitario);
                                    Compradas.Pop();
                                    }
                                else
                                {
                                    Usadas.Push(new MatEntradaSalida(DTPUsadas.Value, temporalU, Compradas.Peek().CostoUnitario));
                                    CostoUnidadesUsadas = (int.Parse(txtUsadas.Text) * Compradas.Peek().CostoUnitario);
                                }

                                temporalU = usadas;
                                }
                                    ActualizarCompras();
                                    ActualizarUsadas();
                                    txtUsadas.Clear();
                            }
                        }
                        else
                            MessageBox.Show("¡No hay unidades suficientes!", "¡Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("¡Debe ser un valor entero y positivos!", "¡Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch(FormatException)
                {
                    MessageBox.Show("Ingrese las unidades en un formato valido", "¡Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
        }

        public void ActualizarCompras()
        {
            lvUnidadesCompradas.Items.Clear();
            foreach (MatEntradaSalida Refresh in Compradas)
            {
                ListViewItem Entradas = new ListViewItem(Refresh.Fecha.ToShortDateString());
                Entradas.SubItems.Add(Refresh.UnidadesCompradas.ToString());
                Entradas.SubItems.Add(Refresh.CostoUnitario.ToString("C"));
                Entradas.SubItems.Add((Refresh.UnidadesCompradas * Refresh.CostoUnitario).ToString("C"));
                lvUnidadesCompradas.Items.Add(Entradas);
            }
        }
        public void ActualizarUsadas()
        {
            lvUnidadesUsadas.Items.Clear();
            foreach (MatEntradaSalida Refresh in Usadas)
            {
                ListViewItem Usadas = new ListViewItem(Refresh.Fecha.ToShortDateString());
                Usadas.SubItems.Add(Refresh.UnidadesCompradas.ToString());
                Usadas.SubItems.Add(Refresh.CostoUnitario.ToString("C"));
                Usadas.SubItems.Add((Refresh.UnidadesCompradas * Refresh.CostoUnitario).ToString("C"));
                lvUnidadesUsadas.Items.Add(Usadas);
            }
        }

        private void btnMenú_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Hide();
            frmPrincipal Menu = new frmPrincipal();
            Menu.ShowDialog();
        }

        private void btnFinalizarPeriodo_Click(object sender, EventArgs e)
        {
            gpFinalizarPeriodo.Visible = true;
            lblCostoTotalCompra.Text = CostoUnidadesCompradas.ToString("C");
            lblCostoMaterialesUsados.Text= CostoUnidadesUsadas.ToString("C");
            lblInventarioFinal.Text = (CostoUnidadesCompradas - CostoUnidadesUsadas).ToString("C");
        }
    }
}
