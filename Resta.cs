using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraNumeros
{
    internal class Resta : Numeros
    {
        public Resta(int numero1, int numero2)
        {
            Numero1 = numero1;
            Numero2 = numero2;
        }

        public void CalcularResta(int numero1, int numero2)
        {
            this.Numero1 = numero1;
            this.Numero2 = numero2;

            this.Resultado = this.Numero1 - this.Numero2;
        }
    }
}
