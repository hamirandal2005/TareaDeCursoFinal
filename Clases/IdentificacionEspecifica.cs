using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class IdentificacionEspecifica
    {
    }

    public class RegistroTransacciones
    {
        public RegistroTransacciones()
        {
        }

        //Atributos de la clase
        public DateTime Fecha { get; set; }
        public int UnidadesCompradas { get; set; }
        public double CostoUnitario { get; set; }
        public double CostoUnidadesCompradas { get; set; }
        public double UnidadesUsadas { get; set; }


        //Constructor de Entrada de materiales
        public RegistroTransacciones(DateTime fechaEntrada, int unidadesCompradas, double costoUnitario, double costoUnidadesCompradas)
        {
            Fecha = fechaEntrada;
            UnidadesCompradas = unidadesCompradas;
            CostoUnitario = costoUnitario;
            CostoUnidadesCompradas = costoUnidadesCompradas;
        }

        public RegistroTransacciones(DateTime FechaSalida, double unidadesUsadas, double costoUnitario)
        {
            this.Fecha = FechaSalida;
            this.CostoUnitario= costoUnitario;
            this.UnidadesUsadas = unidadesUsadas;
        }
    }
}
