// Exercicio 01
using System;

namespace Exercicios_variaveis_estruturadas
{
    class Ex01
    {
        static void Main(string[] args){

            int n;
            
            Console.WriteLine("Digite o tamanho do vetor: ");
            n = Convert.ToInt32(Console.ReadLine());

            int[] vetor = new int[n];

            for(int i=0; i < vetor.Length; i++)
            {
                Console.WriteLine("Digite o valor de um elemento do vetor: ");
                vetor[i] = Convert.ToInt32(Console.ReadLine());
            }

            for(int i = n - 1; i>=0; i--)
            {
                Console.WriteLine("-----------");
                Console.WriteLine("Vetor[" + i + "]= " + vetor[i]);
            }
        }
    }
}