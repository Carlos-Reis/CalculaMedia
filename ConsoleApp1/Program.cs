using System;

namespace CalculosConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            bool restart = true;
            int operacao = 0;
            do
            {
                #region Cabeçalho Console
                Console.Clear();
                Console.WriteLine("Programa que faz cálculos");
                Console.WriteLine("Indique a operação desejada:");
                Console.WriteLine("1. Calcular Média");
                #endregion

                #region Operações
                try
                {
                    try
                    {
                        operacao = Convert.ToInt32(Console.ReadLine());
                    }
                    catch
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("Por favor, digite um número para selecionar a operação");
                        throw;
                    }

                    switch (operacao)
                    {
                        case 1:
                            Calculos.CalculaMedia();
                            break;
                        default:
                            Calculos.CalculaMedia();
                            break;
                    }
                }
                catch
                {
                    Console.ResetColor();
                    Console.WriteLine("\r\n");
                }
                #endregion

                Console.WriteLine("Aperte R para recomeçar ou qualquer outra tecla para encerrar");

                var end = Console.ReadKey();
                if (end.Key != ConsoleKey.R)
                {
                    restart = false;
                }
            }
            while (restart);
        }
    }
}
