using System;

namespace Adivinhe_um_número
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declarando as variáveis
            bool jogarDeNovo = true;
            int palpite = 0;
            int palpites = 0;
            int min = 1;
            int max = 100;
            int numero = 0;

            // Criando um objeto que recebe um número aleatório
            Random random = new Random();

            try
            {
                while (jogarDeNovo)
                {
                    // Usando o método Next para gerar um número aleatório entre 1 e 100 e armazenando na variável numero
                    numero = random.Next(min, max + 1);

                    // Enquanto o usuário não acertar o número esse looping vai acontecer
                    while (palpite != numero)
                    {
                        Console.WriteLine($"Adivinhe um número entre {min} e {max}");
                        palpite = Convert.ToInt32(Console.ReadLine());

                        // Dando dicas ao usuário, dependendo se o número que ele digitou for menor ou maior que o número gerado

                        if (palpite < numero)
                        {
                            Console.WriteLine($"{palpite} está baixo");
                        }
                        else if (palpite > numero)
                        {
                            Console.WriteLine($"{palpite} está alto");
                        }
                        // Armazenando o número de vezes que o usuário levou para acertar o número
                        palpites++;
                    }

                    // Exibindo a mensagem que o usuário acertou o número e perguntando se ele deseja jogar de novo
                    Console.WriteLine("----------------------");
                    Console.WriteLine($"Número: {numero}");
                    Console.WriteLine("Você acertou!");
                    Console.WriteLine($"Palpites: {palpites}");
                    Console.WriteLine("----------------------");
                    Console.WriteLine("Gostaria de jogar de novo?");
                    Console.WriteLine("Y = yes, N = No");

                    if (Console.ReadLine().ToUpper() == "Y")
                    {
                        jogarDeNovo = true;
                        // [Erro corrigido] ao iniciar o jogo novamente o número de palpites permanecia o mesmo, quando o jogo iniciar novamente os palpites serão zerados
                        palpites = 0;
                    }
                    else
                    {
                        jogarDeNovo = false;
                    }
                }

            }
            // Captando excessões
            catch (Exception)
            {
                Console.WriteLine("Algo está errado. Verifique o valor informado e tente novamente.");
            }

            Console.WriteLine("Obrigado por jogar!");

            Console.ReadLine();
        }
    }
}
