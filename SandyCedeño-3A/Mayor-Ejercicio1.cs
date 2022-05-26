using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandyCedeño_3A
{
    class Mayor_Ejercicio1
    {
        public Mayor_Ejercicio1()
        {

        }
        public void Mayor()
        {
            Console.WriteLine("Escriba el primer número");
            String numero1 = Console.ReadLine();
            int valor1 = Convert.ToInt32(numero1);
            Console.WriteLine("Escriba el segundo número");
            String numero2 = Console.ReadLine();
            int valor2 = Convert.ToInt32(numero2);
            if (valor1 > valor2)
            {
                Console.WriteLine(numero1 + " es mayor");
            }
            else
            {
                Console.WriteLine(numero2 + " es mayor");
            }
        }

    }
}
