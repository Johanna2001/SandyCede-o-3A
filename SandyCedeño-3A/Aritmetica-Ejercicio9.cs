using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandyCedeño_3A
{
    class Aritmetica_Ejercicio9
    {
            public Aritmetica_Ejercicio9()
            {

            }
            public void Aritmetica()
            {
                int numero;
                int total = 0;
                int cantidad = 0;
                do
                {
                    cantidad++;
                    Console.WriteLine("Escriba un número <para finalizar ingrese un cero(0)>");
                    String valor = Console.ReadLine();
                    numero = Convert.ToInt32(valor);
                    total = numero + total;
                } while (numero != 0);
                int resultado = total / (cantidad - 1);
                Console.WriteLine("La aritmética de los números ingresados es: " + resultado);
            }
        }
}
