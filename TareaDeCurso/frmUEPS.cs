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

namespace pjContabilidadMetodosValuacion
{
    public partial class frmUEPS : Form
    {
        Stack<MatEntradaSalida> Compradas = new Stack<MatEntradaSalida>();
        Stack<MatEntradaSalida> Usadas = new Stack<MatEntradaSalida>();
        int UnidadesTotales = 0;
        public frmUEPS()
        {
            InitializeComponent();
        }
        private void btnRegistrarCompras_Click(object sender, EventArgs e)
        {
            bool Confirmacion = true;
            if (ValidaDatos() == "")
            {
                foreach(MatEntradaSalida Check in Compradas)
                {
                    if(Check.CostoUnitario == double.Parse(txtCostoCompras.Text))
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

                txtCompras.Clear();
                txtCostoCompras.Clear();
            }
            else
                MessageBox.Show(ValidaDatos(), "¡Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnRegistrarUsadas_Click(object sender, EventArgs e)
        {
            int usadas = 0, temporalU=0;
            if (ValidaDatos() == "")
            {
                usadas = int.Parse(txtUsadas.Text);
                temporalU = int.Parse(txtUsadas.Text);
                if (usadas <= UnidadesTotales)
                {
                    if (usadas <= Compradas.Peek().UnidadesCompradas)
                    {
                        Usadas.Push(new MatEntradaSalida(DTPUsadas.Value, int.Parse(txtUsadas.Text), Compradas.Peek().CostoUnitario));
                        Compradas.Pop();
                        usadas -= int.Parse(txtUsadas.Text);
                        UnidadesTotales -= usadas;
                        ActualizarCompras();
                        ActualizarUsadas();
                        txtUsadas.Clear();

                    }else if(usadas > Compradas.Peek().UnidadesCompradas)
                    {
                        while(usadas > 0)
                        {
                            Compradas.Peek().UnidadesCompradas -= usadas;
                            UnidadesTotales -= usadas;
                            Usadas.Push(new MatEntradaSalida(DTPUsadas.Value, int.Parse(txtUsadas.Text), Compradas.Peek().CostoUnitario));
                            usadas -= Compradas.Peek().UnidadesCompradas;
                            if (Compradas.Peek().UnidadesCompradas <= 0)
                            {
                                Compradas.Pop();
                            }
                        }
                        UnidadesTotales -= usadas;
                        ActualizarCompras();
                        ActualizarUsadas();
                    }
                }
                else
                    MessageBox.Show("¡No hay unidades suficientes!", "¡Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }else
                MessageBox.Show(ValidaDatos(), "¡Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private string ValidaDatos()
        {
            if ((txtCompras.Text.Trim().Length == 0) && (txtUsadas.Text.Trim().Length == 0))
            {
                return "No se han registrado Unidades, ni de entradas y/o salidas";
            }
            else if (txtCompras.Text.Trim().Length > 0 && txtCostoCompras.Text.Trim().Length == 0)
            {
                return "No se ha registrado el costo unitario";
            } 
            return "";
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
        private void ValidarCajasTextoCosto(KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar == 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("¡Solo son permitidos números positivos!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;
                return;
            }
        }
        private void ValidarCajasTexto(KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("¡Solo son permitidos números enteros!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;
                return;
            }
        }

        private void txtCostoCompras_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarCajasTextoCosto(e);
        }

        private void txtCompras_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarCajasTexto(e);
        }

        private void txtUsadas_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarCajasTexto(e);
        }
    }
}
