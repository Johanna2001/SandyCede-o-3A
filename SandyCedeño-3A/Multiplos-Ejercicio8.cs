using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandyCedeño_3A
{
    class Multiplos_Ejercicio8
        {
            public Multiplos_Ejercicio8()
            {
            }
            public void Multiplos()
            {
                int numero = 1;
                Console.WriteLine(numero);
                numero = numero - 1;
                do
                {
                    numero = numero + 3;
                    Console.WriteLine(numero);

                } while (numero != 3000);
            }
        }
}
