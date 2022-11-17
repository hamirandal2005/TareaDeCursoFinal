using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Clases
{
    public class PuntoBajoPuntoAlto
    {
        private Mes mesBajo;
        private Mes mesAlto;
        private Mes[] meses = new Mes[12];

        public PuntoBajoPuntoAlto()
        {
            meses[0] = new Mes("Enero", 0, 0);
            meses[1] = new Mes("Febrero", 0, 0);
            meses[2] = new Mes("Marzo", 0, 0);
            meses[3] = new Mes("Abril", 0, 0);
            meses[4] = new Mes("Mayo", 0, 0);
            meses[5] = new Mes("Junio", 0, 0);
            meses[6] = new Mes("Julio", 0, 0);
            meses[7] = new Mes("Agosto", 0, 0);
            meses[8] = new Mes("Septiembre", 0, 0);
            meses[9] = new Mes("Octubre", 0, 0);
            meses[10] = new Mes("Noviembre", 0, 0);
            meses[11] = new Mes("Diciembre", 0, 0);
        }
        public Mes MesBajo
        {
            get { return mesBajo; }
        }
        public Mes? MesAlto
        {
            get { return mesAlto; }
        }
        public Mes[] Meses
        {
            get { return meses; }
            set { meses = value; }
        }

        public void OrdenarMeses()
        {
            Mes mayor = new Mes();
            Mes menor = new Mes();
            menor.Valor = 100000000;
            for (int i = 0; i < meses.Length; i++)
            {
                if (meses[i].Valor > mayor.Valor)
                {
                    mayor = meses[i];
                    this.mesAlto = mayor;
                }
                if (meses[i].Valor < menor.Valor)
                {
                    if (meses[i].Valor != 0)
                    {
                        menor = meses[i];
                        this.mesBajo = menor;
                    }
                }
            }
        }

        public double CostoVariableTotal(int a)
        {
            return CostoVariableUnitario() * meses[a].Horas;
        }
        public double CostoVariableUnitario()
        {
            double VariableUnit = (mesAlto.Valor - mesBajo.Valor) / (mesAlto.Horas - mesBajo.Horas);
            return double.Parse(VariableUnit.ToString("0.00"));
        }

        public double CostoFijoTotal()
        {
            double costo = CostoVariableUnitario();
            double MmesAlto = (mesAlto.Valor) - (mesAlto.Horas * costo);
            double MmesBajo = (mesBajo.Valor) - (mesBajo.Horas * costo);
            double diferencia = MmesAlto - MmesBajo;
            if (diferencia < 100)
            {
                return MmesAlto;
            }
            return 0;
        }

    }
}
