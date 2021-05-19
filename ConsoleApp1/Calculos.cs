using System;
using System.Collections.Generic;
using System.Linq;

namespace CalculosConsole
{
    public class Calculos
    {
        public static void CalculaMedia()
        {
            List<double> itens = new List<double>();
            int totalItens = 0;
            Console.Write("Informe a quantidade de itens: ");
            try
            {
                totalItens = Convert.ToInt32(Console.ReadLine());
            }
            catch 
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("É necessário informar um número");
                Console.ResetColor();
                throw;
            }

            int i = 0;
            while (i < totalItens)
            {
                i++;
                try
                {
                    Console.Write("Informe o " + i + "º item : ");
                    itens.Add(Convert.ToDouble(Console.ReadLine()));
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("É necessário informar um número");
                    Console.ResetColor();
                    throw;
                }
            }

            var media = itens.Sum() / totalItens;
            Console.WriteLine("A média é " + media);
        }
    }
}
