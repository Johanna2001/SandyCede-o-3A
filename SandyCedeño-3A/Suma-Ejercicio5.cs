using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandyCedeño_3A
{
    class Suma_Ejercicio5
    {
        public Suma_Ejercicio5()
        {

        }
        public void Suma()
        {
            int total = 0;
            for (int i = 0; i <= 8; i++)
            {

                Console.WriteLine("Escriba un número");
                String valor = Console.ReadLine();
                int num = Convert.ToInt32(valor);
                total = num + total;

            }
            Console.WriteLine("La suma de todos los números es: " + total);
        }
    }
}
