using System;
using System.Collections.Generic;
namespace lista
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> teste = new List<string>();

            teste.Add("Felipe");
            teste.Add("Teste");
            teste.Add("Bruno");

            int pos = teste.FindIndex(nome => nome == "Felipe");
            teste.RemoveAt(pos);
            for(int i = 0; i<teste.Count; i++) {
                Console.WriteLine(teste[i]);
            }
            Console.ReadLine();
        }
    }
}
