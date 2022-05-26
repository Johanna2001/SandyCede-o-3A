using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandyCedeño_3A
{
    class Cero_Ejercicio4
    {
        public Cero_Ejercicio4()
        {

        }
        public void Cero()
        {
            int numero;
            do
            {
                Console.WriteLine("Escriba un número");
                String valor = Console.ReadLine();
                numero = Convert.ToInt32(valor);
            } while (numero != 0);

        }
    }
}
