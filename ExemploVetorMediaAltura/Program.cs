using System;
using System.Globalization;

namespace ExemploVetorMediaAltura
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criação de variável na memória stack
            int n = int.Parse(Console.ReadLine());

            //criação da variável do tipo vetor
            //instanciação da variável de entrada
            //esta ação cria na memória HEAP o tamanho do vetor.
            double[] vet = new double[n]; 

            //Para conseguir trabalhar com o vetor, é necessário ter um cursor
            //para percorrer o cursor
            for(int i = 0; i < n; i++)
            {
                vet[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double sum = 0;

            for(int i = 0; i< n; i++)
            {
                sum = sum + vet[i];
            }
            double avg = sum / n;
            Console.WriteLine("AVARAGE HEIGHT = " + avg.ToString("f2"), CultureInfo.InvariantCulture);
        }
    }
}
