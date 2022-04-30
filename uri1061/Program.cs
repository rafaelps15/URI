using System;

namespace uri1061
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dia Inicial
            Console.Write("Dia:");
            int diaInicial = int.Parse(Console.ReadLine());

            string s = Console.ReadLine();
            string[] tempoInicial = s.Split(' ');

            int horaInicial = int.Parse(tempoInicial[0]);
            int minutoInicial = int.Parse(tempoInicial[1]);
            int segundoInicial = int.Parse(tempoInicial[2]);

            //Dia Final
            Console.Write("Dia:");
            int diaFinal = int.Parse(Console.ReadLine());

            string v = Console.ReadLine();
            string[] tempoFinal = v.Split(' ');

            int horaFinal = int.Parse(tempoFinal[0]);
            int minutoFinal = int.Parse(tempoFinal[1]);
            int segundoFinal = int.Parse(tempoFinal[2]);

            //Lógica para verificar o tempo
            int diaTotal = 0, horaTotal = 0, minutoTotal = 0, segundoTotal = 0;

            //Segundos
            if (segundoInicial > segundoFinal)
            {
                segundoTotal = (60 - segundoInicial) + segundoFinal;
            }
            else if (segundoInicial == segundoFinal)
            {
                segundoTotal = 0;
            }
            else
            {
                segundoTotal = segundoFinal - segundoInicial;
            }

            //Minutos
            if (minutoInicial > minutoFinal)
            {
                minutoTotal = (60 - minutoInicial) + minutoFinal;
            }
            else if (minutoInicial == minutoFinal)
            {
                minutoTotal = 0;
            }
            else
            {
                minutoTotal = minutoFinal - minutoInicial;
            }

            //Hora e Dia
            if (horaInicial > horaFinal)
            {
                horaTotal = (24 - horaInicial) + horaFinal;
                diaTotal = (diaFinal - diaInicial) - 1;
            }
            else if (horaInicial == horaFinal)
            {
                horaTotal = 0;
                diaTotal = (diaInicial - diaFinal) + 1;
            }
            else
            {
                horaTotal = horaFinal - horaInicial;
                diaTotal = diaFinal - diaInicial;
            }
            Console.WriteLine();
            Console.WriteLine(diaTotal + " dia (s)");
            Console.WriteLine(horaTotal + " hora (s)");
            Console.WriteLine(minutoTotal + " minuto (s)");
            Console.WriteLine(segundoTotal + " segundo(s)");
        }
    }
}





