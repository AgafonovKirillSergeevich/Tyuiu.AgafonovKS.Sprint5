using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Tyuiu.AgafonovKS.Sprint5.Task6.V18.Lib;

namespace Tyuiu.AgafonovKS.Sprint5.Task6.V18
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнил: Агафонов К. С. | ИИПб-23-1";
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* Спринт #5                                                                    *");
            Console.WriteLine("* Тема: Обработка текстовых файлов                                             *");
            Console.WriteLine("* Задание #6                                                                   *");
            Console.WriteLine("* Вариант #18                                                                  *");
            Console.WriteLine("* Выполнил: Агафонов Кирилл Сергеевич | ИИПб-23-1                              *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                     *");
            Console.WriteLine("* Дан файл С:DataSprint5InPutDataFileTask6V18.txt (файл взять из архива        *");
            Console.WriteLine("* согласно вашему варианту. Создать папку в ручную С: DataSprint5 и            *");
            Console.WriteLine("* скопировать в неё файл) в котором есть набор символьных данных.              *");
            Console.WriteLine("* Найти количество одноразрядных чисел в заданной строке.                      *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                             *");
            Console.WriteLine("********************************************************************************");

            string path = @"C:\DataSprint5\InPutDataFileTask6V18.txt";

            Console.WriteLine("Данные находятся в файле: " + path);

            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                   *");
            Console.WriteLine("********************************************************************************");

            double res = ds.LoadFromDataFile(path);
            Console.WriteLine($"Количество одноразрядных чисел = {res}");
            Console.ReadKey();
        }
    }
}
