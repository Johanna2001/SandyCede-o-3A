using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandyCedeño_3A
{
    class Factorial_Ejercicio10
    {
        public Factorial_Ejercicio10()
        {

        }
        public void Factorial()
        {
            Console.WriteLine("Ingrese un número");
            String numero = Console.ReadLine();
            int valor = Convert.ToInt32(numero);
            int factorial = 1;
            for (int i = 1; i <= valor; i++)
            {
                factorial *= i;
            }
            Console.WriteLine("El factorial de " + valor + " es: " + factorial);
        }

    }
}
