using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class MatEntradaSalida : IComparable<MatEntradaSalida>
    {
        private DateTime fecha;
        private int unidadesCompradas;
        private double costoUnitario;
        private int unidadesUtilizadas;

        public MatEntradaSalida()
        {

        }

        public MatEntradaSalida(DateTime fecha, int compradas, double costoUnitario)
        {
            this.fecha = fecha;
            this.unidadesCompradas = compradas;
            this.costoUnitario = costoUnitario;
        }

        public MatEntradaSalida(DateTime fecha, int usadas)
        {
            this.fecha = fecha;
            this.unidadesUtilizadas = usadas;
        }
        public int UnidadesCompradas
        {
            get { return unidadesCompradas; }
            set { unidadesCompradas = (value > 0) ? value : 0; }
        }
        public double CostoUnitario
        {
            get { return costoUnitario; }
            set { costoUnitario = (value > 0) ? value : 0; }
        }

        public int UnidadesUtilizadas
        {
            get { return unidadesUtilizadas; }
            set { unidadesUtilizadas = (value > 0) ? value : 0; }
        }

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        public int CompareTo(MatEntradaSalida? elemento)
        {
            DateTime fechaobj = this.fecha;
            DateTime     fechaElemento = elemento.fecha;

            if (fechaobj > fechaElemento)
                return 1;
            if (fechaobj < fechaElemento)
                return -1;
            return 0;
        }
    }
}
