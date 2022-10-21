using System;

namespace Program
{
    class Program
    {
        public static void Main(string[] args)
        {
            
            int qtd;

            Console.Write("Quantos nomes deseja digitar?: ");
            qtd = Convert.ToInt32(Console.ReadLine());

            string[] nomes = nomes[qtd];

            for(int i = 0; i < qtd; i++)
            {
                Console.WriteLine("Digite o " + i + "º nome: ");
                nomes[i] = Console.ReadLine();
            }
        }
    }
}