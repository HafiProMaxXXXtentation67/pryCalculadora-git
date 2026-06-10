using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryCalculadora
{
    internal class clsCalculadora
    {
        //Atributos de entrada
        private float n1, n2;
        //Atributos de salida
        private float resultado;

        public float N1 { get => n1; set => n1 = value; }
        public float N2 { get => n2; set => n2 = value; }

        //Uso de propiedades, get y set



        //Funciones o métodos
        public float Sumar()
        {
            resultado = n1 + n2;
            return resultado;
        }
        public float Restar()
        {
            resultado = n1 - n2;
            return resultado;
        }
        public float Multiplicar()
        {
            resultado = n1 * n2;
            return resultado;
        }
        public float Dividir()
        {
            resultado = n1 / n2;
            return resultado;
        }
    }
}
