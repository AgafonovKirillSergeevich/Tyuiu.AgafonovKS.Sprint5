using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Tyuiu.AgafonovKS.Sprint5.Task3.V17.Lib;

namespace Tyuiu.AgafonovKS.Sprint5.Task3.V17
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнил: Агафонов К. С. | ИИПб-23-1";
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* Спринт #5                                                                    *");
            Console.WriteLine("* Тема: Потоковый метод записи данных в бинарный файл                          *");
            Console.WriteLine("* Задание #3                                                                   *");
            Console.WriteLine("* Вариант #17                                                                  *");
            Console.WriteLine("* Выполнил: Агафонов Кирилл Сергеевич | ИИПб-23-1                              *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                     *");
            Console.WriteLine("* Дано выражение, вычислить его значение при x = 3, результат сохранить        *");
            Console.WriteLine("*  в бинарный файл OutPutFileTask3.bin и вывести на консоль.                   *");
            Console.WriteLine("* Округлить до трёх знаков после запятой.                                      *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                             *");
            Console.WriteLine("********************************************************************************");

            int x = 3;
            Console.WriteLine("x = " + x);

            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                   *");
            Console.WriteLine("********************************************************************************");

            string res = ds.SaveToFileTextData(x);
            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Cоздан!");
            Console.ReadKey();
        }
    }
}
