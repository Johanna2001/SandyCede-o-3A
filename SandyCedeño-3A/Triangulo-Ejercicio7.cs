using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandyCedeño_3A
{
    class Triangulo_Ejercicio7
    {
        public Triangulo_Ejercicio7 ()
        {

        }
        public void Triangulo()
        {
            String Respuesta = "";
            do
            {
                Console.WriteLine("Escriba un numero");
                String numero1 = Console.ReadLine();
                int valor1 = Convert.ToInt32(numero1);
                Console.WriteLine("Escriba otro numero");
                String numero2 = Console.ReadLine();
                int valor2 = Convert.ToInt32(numero2);
                Console.WriteLine("Escribe el tercer numero");
                String numero3 = Console.ReadLine();
                int valor3 = Convert.ToInt32(numero2);
                if (valor1 == valor2 && valor1 == valor3)
                {
                    Console.WriteLine("Los numeros forman un triangulo equilátero");
                }
                else if (valor2 == valor1 || valor2 == valor3 || valor1 == valor3)
                {
                    Console.WriteLine("Los numeros forman un triangulo isóceles");
                }
                else
                {
                    Console.WriteLine("Los numeros forman un triangulo escaleno");
                }
                Console.WriteLine("Desea continuar s/n");
                Respuesta = Console.ReadLine();
            } while (Respuesta == "s" || Respuesta == "S");
        }
    }
}
