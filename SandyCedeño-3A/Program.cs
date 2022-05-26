using System;

namespace SandyCedeño_3A
{
    class Program
    {
        static void Main(string[] args)
        {
            Mayor_Ejercicio1 uno = new Mayor_Ejercicio1();
            Par_Ejercicio2 dos = new Par_Ejercicio2();
            Mayor3_Ejercicio3 tres = new Mayor3_Ejercicio3();
            Cero_Ejercicio4 cuatro = new Cero_Ejercicio4();
            Suma_Ejercicio5 cinco = new Suma_Ejercicio5();
            Suma_Ejercicio6 seis = new Suma_Ejercicio6();
            Triangulo_Ejercicio7 siete = new Triangulo_Ejercicio7();
            Multiplos_Ejercicio8 ocho = new Multiplos_Ejercicio8();
            Aritmetica_Ejercicio9 nueve = new Aritmetica_Ejercicio9();
            Factorial_Ejercicio10 dies = new Factorial_Ejercicio10();
            Boolean estado = false;
            String respuesta = "";
            do
            {
                do
                {
                    estado = false;
                    Console.WriteLine("Elija el número del ejercicio que desea usar");
                    String caso = Console.ReadLine();
                    int obcion = Convert.ToInt32(caso);
                    switch (obcion)
                    {
                        case 1:
                            uno.Mayor();
                            break;
                        case 2:
                            dos.Par_Impar();
                            break;
                        case 3:
                            tres.Mayor3();
                            break;
                        case 4:
                            cuatro.Cero();
                            break;
                        case 5:
                            cinco.Suma();
                            break;
                        case 6:
                            seis.Suma();
                            break;
                        case 7:
                            siete.Triangulo();
                            break;
                        case 8:
                            ocho.Multiplos();
                            break;
                        case 9:
                            nueve.Aritmetica();
                            break;
                        case 10:
                            dies.Factorial();
                            break;
                        default:
                            Console.WriteLine("Error de número ingresado");
                            estado = true;
                            break;
                    }
                } while (estado);
                Console.WriteLine("Desea probar otro ejercicio s/n (si ingresa otro valor se finalizara el programa)");
                respuesta = Console.ReadLine();
            } while (respuesta == "s" || respuesta == "S");
        }
    }
}
