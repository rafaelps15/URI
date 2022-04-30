using System;

namespace uri1047
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] valores = Console.ReadLine().Split(' ');
            int hrInicial = int.Parse(valores[0]);
            int minInicial = int.Parse(valores[1]);
            int hrFinal = int.Parse(valores[2]);
            int minFinal = int.Parse(valores[3]);

            int instanteInicial = hrInicial * 60 + minInicial;
            int instanteFinal = hrFinal * 60 + minFinal;

            int duracao;
            if (instanteInicial < instanteFinal)
            {
                duracao = instanteFinal - instanteInicial;
            }
            else
            {
                duracao = (24 * 60 - instanteInicial) + instanteFinal;
            }

            int duracaoHoras = duracao / 60;
            int duracaoMinutos = duracao % 60;

            Console.WriteLine("O JOGO DUROU " + duracaoHoras + " HORA(S) E " + duracaoMinutos + " MINUTO(S)");
        }
    }
}