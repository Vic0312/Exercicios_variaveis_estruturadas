// Exercicio 13
using System;

namespace Exercicios_variaveis_estruturadas
{
    class Ex13
    {
        static void Main(string[] args){

            int n;
            double soma, media;
            
            Console.WriteLine("Digite o tamanho do vetor: ");
            n = Convert.ToInt32(Console.ReadLine());

            double[] vetor = new double[n];
            soma = 0;
            media = 0;

            for(int i=0; i < vetor.Length; i++)
            {
                Console.WriteLine("Digite um valor númerico: ");
                vetor[i] = Convert.ToDouble(Console.ReadLine());

                soma += Math.Sqrt(vetor[i]);
            }

            media = soma / n;

            Console.WriteLine("-----------");

            Console.WriteLine("A media da soma das raízes quadradas dos números é: "+media);

        }
    }
}


/*
TESTE DE MESA

 n  | vetor[i] |   Raiz quadrada |Imprime
------------------------------------------
 4  |    4     |       2         | 4,25
    |   16     |       4         |
    |   25     |       5         |
    |   36     |       6         |
*/
