using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Bem vindo ao ZimmerWord! Estou pensando em uma palavra de 5 letras, você terá 6 tentativas para adivinhar qual é. Boa sorte!\n\n\n");

        string palavra = "fotos";
        char[] tentativa = new char[6];
        bool correta = false;
        int tentativas = 0;

        // Inicializa a tentativa com underscores
        for (int i = 0; i < 6; i++)
        {
            tentativa[i] = '_';
        }

        do
        {
            Console.WriteLine("\n\nDigite a palavra: \n\n");
            string input = Console.ReadLine();
            tentativas++;

            if (input.Equals(palavra, StringComparison.OrdinalIgnoreCase))
            {
                correta = true;
                break;
            }
            else
            {
                for (int i = 0; i < 5; i++)
                {
                    if (input[i] == palavra[i])
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        bool achou = false;
                        for (int j = 0; j < 5; j++)
                        {
                            if (input[i] == palavra[j] && i != j)
                            {
                                Console.Write("+ ");
                                achou = true;
                                break;
                            }
                        }
                        if (!achou)
                        {
                            Console.Write("_ ");
                        }
                    }
                }
            }

        } while (tentativas < 6);

        if (correta)
        {
            Console.WriteLine("\n\nParabéns! Você acertou a palavra.\n");
        }
        else
        {
            Console.WriteLine($"\n\nSuas tentativas acabaram. A palavra correta era: {palavra}\n");
        }
    }
}
