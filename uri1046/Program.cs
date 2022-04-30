using System;

namespace uri1046
{
    class Program
    {
        static void Main(string[] args)
        {
            int horaInicial, horaFinal;
            string[] valores = Console.ReadLine().Split(' ');

            horaInicial = int.Parse(valores[0]);
            horaFinal = int.Parse(valores[1]);

            int tempFinal;
            if (horaInicial < horaFinal)
            {
                tempFinal = horaFinal - horaInicial;
            }
            else
            {
                tempFinal = 24 - horaInicial + horaFinal;
            }
            Console.WriteLine("O JOGO DUROU " + tempFinal + " HORA(S)");
        }
    }
}
