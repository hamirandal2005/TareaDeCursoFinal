using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class PromedioPonderado
    {
        private int unidadesCompradas;
        private double precioDeCompra;

        public PromedioPonderado()
        {

        }
        public PromedioPonderado(int compradas, double precio)
        {
            this.unidadesCompradas = compradas;
            this.precioDeCompra = precio;
        }

        public int UnidadesCompradas
        {
            get { return unidadesCompradas; }
            set { unidadesCompradas = (value > 0) ? value : 0; }
        }

        public double PrecioDeCompra
        {
            get { return precioDeCompra; }
            set { precioDeCompra = (value > 0) ? value : 0; }
        }

        public double Ponderado()
        {
            return unidadesCompradas * precioDeCompra;
        }

        public double Calculo(List<PromedioPonderado> a)
        {
            double numerador = 0;
            double denominador = 0;
            for (int i = 0; i < a.Count; i++)
            {
                numerador += a[i].Ponderado();
                denominador += a[i].unidadesCompradas;
            }
            return numerador / denominador;
        }
    }
}
