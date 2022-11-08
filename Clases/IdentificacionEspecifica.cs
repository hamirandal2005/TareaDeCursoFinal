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
    }

    public class RegistroEntradas : IEquatable<RegistroEntradas>
    {
        public RegistroEntradas()
        {
        }

        //Atributos de la clase
        public DateTime FechaEntrada { get; set; }
        public int UnidadesCompradas { get; set; }
        public double CostoUnitario { get; set; }


        //Constructor de Entrada de materiales
        public RegistroEntradas(DateTime fechaEntrada, int unidadesCompradas, double costoUnitario)
        {
            FechaEntrada = fechaEntrada;
            UnidadesCompradas = unidadesCompradas;
            CostoUnitario = costoUnitario;
        }

       

        public bool Equals(RegistroEntradas? other)
        {
            throw new NotImplementedException();
        }
    }
}
