using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandyCedeño_3A
{
    class Mayor3_Ejercicio3
    {
        public Mayor3_Ejercicio3()
        {

        }
        public void Mayor3()
        {
            Console.WriteLine("Escriba un número");
            String numero1 = Console.ReadLine();
            int valor1 = Convert.ToInt32(numero1);
            Console.WriteLine("Escriba otro número");
            String numero2 = Console.ReadLine();
            int valor2 = Convert.ToInt32(numero2);
            Console.WriteLine("Escribe el tercer número");
            String numero3 = Console.ReadLine();
            int valor3 = Convert.ToInt32(numero3);
            if (valor1 > valor2 && valor1 > valor3)
            {
                Console.WriteLine(numero1 + " es mayor");
            }
            else if (valor2 > valor1 && valor2 > valor3)
            {
                Console.WriteLine(numero2 + " es mayor");
            }
            else
            {
                Console.WriteLine(numero3 + "es mayor");
            }
        }
    }
}
