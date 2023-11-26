using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Tyuiu.AgafonovKS.Sprint5.Task7.V4.Lib;

namespace Tyuiu.AgafonovKS.Sprint5.Task7.V4
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнил: Агафонов К. С. | ИИПб-23-1";
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* Спринт #5                                                                    *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                      *");
            Console.WriteLine("* Задание #7                                                                   *");
            Console.WriteLine("* Вариант #4                                                                   *");
            Console.WriteLine("* Выполнил: Агафонов Кирилл Сергеевич | ИИПб-23-1                              *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                     *");
            Console.WriteLine("* Дан файл С:DataSprint5InPutDataFileTask6V18.txt (файл взять из архива        *");
            Console.WriteLine("* согласно вашему варианту. Создать папку в ручную С: DataSprint5 и            *");
            Console.WriteLine("* скопировать в неё файл) в котором есть набор символьных данных.              *");
            Console.WriteLine("* Заменить все русские буквы на #.                                             *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                             *");
            Console.WriteLine("********************************************************************************");

            string path = @"C:\DataSprint5\InPutDataFileTask7V4.txt";
            string pathSaveFile = $@"{Directory.GetCurrentDirectory()}\OutPutFile7.txt";

            Console.WriteLine("Данные находятся в файле: " + path);

            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                   *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("Данные находятся в файле: ");
            pathSaveFile = ds.LoadDataAndSave(path);
            Console.WriteLine(pathSaveFile);
            Console.ReadKey();
        }
    }
}
