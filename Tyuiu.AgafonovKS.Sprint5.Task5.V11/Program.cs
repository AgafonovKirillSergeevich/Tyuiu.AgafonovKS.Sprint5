using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Tyuiu.AgafonovKS.Sprint5.Task5.V11.Lib;

namespace Tyuiu.AgafonovKS.Sprint5.Task5.V11
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнил: Агафонов К. С. | ИИПб-23-1";
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* Спринт #5                                                                    *");
            Console.WriteLine("* Тема: Чтение набора данных из текстового файла                               *");
            Console.WriteLine("* Задание #5                                                                   *");
            Console.WriteLine("* Вариант #11                                                                  *");
            Console.WriteLine("* Выполнил: Агафонов Кирилл Сергеевич | ИИПб-23-1                              *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                     *");
            Console.WriteLine("* Дан файл С:DataSprint5InPutDataFileTask5V26.txt (файл взять из архива        *");
            Console.WriteLine("* согласно вашему варианту. Создать папку в ручную С: DataSprint5 и            *");
            Console.WriteLine("* скопировать в неё файл) в котором есть набор значений. Найти                 *");
            Console.WriteLine("* произведение всех нечетных целых чисел в файле                               *");
            Console.WriteLine("* Результат округлить до 3 знаков после запятой. Полученный                    *");
            Console.WriteLine("* результат вывести на консоль. У вещественных значений округлить до           *");
            Console.WriteLine("* трёх знаков после запятой.                                                   *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                             *");
            Console.WriteLine("********************************************************************************");

            string path = @"C:\DataSprint5\InPutDataFileTask5V11.txt";

            Console.WriteLine("Данные находятся в файле: " + path);

            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                   *");
            Console.WriteLine("********************************************************************************");

            double res = ds.LoadFromDataFile(path);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
