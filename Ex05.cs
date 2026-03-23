// Exercicio 05
using System;

namespace Exercicios_variaveis_estruturadas
{
    class Ex05
    {
        /*static void Main(string[] args){

            int n, maior, menor, mep, map;
            
            Console.WriteLine("Digite o tamanho do vetor: ");
            n = Convert.ToInt32(Console.ReadLine());

            int[] vetor = new int[n];
            menor = 999999;
            maior = -999999;
            mep = 0; //posição do menor
            map = 0; //posição do maior

            for(int i=0; i < vetor.Length; i++)
            {
                Console.WriteLine("Digite o valor de um elemento do vetor: ");
                vetor[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("-----------");

            for(int i=0; i < vetor.Length; i++)
            {
                if(vetor[i] > maior)
                {
                    maior = vetor[i];
                    map = i;

                }
                if(vetor[i] < menor)
                {
                    menor = vetor[i];
                    mep = i;
                }
            }

            Console.WriteLine("Menor: "+ menor);
            Console.WriteLine("Maior: "+ maior);
            Console.WriteLine("Posição do maior " + map);
            Console.WriteLine("Posição do menor " + mep);
        }*/
    }
}


/*
TESTE DE MESA

 n  |vetor[i]|   Imprime
----------------------
 5  |   7   |   Maior = 9    Menor = 3
    |   3   |   
    |   9   |
    |   5   |
    |   4   |
*/