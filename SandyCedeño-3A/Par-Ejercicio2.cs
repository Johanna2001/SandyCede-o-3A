using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandyCedeño_3A
{
    class Par_Ejercicio2
    {
        public Par_Ejercicio2()
        {

        }
        public void Par_Impar()
        {
            Console.WriteLine("Escriba un número");
            String numero1 = Console.ReadLine();
            int valor1 = Convert.ToInt32(numero1);
            if (valor1 % 2 == 0)
            {
                Console.WriteLine("El número ingresado es par");
            }
            else
            {
                Console.WriteLine("El número ingresado es impar");
            }
        }
    }
}
