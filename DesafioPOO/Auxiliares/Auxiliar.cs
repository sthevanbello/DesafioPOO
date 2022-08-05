using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioPOO.Auxiliares
{
    public static class Auxiliar
    {
        public static bool ExibirOpcoes()
        {
            Console.WriteLine();
            bool fim = false;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Insira a opção desejada\n");
            Console.ResetColor();
            Console.Write("Digite ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("1 ");
            Console.ResetColor();
            Console.Write("- Sim, iniciar uma corrida\n");
            Console.Write("Digite ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("2 ");
            Console.ResetColor();
            Console.Write("- Não, sair do programa\n");

            ExibirDivisoriaHorizontal(".-");
            while (!fim)
            {
                Console.Write("Opção: ");
                int escolha = 0;
                bool digitou = int.TryParse(Console.ReadLine(), out escolha);

                if (digitou)
                {
                    if (escolha == 1)
                    {
                        return true;
                    }
                    else if (escolha == 2)
                    {
                        return false;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nDigite uma opção válida - 1 para Voltar ou 2 para Sair");
                        Console.ResetColor();
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nDigite uma opção válida - 1 para Voltar ou 2 para Sair");
                    Console.ResetColor();
                }
            }
            return false;
        }
        public static void Sair(string simbolo)
        {
            // Essa função serve para criar a moldura e colocar a frase no meio da tela utilizando o Console.SetCursorPosition

            Console.Clear();
            ExibirDivisoriaHorizontal("+");
            Console.ForegroundColor = ConsoleColor.Green;
            for (int i = 0; i < 20; i++)
            {
                Console.Write(simbolo);
                for (int j = 1; j < 120 - 1; j++)
                {
                    if (i == 10 && j == 48)
                    {
                        Console.SetCursorPosition(0, 10); // Essa função coloca o cursor na posição desejada. Console.SetCursorPosition(horizontal, vertical)
                        Console.Write(simbolo);
                        Console.SetCursorPosition(119, 10);
                        Console.Write(simbolo);
                        Console.SetCursorPosition(47, 10);
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Opção selecionada: Sair");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.SetCursorPosition(0, 11);
                        Console.Write(simbolo);
                        Console.SetCursorPosition(119, 11);
                        Console.Write(simbolo);
                        Console.SetCursorPosition(49, 12);
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Obrigado e até mais!");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.SetCursorPosition(0, 12);
                        Console.Write(simbolo);
                        Console.SetCursorPosition(119, 12);
                        Console.Write(simbolo);
                        Console.SetCursorPosition(119, 12);
                        break;
                    }
                    Console.Write(" ");
                }
                Console.Write(simbolo);
            }
            ExibirDivisoriaHorizontal("+");
            Console.ResetColor();
            Environment.Exit(0); // Essa função sai do programa e encerra a aplicação
        }
        public static void Sair()
        {
            Console.Clear();
            Console.WriteLine("Até mais...");
            Environment.Exit(0);
        }

        public static void ExibirDivisoriaHorizontal(string simbolo)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            for (int i = 0; i < Console.WindowWidth / simbolo.Length; i++)
            {
                Console.Write(simbolo);
            }
            Console.ResetColor();
            Console.WriteLine();
        }
    }
}
