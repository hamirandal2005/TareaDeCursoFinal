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
    public class RegistroEntradas:IEquatable<RegistroEntradas>
    {
        public RegistroEntradas()
        {
        }

        public RegistroEntradas(string fechaEntrada, int materialesComprados, double costoUnitario)
        {
            FechaEntrada = fechaEntrada;
            MaterialesComprados = materialesComprados;
            CostoUnitario = costoUnitario;
        }

        //Atributos de la clase
        public string FechaEntrada { get; set; }
        public int MaterialesComprados { get; set; }
        public double CostoUnitario { get; set; }

        public bool Equals(RegistroEntradas? other)
        {
            throw new NotImplementedException();
        }
    }
}
