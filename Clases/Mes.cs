using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace Clases
{
    public class Mes
    {
        //Para Método PuntoA Alto, Punto Bajo
        private String nombre;
        private double valor;
        private int horas;

        //Para Método Estadístico
        public string Month { get; set; }
        public double VariableX { get; set; }
        public double VariableY { get; set; }

        //Para Método PuntoA Alto, Punto Bajo
        public Mes(String nombre, double valor, int horas)
        {
            this.horas = horas;
            this.nombre = nombre;
            this.valor = valor;
        }

        //Para Método Estadístico
        public Mes(string month, double variableX, double variableY)
        {
            this.Month = month; 
            this.VariableX = variableX;
            this.VariableY = variableY;
        }

        public Mes()
        {
           
        }

        //Para Método PuntoA Alto, Punto Bajo
        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public double Valor
        {
            get { return valor; }
            set { valor = (value > 0) ? value : 0; }
        }

        public int Horas
        {
            get { return horas; }
            set { horas = (value > 0) ? value : 0; }
        }
    }
}