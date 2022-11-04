using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class IdentificacionEspecifica
    {
        public class RegistroEntradas
        {
            public RegistroEntradas()
            {
            }

            public RegistroEntradas(DateTime fechaEntrada, int materialesComprados, double costoUnitario)
            {
                FechaEntrada = fechaEntrada;
                UnidadesCompradas = materialesComprados;
                CostoUnitario = costoUnitario;
            }

            //Atributos de la clase
            public DateTime FechaEntrada { get; set; }
            public int UnidadesCompradas { get; set; }
            public double CostoUnitario { get; set; }

        }
    }
   
}
