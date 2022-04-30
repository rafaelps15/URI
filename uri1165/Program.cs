using System;

namespace uri1165
{
 /* 
 QUESTÃO
 Na matemática, um Número Primo é aquele que pode ser dividido somente por 1 
 (um) e por ele mesmo. Por exemplo, o número 7 é primo, pois pode ser dividido 
 apenas pelo número 1 e pelo número 7.
 
 ENTRADA
 A entrada contém vários casos de teste. A primeira linha da entrada contém 
 um inteiro N (1 <= N <= 100), indicando o número de casos de teste da entrada. 
 Cada uma das N linhas seguintes contém um valor inteiro X (1 < X <= 107), que 
 pode ser ou não, um número primo.
 
 SAÍDA
 Para cada caso de teste de entrada, imprima a mensagem “X eh primo” ou “X nao 
 eh primo”, de acordo com a especificação fornecida.
*/
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < num; i++)
            {
                int impar = int.Parse(Console.ReadLine());
                int cont = 0;
                for (int j = 2; j < impar; j++)
                {
                    if (impar % j == 0)
                    {
                        cont++;
                    }
                }
                if (cont == 0)
                {
                    Console.WriteLine(impar + " eh primo");
                }
                else
                {
                    Console.WriteLine(impar + " nao eh primo");
                }
            } 
        }
    }
}
