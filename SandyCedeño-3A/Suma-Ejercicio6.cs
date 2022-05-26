using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandyCedeño_3A
{
    class Suma_Ejercicio6
    {
        public Suma_Ejercicio6()
        {

        }
        public void Suma()
        {
            int numero;
            int total = 0;
            do
            {
                Console.WriteLine("Escriba un numero <para finalizar ingrese un cero(0)> ");
                String valor = Console.ReadLine();
                numero = Convert.ToInt32(valor);
                total = numero + total;
            } while (numero != 0);
            Console.WriteLine("El resultado de la suma es: " + total);
        }
    }
}
