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
}
