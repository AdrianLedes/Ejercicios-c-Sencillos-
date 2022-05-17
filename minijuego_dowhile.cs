using System;

namespace Dowhile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adivina el numero que genero aleatoriamente");

            Random numeroA = new Random();
            int numeroAleatorio = numeroA.Next(0, 100);

            int num;

            int intentos = 0;


            
            do{
                intentos++;

                Console.WriteLine("El numero introducido es diferente al mio, intentalo de nuevo");
               
                try
                {
                  num = Int32.Parse(Console.ReadLine());
                }
                catch (Exception ex) when (ex.GetType() != typeof(FormatException)
                {
                    Console.WriteLine("Ha habido un error.");

                    //Console.WriteLine(ex.Message);

                    num = 0;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Has introducido texto");
                    num = 0;
                }



                if (numeroAleatorio < num)
                {
                    Console.WriteLine($"El numero es menor {num}");
                }
                if (numeroAleatorio > num)
                {
                    Console.WriteLine($"El numero es mayor a {num}");
                }
            } while (num != numeroAleatorio) ;

                Console.WriteLine($"El numero {num} es igula al que yo genere");
            Console.WriteLine($"\nUtilizaste {intentos} intentos");
        }
    }
}
