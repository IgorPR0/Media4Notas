using System;

namespace media4notas
{
    class Program
    {
        static void Main(string[] args)

        {
            decimal Nota1, Nota2, Nota3, Nota4;
            decimal Resultado;

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Calcule sua média\n"); 
            Console.ResetColor();

            Console.Write("Primeira Nota: ");
            Nota1 = Convert.ToDecimal(Console.ReadLine());
            if (Nota1 < 0 || Nota1 > 10)
            {
                Console.WriteLine("Numeração Inválida, Digite Somente 0 a 10");
                Console.ReadLine();
            }

                Console.Write("Segunda Nota: ");
                Nota2 = Convert.ToDecimal(Console.ReadLine());
                if (Nota2< 0 || Nota2 > 10)
            {
                Console.WriteLine("Numeração Inválida, Digite Somente 0 a 10");
                Console.ReadLine();
            }

                Console.Write("Terceira Nota: ");
                Nota3 = Convert.ToDecimal(Console.ReadLine());
                if (Nota3 < 0 || Nota3 > 10)
            {
                Console.WriteLine("Numeração Inválida, Digite Somente 0 a 10");
                Console.ReadLine();
            }

                Console.Write("Quarta Nota: ");
                Nota4 = Convert.ToDecimal(Console.ReadLine());
                if (Nota4 < 0 || Nota4 > 10)
            {
                Console.WriteLine("Numeração Inválida, Digite Somente 0 a 10");
                Console.ReadLine();
            }

            
            Resultado = (Nota1 + Nota2 + Nota3 + Nota4) / 4;

            if (Resultado >= 7)

            
            {
                Console.WriteLine($"Sua média conclusiva é {Math.Round(Resultado, 1)}");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("APROVADO!");
                Console.ResetColor();
            }
            else if (Resultado >= 5 && Resultado <= 6)
            {
                Console.WriteLine($"Sua média conclusiva é {Math.Round(Resultado, 1)}");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("RECUPERAÇÃO!");
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine($"Sua média conclusiva é {Math.Round(Resultado, 1)}");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("REPROVADO!");
                Console.ResetColor();
            }
        }
    }
}