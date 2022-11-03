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
        double[] UnidadesCompradas = new double[100];
        double[] UnidadesUsadas = new double[100];
        int ContadorUnidadesCompradas = 0, ContadorUnidadesSalidas = 0, ContadorHashTable = 0;
        double CostoUnitario, UnidadesDisponibles = 0, CostoUnidadesDisponibles = 0, CostoUnidades = 0;
        int ContadorTransaccionesEntrada = 0, FechasEntradasCont = 0;



        DateTime[] FechasEntradas = new DateTime[100];



        //Creación de una HashTable para guardar...
        //"Fechas de Compra" como -Key-
        //"Unidades Compradas" como -Value-
        Hashtable UnidadesCompradasHash = new Hashtable();








        public frmIdentificacionEspecifica()
        {
            InitializeComponent();

        }



        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {



        }



        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (ValidaDatosEntrada() == "")
            {
                //Validando los cuadro de Texto de "Datos Ingresados"
                if (txtUnidadesUsadas.Text.Trim().Length == 0)
                    UnidadesUsadas[ContadorUnidadesSalidas] = 0;
                else
                    UnidadesUsadas[ContadorUnidadesSalidas] = double.Parse(txtUnidadesUsadas.Text);



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
                FechasEntradasCont++;




                //Haciendo las operaciones correspondientes...
                //Para obtener las Unidades Disponibles
                UnidadesDisponibles += (UnidadesCompradas[ContadorUnidadesCompradas] - UnidadesUsadas[ContadorUnidadesSalidas]);
                //Para obtener el costo total de las unidades Disponibles
                CostoUnidadesDisponibles += (UnidadesCompradas[ContadorUnidadesCompradas] * CostoUnitario);
                //Para obtener el costo de la unidades en cada transacción
                CostoUnidades = UnidadesCompradas[ContadorUnidadesCompradas] * CostoUnitario;




                //Almacenando las transacciones de compras en una HashTable
                UnidadesCompradasHash.Add(FechasEntradas[ContadorTransaccionesEntrada], UnidadesCompradas[ContadorTransaccionesEntrada]);




                //Presentando los datos de Compras en el lvDatosIngresados
                ListViewItem fila = new ListViewItem(FechaEntrada.ToString());
                fila.SubItems.Add(UnidadesCompradas[ContadorUnidadesCompradas].ToString());
                fila.SubItems.Add(CostoUnitario.ToString("C"));
                fila.SubItems.Add(CostoUnidades.ToString("C"));
                lvDatosIngresados.Items.Add(fila);



                //Limpiando los cuadros de texto
                txtCostoUnitario.Clear();
                txtUnidadesCompradas.Clear();
                txtUnidadesCompradas.Focus();



                ContadorUnidadesCompradas++;
                ContadorUnidadesSalidas++;
                ContadorTransaccionesEntrada++;
            }
            else
            {
                MessageBox.Show(ValidaDatosEntrada(), "¡Error!");
            }
        }



        private string ValidaDatosEntrada()
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



        private string ValidaDatosSalida()
        {
            if ((txtUnidadesCompradas.Text.Trim().Length == 0) && (txtUnidadesUsadas.Text.Trim().Length == 0))
            {
                return "No se han registrado Unidades, ni de entrada y/o salida";
            }
            else if (txtUnidadesUsadas.Text.Trim().Length > 0)
            {
                return ";";
            }
            return ";";
        }



        private void frmIdentificacionEspecifica_Load(object sender, EventArgs e)
        {

        }



    }
}