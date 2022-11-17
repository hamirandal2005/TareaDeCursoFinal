using System;
using System.Collections;
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
    public partial class frmIdentificacionEspecifica : Form
    {
        //Declaración de Variables Globalmente

        //Haciendo uso de nuevos métodos para llevar a cabo el ejercicio

        //Creación de una "List" para guardar los datos de la clase
        List<RegistroTransacciones> RegistroentradasList = new();
        List<RegistroTransacciones> RegistrosalidasList = new();

        //****************************************************************************************
        int UnidadesCompradas;
        int UnidadesUsadas;
        //Variables para almacenar los costos
        double CostoUnitario, CostoUnidadesCompradas = 0, CostoUnitarioSalida = 0, CostoUnidadesUsadas;
        double UnidadesDisponibles=0, CostoUnidadesDisponibles=0;
        int C = 0;
        public frmIdentificacionEspecifica()
        {
            InitializeComponent();
        }

        private void btnFinalizarPeriodo_Click(object sender, EventArgs e)
        {
            gbResultados.Visible = true;
            lblCostoCompradas.Text = CostoUnidadesDisponibles.ToString("C");
            lblCostoUsadas.Text = CostoUnidadesUsadas.ToString("C");
            lblInventarioFinal.Text = (CostoUnidadesDisponibles - CostoUnidadesUsadas).ToString("C");
        }

        private void btnRegistrarSalidas_Click(object sender, EventArgs e)
        { 
                try
                {
                    try
                    {
                        if (int.Parse(txtUnidadesUsadas.Text) > 0 && double.Parse(txtCostoUnitarioSalida.Text) > 0)
                        {
                            //Validando los cuadro de textos de "Datos Salidas"

                            UnidadesUsadas = int.Parse(txtUnidadesUsadas.Text);
                            CostoUnitarioSalida = double.Parse(txtCostoUnitarioSalida.Text);

                            DateTime FechaSalida = DTPSalida.Value;
                            DateTime FechaTransaccion = DTP.Value;

                            if (RegistroentradasList.Count > 0)
                            {

                                for (int i = 0; i < RegistroentradasList.Count; i++)
                                {
                                    if (RegistroentradasList[i].Fecha.ToShortDateString().Equals(FechaSalida.ToShortDateString()))
                                    {
                                        //Una vez comprobadal las fechas...
                                        if (RegistroentradasList[i].CostoUnitario.ToString().Equals(CostoUnitarioSalida.ToString()))
                                        {
                                            //Se comprueban el número de unidades que vayan a salir
                                            if (RegistroentradasList[i].UnidadesCompradas < UnidadesUsadas)
                                            {
                                                MessageBox.Show("No hay suficientes unidades compradas ese día para que se usen lo estipulado", "Registro de Salidas", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                                txtUnidadesUsadas.Clear();
                                                break;
                                            }
                                            else
                                            {
                                                //Se restan las unidades salientes
                                                RegistroentradasList[i].UnidadesCompradas = RegistroentradasList[i].UnidadesCompradas - UnidadesUsadas;

                                                //Costo Total de las unidades utilizadas
                                                CostoUnidadesUsadas += RegistroentradasList[i].CostoUnitario * UnidadesUsadas;

                                                RegistrosalidasList.Add(new RegistroTransacciones() { FechaSale = FechaTransaccion, Fecha = FechaSalida, UnidadesUsadas = UnidadesUsadas, CostoUnitario = RegistroentradasList[i].CostoUnitario });

                                                if (RegistroentradasList[i].UnidadesCompradas == 0)
                                                {
                                                    RegistroentradasList.RemoveAt(i);
                                                }
                                                //Se presentan los datos...
                                                ActualizarDatosSalidas();
                                                ActualizarDatosEntradas();

                                                //Limpiar los cuadros de Texto
                                                txtUnidadesUsadas.Clear();
                                                txtCostoUnitarioSalida.Clear();

                                                break;
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Ese día no se compraron unidades al costo de - " + CostoUnitarioSalida + "C$ -", "Registro de Salidas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            txtCostoUnitarioSalida.Clear();
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("No se han registrado materiales en el día que se ha especicifícado", "Registro de Salidas", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                        txtUnidadesUsadas.Clear();
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Aún no se han registrado unidades", "Registro de Salidas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                txtUnidadesUsadas.Clear();
                                txtCostoUnitarioSalida.Clear();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Solo puedes ingresar números mayores que 0", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtUnidadesUsadas.Clear();
                            txtCostoUnitarioSalida.Clear();
                            return;
                        }
                    }
                    catch(OverflowException)
                    {
                        MessageBox.Show("Números demasiado grandes", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtUnidadesUsadas.Clear();
                        txtCostoUnitarioSalida.Clear();
                        return;
                    }
                }
                catch(FormatException)
                {
                    MessageBox.Show("Ingrese las unidades y su costo en un formato valido", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
        }


        private void btnRegistrar_Click(object sender, EventArgs e)
        {
                try
                {
                    try
                    {
                        if (int.Parse(txtUnidadesCompradas.Text) > 0 && double.Parse(txtCostoUnitario.Text) > 0)
                            {
                                UnidadesCompradas = int.Parse(txtUnidadesCompradas.Text);
                                CostoUnitario = double.Parse(txtCostoUnitario.Text);


                                //Obteniendo los datos de los TextBox

                                //Obteniendo las fechas para comparar con las salidas
                                DateTime FechaEntrada = DTPEntrada.Value;

                                //Haciendo las operaciones correspondientes...
                                //Para obtener las Unidades Disponibles
                                UnidadesDisponibles += (UnidadesCompradas - UnidadesUsadas);
                                //Para obtener el costo total de las unidades Disponibles
                                CostoUnidadesDisponibles += (UnidadesCompradas * CostoUnitario);
                                //Para obtener el costo de las unidades compradas
                                CostoUnidadesCompradas = UnidadesCompradas * CostoUnitario;

                                for (int i = 0; i < RegistroentradasList.Count; i++)
                                {
                                    if (CostoUnitario.ToString().Equals(RegistroentradasList[i].CostoUnitario.ToString()))
                                    {
                                        UnidadesCompradas += RegistroentradasList[i].UnidadesCompradas;

                                        RegistroentradasList.RemoveAt(i);
                                        break;
                                    }
                                }
                                //Almacenando los datos en la "List

                                RegistroentradasList.Add(new RegistroTransacciones()
                                {
                                    Fecha = FechaEntrada,
                                    UnidadesCompradas = UnidadesCompradas,
                                    CostoUnitario = CostoUnitario,
                                    CostoUnidadesCompradas = CostoUnidadesCompradas
                                });

                                //Presentando los datos en el ListView
                                ActualizarDatosEntradas();

                                //Limpiando los cuadros de texto
                                txtCostoUnitario.Clear();
                                txtUnidadesCompradas.Clear();
                                txtUnidadesCompradas.Focus();

                                C++;
                        }
                            else
                            {
                                MessageBox.Show("Solo puedes ingresar números mayores que 0", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtUnidadesCompradas.Clear();
                                txtCostoUnitario.Clear();
                            }
                        
                    }
                    catch (OverflowException)
                    {
                        MessageBox.Show("Números demasiado grandes", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtCostoUnitario.Clear();
                        txtUnidadesCompradas.Clear();
                        return;
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Ingrese las unidades y el costo al que desea que se usen en un formato valido", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCostoUnitario.Clear();
                    txtUnidadesCompradas.Clear();
                    return;
                }
        }

        public void ActualizarDatosEntradas()
        {
            lvDatosIngresados.Items.Clear();
            foreach(RegistroTransacciones Refresh in RegistroentradasList)
            {
                ListViewItem Entradas = new ListViewItem(Refresh.Fecha.ToShortDateString());
                Entradas.SubItems.Add(Refresh.UnidadesCompradas.ToString());
                Entradas.SubItems.Add(Refresh.CostoUnitario.ToString("C"));
                Entradas.SubItems.Add((Refresh.UnidadesCompradas * Refresh.CostoUnitario).ToString("C"));
                lvDatosIngresados.Items.Add(Entradas);  
            }
        }

        public void ActualizarDatosSalidas()
        {
            lvDatosSalidas.Items.Clear();
            foreach (RegistroTransacciones Refresh in RegistrosalidasList)
            {
                ListViewItem Salidas = new ListViewItem(Refresh.FechaSale.ToShortDateString());
                Salidas.SubItems.Add(Refresh.UnidadesUsadas.ToString());
                Salidas.SubItems.Add(Refresh.Fecha.ToShortDateString());
                Salidas.SubItems.Add(Refresh.CostoUnitario.ToString("C"));
                Salidas.SubItems.Add((Refresh.UnidadesUsadas * Refresh.CostoUnitario).ToString("C"));
                lvDatosSalidas.Items.Add(Salidas);
            }
        }
    }
}