using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Tyuiu.PasechnikPA.Sprint1.Task6.V8.Lib;

namespace Tyuiu.PasechnikPA.Sprint1.Task6.V8
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                DataService ds = new DataService();

                Console.Title = "Спринт #1 | Выполнил: Пасечник П. А. | АСОиУБ-23-2";

                Console.WriteLine("***************************************************************************");
                Console.WriteLine("* Спринт #1                                                               *");
                Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
                Console.WriteLine("* Задание #6                                                              *");
                Console.WriteLine("* Варинант #8                                                             *");
                Console.WriteLine("* Выполнил: Пасечник Павел Андреевич | АСОиУБ-23-2                        *");
                Console.WriteLine("***************************************************************************");
                Console.WriteLine("* УСЛОВИЕ:                                                                *");
                Console.WriteLine("*аписать программу: пользователь вводит текст. Напечатать все слова,      *");
                Console.WriteLine("* перенеся их первую букву в конец.                                       *");
                Console.WriteLine("***************************************************************************");
                Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
                Console.WriteLine("***************************************************************************");
                

                Console.WriteLine("Введите текст через пробел: ");
                String str = Console.ReadLine();
                


                Console.WriteLine("***************************************************************************");
                Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
                Console.WriteLine("***************************************************************************");
                var v = str.Split(' ');
                foreach (String c in v)

                    Console.WriteLine(c.PadRight(c.Length + 1, c[0]).Remove(0, 1));
                Console.ReadKey();
               
                    
                
            }
        }
    }
}
