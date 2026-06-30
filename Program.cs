using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Threading;
using System.Collections.Generic;
using System.Xml.Schema;
using System.Globalization;


namespace TOMBOLA
{
    class Program
    {
        static void Main(string[] args)
        {
    






            Random casuale = new Random();


            int casuale1 = casuale.Next(1, 50);
            int casuale2 = casuale.Next(1, 50);
            int casuale3 = casuale.Next(1, 50);
            int casuale4 = casuale.Next(1, 50);                
            int casuale5 = casuale.Next(1, 50);

                    


                int num1 = casuale.Next(1, 50);

                int num2 = casuale.Next(1, 50);

                int num3 = casuale.Next(1, 50);

                int num4 = casuale.Next(1, 50);

                int num5 = casuale.Next(1, 50);

            do
                {
                num1 = casuale.Next(1, 50);

                num2 = casuale.Next(1, 50);

                num3 = casuale.Next(1, 50);

                num4 = casuale.Next(1, 50);

                num5 = casuale.Next(1, 50);

                }while (num1 == num2 || num1 == num3 || num1 == num4 || num1 == num5 || num2 == num3 || num2 == num4 || num2 == num5 || num3 == num4 || num3 == num5 || num4 == num5);





            List<int> scheda = new List<int>() {num1, num2, num3, num4, num5};




            Console.Write("TOMBOLA (scrivi qualsiasi cosa per iniziare) ");
            string scritto = Console.ReadLine();

            string tuttinumeri = string.Join(", ", scheda);

            Console.WriteLine("La tua scheda è: " + tuttinumeri);

            Thread.Sleep(1000);



            while (!scheda.Contains(casuale1))

                {
                casuale1 = casuale.Next(1, 50);

                Console.WriteLine($"{casuale1}?");

                Thread.Sleep(2000);

                }

            
            
            scheda.Remove(casuale1);
            Console.WriteLine($"{casuale1} Era nella scheda.");

            tuttinumeri = string.Join(", ", scheda);

            Thread.Sleep(1000);

            Console.WriteLine("Numeri mancanti: " + tuttinumeri);

            Thread.Sleep(3000);

            while (!scheda.Contains(casuale2))

                {
                casuale2 = casuale.Next(1, 50);

                Console.WriteLine($"{casuale2}?");

                Thread.Sleep(2000);
                }
                


            scheda.Remove(casuale2);

            Console.WriteLine($"{casuale2} Era nella scheda.");

            tuttinumeri = string.Join(", ", scheda);

            Thread.Sleep(1000);

            Console.WriteLine("numeri rimasti: " + tuttinumeri);




            while (!scheda.Contains(casuale3))

                {
                casuale3 = casuale.Next(1, 50);


                Console.WriteLine($"{casuale3}?");

                Thread.Sleep(2000);
                }
                


            scheda.Remove(casuale3);

            Console.WriteLine($"{casuale3} Era nella scheda.");

            tuttinumeri = string.Join(", ", scheda);

            Thread.Sleep(1000);

            Console.WriteLine("numeri rimasti: " + tuttinumeri);

                

            while (!scheda.Contains(casuale4))

                {
                casuale4 = casuale.Next(1, 50);

                Console.WriteLine($"{casuale4}?");


                Thread.Sleep(2000);
                }
                
            


            scheda.Remove(casuale4);

            Console.WriteLine($"{casuale4} Era nella scheda.");

            tuttinumeri = string.Join(", ", scheda);

            Thread.Sleep(1000);

            Console.WriteLine("numero rimasto: " + tuttinumeri);

            while (!scheda.Contains(casuale5))

                {
                casuale5 = casuale.Next(1, 50);

                Console.WriteLine($"{casuale5}?");

                Thread.Sleep(2000);
                }
                


            scheda.Remove(casuale5);

            Console.WriteLine($"{casuale5} Era nella scheda.");

            tuttinumeri = string.Join(", ", scheda);

            Thread.Sleep(1000);

            Console.WriteLine("TOMBOLA!");

        }
    
    }

}
