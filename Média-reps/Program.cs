using System;

namespace Média_reps
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite o numero de series");
            int n = int.Parse(Console.ReadLine());

            double[] vect = new double[n];


            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Reps da Série #" + i );
                vect[i] = double.Parse(Console.ReadLine());

            }

            double sum = 0.0;
            for (int i = 0; i < n; i++)
            {
                sum += vect[i];
            }

            double avg = sum / n;

            Console.WriteLine(" a média " + avg.ToString("F2"));

            Console.ReadLine();

        }
    }
}
