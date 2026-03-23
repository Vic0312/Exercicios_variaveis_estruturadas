// Exercicio 04
using System;

namespace Exercicios_variaveis_estruturadas
{
    class Ex04
    {
        /*static void Main(string[] args){

            int n, s_maior, p_maior, s, p;
            
            Console.WriteLine("Digite o tamanho do vetor: ");
            n = Convert.ToInt32(Console.ReadLine());

            int[] vetor = new int[n];
            p_maior = -999999;
            s_maior = -999999;
            p = 0;
            s = 0;

            for(int i=0; i < vetor.Length; i++)
            {
                Console.WriteLine("Digite o valor de um elemento do vetor: ");
                vetor[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("-----------");

            for(int i=0; i < vetor.Length; i++)
            {
                if(vetor[i] > p_maior)
                {
                    s_maior = p_maior;
                    s = p;
                    p_maior = vetor[i];
                    p = i;

                }
                else if(vetor[i] > s_maior && vetor[i] < p_maior)
                {
                    s_maior = vetor[i];
                    s = i;
                }
            }

            Console.WriteLine("Os dois maiores números são respectivamente " + p_maior + " e " + s_maior);
            Console.WriteLine("Posição no vetor do primeiro é " + p + " e do segundo é "+ s);
        }*/
    }
}


/*
TESTE DE MESA

 n  |vetor[i]|   Imprime
----------------------
 5  |   7   |   Maior = 9  posição 2  
    |   3   |   Segundo maior = 7  posição 0
    |   9   |
    |   5   |
    |   4   |
*/