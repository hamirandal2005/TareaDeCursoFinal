namespace pjContabilidadMetodosValuacion
{
    public partial class frmPrincipal : Form
    {
        frmMétodoEstadístico formularioMetodoEstadistico;
        frmCostoPromedioSimple formularioValuacionPromedioSimple;
        frmMetodoPuntoAltoBajo formularioPuntoAltoBajo;
        frmPEPS formularioPEPS;
        frmUEPS formularioUEPS;
        frmIdentificacionEspecifica formularioIdentificacionEspecifica;
        frmCostoPromedioPonderado formularioPonderado;




        public frmPrincipal()
        {
            InitializeComponent();
            formularioMetodoEstadistico = new frmMétodoEstadístico();
            formularioValuacionPromedioSimple = new frmCostoPromedioSimple();
            formularioPuntoAltoBajo = new frmMetodoPuntoAltoBajo();
            formularioPEPS = new frmPEPS();
            formularioUEPS = new frmUEPS();
            formularioIdentificacionEspecifica = new frmIdentificacionEspecifica();
            formularioPonderado = new frmCostoPromedioPonderado();
            formularioIdentificacionEspecifica = new frmIdentificacionEspecifica();
            formularioPonderado = new frmCostoPromedioPonderado();

        }
        
        private void btnEspecifica_MouseLeave(object sender, EventArgs e)
        {
            btnEspecifica.BackColor = Color.DodgerBlue;
        }
        private void btnEspecifica_MouseEnter(object sender, EventArgs e)
        {
            btnEspecifica.BackColor = Color.Tomato;
        }
        private void btnPonderado_MouseLeave(object sender, EventArgs e)
        {
            btnPonderado.BackColor = Color.DodgerBlue;
        }
        private void btnPonderado_MouseEnter(object sender, EventArgs e)
        {
            btnPonderado.BackColor = Color.Tomato;
        }
        private void btnSimple_MouseLeave(object sender, EventArgs e)
        {
            btnSimple.BackColor = Color.DodgerBlue;
        }
        private void btnSimple_MouseEnter(object sender, EventArgs e)
        {
            btnSimple.BackColor = Color.Tomato;
        }
        private void btnUEPS_MouseLeave(object sender, EventArgs e)
        {
            btnUEPS.BackColor = Color.DodgerBlue;
        }
        private void btnUEPS_MouseEnter(object sender, EventArgs e)
        {
            btnUEPS.BackColor = Color.Tomato;
        }
        private void btnPEPS_MouseLeave(object sender, EventArgs e)
        {
            btnPEPS.BackColor = Color.DodgerBlue;
        }
        private void btnPEPS_MouseEnter(object sender, EventArgs e)
        {
            btnPEPS.BackColor = Color.Tomato;
        }
        private void btnAltoBajo_MouseLeave(object sender, EventArgs e)
        {
            btnAltoBajo.BackColor = Color.DodgerBlue;
        }
        private void btnAltoBajo_MouseEnter(object sender, EventArgs e)
        {
            btnAltoBajo.BackColor = Color.Gold;
        }
        private void btnEstadistico_MouseLeave(object sender, EventArgs e)
        {
            btnEstadistico.BackColor = Color.DodgerBlue;
        }
        private void btnEstadistico_MouseEnter(object sender, EventArgs e)
        {
            btnEstadistico.BackColor = Color.Gold;
        }

        private void btnEspecifica_Click(object sender, EventArgs e)
        {this.Hide();   
            formularioIdentificacionEspecifica.ShowDialog();
            this.Close();
        }

        private void btnPonderado_Click(object sender, EventArgs e)
        {
            this.Hide();
            formularioPonderado.ShowDialog();
            this.Close();
        }

        private void btnSimple_Click(object sender, EventArgs e)
        {
            this.Hide();
            formularioValuacionPromedioSimple.ShowDialog();
            this.Close();
        }

        private void btnUEPS_Click(object sender, EventArgs e)
        {this.Hide();
            formularioUEPS.ShowDialog();
            this.Close();
        }

        private void btnPEPS_Click(object sender, EventArgs e)
        {
           
            this.Hide();
            formularioPEPS.ShowDialog();
            this.Close();
        }

        private void btnAltoBajo_Click(object sender, EventArgs e)
        {
            this.Hide();
            formularioPuntoAltoBajo.ShowDialog();
            this.Close();
        }

        private void btnEstadistico_Click(object sender, EventArgs e)
        {
            this.Hide();   
            formularioMetodoEstadistico.ShowDialog();
            this.Close();
        }

      
    }
}
