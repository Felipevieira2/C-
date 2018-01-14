using System;
using System.Globalization;
namespace arremessoDardos {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("digite as distancias");
            string[] distancia = Console.ReadLine().Split(' ');
            double distancia1 = double.Parse(distancia[0], CultureInfo.InvariantCulture);
            double distancia2 = double.Parse(distancia[1], CultureInfo.InvariantCulture);
            double distancia3 = double.Parse(distancia[2], CultureInfo.InvariantCulture);
            if (distancia1 >= distancia2 && distancia3 <= distancia2) {
                Console.WriteLine(distancia1);
            }
            if (distancia2 > distancia3 && distancia1 < distancia2) {
                Console.WriteLine(distancia2);
            }
            if (distancia2 <= distancia3) {


                Console.WriteLine(distancia3);
            }

            Console.ReadKey();

            // se A for maior que B e C menor ou igual a B
            // entao A é maior.
            // se B for maior que C entao B é maior que todos
            // se não C é maior que todos

        }
    }
}
