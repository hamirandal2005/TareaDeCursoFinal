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
        double CostoUnitario, CostoUnidadesCompradas = 0, CostoUnidadesUsadas=0, CostoUnitarioSalida=0;
        double UnidadesDisponibles=0, CostoUnidadesDisponibles=0;
        int C = 0;
        public frmIdentificacionEspecifica()
        {
            InitializeComponent();
        }

        private void btnRegistrarSalidas_Click(object sender, EventArgs e)
        { 
            if (ValidaDatos() == "")
            {
                //Validando los cuadro de textos de "Datos Salidas"

                    UnidadesUsadas = int.Parse(txtUnidadesUsadas.Text);
                    CostoUnitarioSalida=double.Parse(txtCostoUnitarioSalida.Text); 

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
                                    CostoUnidadesUsadas = RegistroentradasList[i].CostoUnitario * UnidadesUsadas;

                                    RegistrosalidasList.Add(new RegistroTransacciones() { FechaSale=FechaTransaccion, Fecha = FechaSalida, UnidadesUsadas = UnidadesUsadas, CostoUnitario = RegistroentradasList[i].CostoUnitario });

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
                MessageBox.Show(ValidaDatos(), "¡Error!");
            }
        }


        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (ValidaDatos() == "")
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

                for(int i=0; i < RegistroentradasList.Count; i++)
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
                MessageBox.Show(ValidaDatos(), "¡Error!");
            }

        }

        private string ValidaDatos()
        {
            if ((txtUnidadesCompradas.Text.Trim().Length == 0) && (txtUnidadesUsadas.Text.Trim().Length == 0))
            {
                return "No se han registrado Unidades, ni de entradas y/o salidas";
            }
            else if (txtUnidadesUsadas.Text.Trim().Length > 0 && txtCostoUnitarioSalida.Text.Trim().Length == 0)
            {
                return "No se ha registrado el costo unitario al que se desea que salgan las unidades";
            }
            else if ((txtUnidadesCompradas.Text.Trim().Length > 0) && (txtCostoUnitario.Text.Trim().Length == 0))
            {
                return "No se ha registrado el 'Costo por Unidad'";
            }
            return "";
        }


        private void txtUnidadesCompradas_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarCajasTexto(e);
        }
        private void txtCostoUnitario_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarCajasTextoCosto(e);
        }

        private void txtUnidadesUsadas_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarCajasTexto(e);
        }

        private void txtCostoUnitarioSalida_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarCajasTextoCosto(e);
        }

        private void ValidarCajasTextoCosto(KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar == 47) || (e.KeyChar >= 58 && e.KeyChar <= 255)) {
                MessageBox.Show("¡Solo son permitidos números positivos!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;
                return;
            }
        }

        private void btnFinalizarPeriodo_Click(object sender, EventArgs e)
        {

        }

        private void ValidarCajasTexto(KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("¡Solo son permitidos números enteros y positivos!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;
                return;
            }
        }
        private void frmIdentificacionEspecifica_Load(object sender, EventArgs e)
        {

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