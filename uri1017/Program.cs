using System;
using System.Globalization;

namespace uri1017
{
    class Program
    {
        static void Main(string[] args)
        {
            double velocidadeMedia, deslocamento, mediaLitro;
            int intervaloTempo;

            velocidadeMedia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            intervaloTempo = int.Parse(Console.ReadLine());

            deslocamento = velocidadeMedia * intervaloTempo;
            mediaLitro = deslocamento / 12.0;

            Console.WriteLine(mediaLitro.ToString("F3", CultureInfo.InvariantCulture));

        }
    }
}

//Vm: velocidade média (m/s);
//ΔS: deslocamento(m);
//Δt: intervalo de tempo(s).