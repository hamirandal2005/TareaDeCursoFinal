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
        List<RegistroEntradas> RegistroentradasList = new List<RegistroEntradas>();
        string Fechaentrada;
        RegistroEntradas oRegistroEntradas = new RegistroEntradas();
       


        //****************************************************************************************

        //Arrays sobre las unidades que se van comprando o utilizando (Cambiar por ArrayList o similar para más eficiencia)
        int UnidadesCompradas;
        int UnidadesUsadas;
        //Variables para almacenar los costos
        double CostoUnitario, UnidadesDisponibles = 0, CostoUnidadesDisponibles = 0, CostoUnidadesCompradas = 0, CostoUnidadesUsadas=0;

        public frmIdentificacionEspecifica()
        {
            InitializeComponent();
        }

        private void btnRegistrarSalidas_Click(object sender, EventArgs e)
        {
            if (ValidaDatos() == "")
            {
                //Validando los cuadro de textos de "Datos Salidas"

                if (txtUnidadesUsadas.Text.Trim().Length == 0)
                    UnidadesUsadas = 0;
                else
                    UnidadesUsadas = int.Parse(txtUnidadesUsadas.Text);


                DateTime FechaSalida = DTPSalida.Value;


                for (int i = 0; i < 100; i++)
                {
                    if (RegistroentradasList[i].FechaEntrada == FechaSalida)
                    {
                        //Una vez comprobadal las fechas...

                        //Se comprueban el número de unidades que vayan a salir
                        if (RegistroentradasList[i].UnidadesCompradas <= UnidadesUsadas)
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


                            //Se presentan los datos...
                            ListViewItem fila = new ListViewItem(FechaSalida.ToShortDateString());
                            fila.SubItems.Add(UnidadesUsadas.ToString());
                            fila.SubItems.Add(RegistroentradasList[i].CostoUnitario.ToString("C"));
                            fila.SubItems.Add(CostoUnidadesUsadas.ToString("C"));
                            lvDatosSalidas.Items.Add(fila);


                            //Actualizar los datos de las Unidades Compradas
                            
                            break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se han registrado materiales en el día que se ha especicifícado", "Registro de Salidas", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        txtUnidadesUsadas.Clear();
                        break;
                    }
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

                //Validando los cuadro de Texto de "Datos Ingresados"
                if (txtUnidadesCompradas.Text.Trim().Length == 0)
                    UnidadesCompradas = 0;
                else
                    UnidadesCompradas = int.Parse(txtUnidadesCompradas.Text);


                if (txtCostoUnitario.Text.Trim().Length == 0)
                    CostoUnitario = 0;
                else
                    CostoUnitario = double.Parse(txtCostoUnitario.Text);


                //Obteniendo los datos de los TextBox

                //Obteniendo las fechas para comparar con las salidas
                DateTime FechaEntrada = DTPEntrada.Value;

                
                        //Haciendo las operaciones correspondientes...
                        //Para obtener las Unidades Disponibles
                        UnidadesDisponibles += (UnidadesCompradas - UnidadesUsadas);
                        //Para obtener el costo total de las unidades Disponibles
                        CostoUnidadesDisponibles += (UnidadesCompradas * CostoUnitario);
                        //Para obtener el costo de la unidades en cada transacción
                        CostoUnidadesCompradas = UnidadesCompradas * CostoUnitario;

                        //Almacenando los datos en la "List"
                        RegistroentradasList.Add(new RegistroEntradas() { FechaEntrada = FechaEntrada, UnidadesCompradas = UnidadesCompradas, CostoUnitario = CostoUnitario });


                        //Presentando los datos de Compras en el lvDatosIngresados
                        ListViewItem fila = new ListViewItem(FechaEntrada.ToShortDateString());
                        fila.SubItems.Add(UnidadesCompradas.ToString());
                        fila.SubItems.Add(CostoUnitario.ToString("C"));
                        fila.SubItems.Add(CostoUnidadesCompradas.ToString("C"));
                        lvDatosIngresados.Items.Add(fila);

                        //Limpiando los cuadros de texto
                        txtCostoUnitario.Clear();
                        txtUnidadesCompradas.Clear();
                        txtUnidadesCompradas.Focus();
                    
                
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
            else if (txtUnidadesUsadas.Text.Trim().Length > 0)
            {
                return "";
            }
            else if ((txtUnidadesCompradas.Text.Trim().Length >= 0) && (txtCostoUnitario.Text.Trim().Length == 0))
            {
                return "No se ha registrado el 'Costo por Unidad'";
            }




            return "";
        }
        private void frmIdentificacionEspecifica_Load(object sender, EventArgs e)
        {

        }



    }
}