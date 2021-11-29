using System;

namespace SequenciaLimites
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1, numero2;
            bool realNumero1, realNumero2;

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\n---------- Sequência ----------\n");
            Console.ResetColor();

            Console.WriteLine(" * Insira dois números inteiros\n   e receba a sequência entre\n   eles.\n");


            Console.Write("Início...: ");
            realNumero1 = Int32.TryParse(Console.ReadLine(), out numero1);

            Console.Write("Fim......: ");
            realNumero2 = Int32.TryParse(Console.ReadLine(), out numero2);

            if (realNumero1 & realNumero2)
            {
                if (numero2 < numero1)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n * O segundo número não pode ser menor que o primeiro!\n");
                    Console.ResetColor();
                    Environment.Exit(-1);
                }
                
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine($"\nSequência do {numero1} ao {numero2}\n");
                Console.ResetColor();

                while (numero1 <= numero2)
                {
                    Console.Write($"{numero1} ");
                    numero1 += 1;
                }

                Console.WriteLine();
                Console.WriteLine();

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n * Insira apenas números inteiros!\n");
                Console.ResetColor();
            }
        }
    }
}
