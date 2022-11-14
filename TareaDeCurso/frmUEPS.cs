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
    }

    private string ValidaDatos()
    {
        if ((txtCompras.Text.Trim().Length == 0) && (txtUsadas.Text.Trim().Length == 0))
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
}
