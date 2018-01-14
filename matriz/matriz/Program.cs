using System;

namespace matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz;
            Console.WriteLine("Digite a dimensão da matriz: ");
            string[] dim = Console.ReadLine().Split(' ');      //lê a dimensão da matriz, Linhas e Colunas   
            int m = int.Parse(dim[0]); 
            int n = int.Parse(dim[1]); //é uma matriz com duas dimenssões então só preciso de duas variáveis aux's 
            matriz = new int[m, n];
            for (int i = 0; i<m; i++) {               
                
                for (int j = 0; j<n; j++) {
                    Console.WriteLine("Digite um número para a linha {0} e Coluna: {1} ", i+1, j+1);
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine(" ");
            for (int i = 0; i < m; i++) {               
                for (int j = 0; j < n; j++) {
                    Console.Write(matriz[i, j]+  " ");
                    
                }
                Console.WriteLine(" ");
            }
            Console.WriteLine("Digite o valor de X");
            int x = int.Parse(Console.ReadLine());
            for (int i = 0; i<n; i++) {
                for (int j = 0; j<m; j++) {
                    if(x == matriz[i, j]) {
                        if (j > 0) {
                            Console.WriteLine("A Esquerda: {0}", matriz[i, j - 1]);
                        }
                        if (j < n-1) {
                            Console.WriteLine("A direita: {0}", matriz[i, j + 1]);
                        }
                        
                        if (n > 0) {
                            Console.WriteLine("A Acima: {0}", matriz[i - 1, j]);
                        }
                        if (i < m-1) {
                            Console.WriteLine("A Baixo: {0}", matriz[i + 1, j]);
                        }
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
