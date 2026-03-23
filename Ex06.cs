// Exercicio 06
using System;

namespace Exercicios_variaveis_estruturadas
{
    class Ex06
    {
        /*static void Main(string[] args){

            int n;
            
            Console.WriteLine("Digite o tamanho do vetor: ");
            n = Convert.ToInt32(Console.ReadLine());

            int[] vetor = new int[n];

            for(int i=0; i < vetor.Length; i++)
            {
                Console.WriteLine("Digite uma idade que será guardada no vetor: ");
                vetor[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("-----------");

            for(int i=0; i < vetor.Length; i++)
            {
                if(vetor[i] <= 0)
                {
                    Console.WriteLine("Erro: valor inserido inválido");

                }
                else if(vetor[i] >= 1 && vetor[i]<=9)
                {
                    Console.WriteLine("Idade: "+ vetor[i]+ " -- Criança");
                }
                else if(vetor[i]<=12)
                {
                    Console.WriteLine("Idade: "+ vetor[i]+ " -- Pré-adolescente");
                }
                else if(vetor[i]<=17)
                {
                    Console.WriteLine("Idade: "+ vetor[i]+ " -- Adolescente");
                }
                else if(vetor[i]<=59)
                {
                    Console.WriteLine("Idade: "+ vetor[i]+ " -- Adulto");
                }
                else
                {
                    Console.WriteLine("Idade: "+ vetor[i]+ " -- Idoso");
                }
                
            }

        }*/
    }
}


/*
TESTE DE MESA

 n | vetor[i] | Imprime
----------------------------
 5 |    10    | Idade: 10 -- Pré-adolescente
   |    3     | Idade: 3 -- Criança
   |    45    | Idade: 45 -- Adulto
   |    78    | Idade: 78 -- Idoso
   |    23    | Idade: 23 -- Adulto
*/