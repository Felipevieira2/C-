using System;

namespace multiplosDeAeB {
    class Program {
        static void Main(string[] args) {
            int a, b, n;
            Console.WriteLine("Digte o valor de N");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Digte o valor de A");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digte o valor de B");
            b = int.Parse(Console.ReadLine());
            

            for (int i = a; i <= b; i++) {
                if (i % n == 0) {
                    Console.WriteLine(i);

                }
            }
            Console.ReadKey();
        }
    }
}
