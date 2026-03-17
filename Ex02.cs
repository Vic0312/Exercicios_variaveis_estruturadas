// Exercicio 02
using System;

namespace Exercicios_variaveis_estruturadas
{
    class Ex02
    {
        /*static void Main(string[] args){

            int n, maiorAtual, p;
            
            Console.WriteLine("Digite o tamanho do vetor: ");
            n = Convert.ToInt32(Console.ReadLine());

            int[] vetor = new int[n];
            maiorAtual = -999999;
            p = 0;

            for(int i=0; i < vetor.Length; i++)
            {
                Console.WriteLine("Digite o valor de um elemento do vetor: ");
                vetor[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("-----------");

            for(int i=0; i < vetor.Length; i++)
            {
                if(vetor[i] > maiorAtual)
                {
                    maiorAtual = vetor[i];
                    p = i;
                }
                
            }

            Console.WriteLine("Maior = " + maiorAtual);
            Console.WriteLine("Posição no vetor = " + p);
        }*/
    }
}


/*
TESTE DE MESA

 n  |   i   |   Imprime
----------------------
 7  |   1   |   Maior = 9
    |   2   |   Posição no vetor = 2
    |   9   |
    |   4   |
    |   1   |
    |   6   |
    |   5   |
*/