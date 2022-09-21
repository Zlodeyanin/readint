using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace readint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GetUserNumber(out int result);
            Console.WriteLine($"Значение конвертации - {result} .\n Завершение работы...");
            Console.ReadLine();
        }

        static int GetUserNumber(out int result)
        {
            bool isWork = true;
            result = 0;

            while (isWork)
            {
                Console.Write("Введите число: \n");
                string userInput = Console.ReadLine();
                int.TryParse(userInput, out int number);
                
                if(number == 0)
                {
                    Console.WriteLine("Конвертация в число не удалась, попробуйте ещё раз!");
                }
                else
                {
                    Console.WriteLine("Конвертация в число прошла успешно!");
                    result = number;
                    isWork = false;                         
                }               
            }
            return result;
        }         
    }
}
