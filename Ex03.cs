// Exercicio 03
using System;

namespace Exercicios_variaveis_estruturadas
{
    class Ex03
    {
        /*static void Main(string[] args){

            int n, menorAtual, p;
            
            Console.WriteLine("Digite o tamanho do vetor: ");
            n = Convert.ToInt32(Console.ReadLine());

            int[] vetor = new int[n];
            menorAtual = 999999;
            p = 0;

            for(int i=0; i < vetor.Length; i++)
            {
                Console.WriteLine("Digite o valor de um elemento do vetor: ");
                vetor[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("-----------");

            for(int i=0; i < vetor.Length; i++)
            {
                if(vetor[i] < menorAtual)
                {
                    menorAtual = vetor[i];
                    p = i;
                }
                
            }

            Console.WriteLine("Menor = " + menorAtual);
            Console.WriteLine("Posição no vetor = " + p);
        }*/
    }
}


/*
TESTE DE MESA

 n  |vetor[i]|   Imprime
----------------------
 8  |   7   |   Menor = 2
    |   3   |   Posição no vetor = 5
    |   9   |
    |   5   |
    |   4   |
    |   2   |
    |   5   |
    |   3   |
*/