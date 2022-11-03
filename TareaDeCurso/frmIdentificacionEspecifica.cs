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



namespace pjContabilidadMetodosValuacion
{
    public partial class frmIdentificacionEspecifica : Form
    {
        //Declaración de Variables Globalmente

        //Arrays sobre las unidades que se van comprando o utilizando (Cambiar por ArrayList o similar para más eficiencia)
        double[] UnidadesCompradas = new double[100];
        double[] UnidadesUsadas = new double[100];
        //Contadores para los arrays
        int ContadorUnidadesCompradas = 0, ContadorUnidadesSalidas = 0;
        //Variables para almacenar los costos
        double CostoUnitario, UnidadesDisponibles = 0, CostoUnidadesDisponibles = 0, CostoUnidadesCompradas = 0, CostoUnidadesUsadas;
        //Contadores Secundarios
        int i = 0, ContadorTransaccionesEntrada = 0, FechasEntradasCont = 0, FechasSalidasCont=0;

        //Arrays que contengan las fechas de entradas y salidas
        DateTime[] FechasEntradas = new DateTime[100];
        DateTime[] FechasSalidas = new DateTime[100];
        //Creación de una HashTable para guardar...
        //"Fechas de Compra" como -Key-
        //"Unidades Compradas" como -Value-
        Hashtable UnidadesCompradasHash = new Hashtable();

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
                    UnidadesUsadas[ContadorUnidadesSalidas] = 0;
                else
                    UnidadesUsadas[ContadorUnidadesSalidas] = double.Parse(txtUnidadesUsadas.Text);


                DateTime FechaSalida = DTPSalida.Value;
                FechaSalida.ToShortDateString();
                FechasSalidas[FechasSalidasCont] = FechaSalida;


                //Operaciones correspondientes

                //Costo total de unidades usadas, se deberá usar el Hashtable
                //Se recorre el Hastable
                foreach (DictionaryEntry UnidadesHashTable in UnidadesCompradasHash)
                {
                    if (FechasSalidas[i].ToShortDateString() == UnidadesHashTable.Key)
                    {
                        //Se hace el cálculo
                        CostoUnidadesUsadas = UnidadesUsadas[ContadorUnidadesSalidas] * ((double)UnidadesHashTable.Value);
                        ListViewItem fila = new ListViewItem(FechasSalidas[FechasSalidasCont].ToShortDateString());
                    }
                    else
                        MessageBox.Show("No se han registrado unidades en ese día");
                    i++;
                }

                
                FechasSalidasCont++;
                ContadorUnidadesSalidas++;
            }
        }


        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (ValidaDatos() == "")
            {
                
                /*if (txtUnidadesUsadas.Text.Trim().Length == 0)
                    UnidadesUsadas[ContadorUnidadesSalidas] = 0;
                else
                    UnidadesUsadas[ContadorUnidadesSalidas] = double.Parse(txtUnidadesUsadas.Text);
                */

                //Validando los cuadro de Texto de "Datos Ingresados"
                if (txtUnidadesCompradas.Text.Trim().Length == 0)
                    UnidadesCompradas[ContadorUnidadesCompradas] = 0;
                else
                    UnidadesCompradas[ContadorUnidadesCompradas] = double.Parse(txtUnidadesCompradas.Text);



                if (txtCostoUnitario.Text.Trim().Length == 0)
                    CostoUnitario = 0;
                else
                    CostoUnitario = double.Parse(txtCostoUnitario.Text);


                //Obteniendo los datos de los TextBox

                //Obteniendo las fechas para comparar con las salidas
                DateTime FechaEntrada = DTPEntrada.Value;
                FechaEntrada.ToShortDateString();
                FechasEntradas[FechasEntradasCont] = FechaEntrada;
                




                //Haciendo las operaciones correspondientes...
                //Para obtener las Unidades Disponibles
                UnidadesDisponibles += (UnidadesCompradas[ContadorUnidadesCompradas] - UnidadesUsadas[ContadorUnidadesSalidas]);
                //Para obtener el costo total de las unidades Disponibles
                CostoUnidadesDisponibles += (UnidadesCompradas[ContadorUnidadesCompradas] * CostoUnitario);
                //Para obtener el costo de la unidades en cada transacción
                CostoUnidadesCompradas = UnidadesCompradas[ContadorUnidadesCompradas] * CostoUnitario;




                //Almacenando las transacciones de compras en una HashTablef
                UnidadesCompradasHash.Add(FechasEntradas[ContadorTransaccionesEntrada].ToShortDateString(), UnidadesCompradas[ContadorTransaccionesEntrada]);




                //Presentando los datos de Compras en el lvDatosIngresados
                ListViewItem fila = new ListViewItem(FechasEntradas[FechasEntradasCont].ToShortDateString());
                fila.SubItems.Add(UnidadesCompradas[ContadorUnidadesCompradas].ToString());
                fila.SubItems.Add(CostoUnitario.ToString("C"));
                fila.SubItems.Add(CostoUnidadesCompradas.ToString("C"));
                lvDatosIngresados.Items.Add(fila);



                //Limpiando los cuadros de texto
                txtCostoUnitario.Clear();
                txtUnidadesCompradas.Clear();
                txtUnidadesCompradas.Focus();



                ContadorUnidadesCompradas++;
                ContadorUnidadesSalidas++;
                ContadorTransaccionesEntrada++;
                FechasEntradasCont++;
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