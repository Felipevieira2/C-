using System;

namespace paradaComZero
{
    class Program
    {
        static void Main(string[] args)
        {
            double? numero = null;

            while (numero != 0){
                
                Console.WriteLine("digite um número");
                numero = double.Parse(Console.ReadLine());
                Console.WriteLine("A Raiz quadrada do número é " + Math.Sqrt((double) numero));
            }
  

        }
    }
}
