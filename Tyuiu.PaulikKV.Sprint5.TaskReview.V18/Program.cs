using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Tyuiu.PaulikKV.Sprint5.TaskReview.V18.Lib;

namespace Tyuiu.PaulikKV.Sprint5.TaskReview.V18
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Паулик К.В. | АСОиУб-23-3";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: TaskReview                                                        *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #13                                                             *");
            Console.WriteLine("* Выполнил: Паулик Кирилл Владимирович | АСОиУб-23-3                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ: Дан файл С:|DataSprint|InPutDataFileTask7V13.txt, в котором    *");
            Console.WriteLine("* есть набор символьных данных. Заменить все буквы н на нн                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string path = @"C:\Users\user\source\repos\Tyuiu.PaulikKV.Sprint5.Review\Tyuiu.PaulikKV.Sprint5.TaskReview.V18\bin\Debug\InPutDataFileTask7V18.txt";
            string result = ds.LoadDataAndSave(path);
            string pathSaveFile = $@"{Directory.GetCurrentDirectory()}\OutPutDataFileTask7V3.txt";
            Console.WriteLine("Данные находятся в файле: " + path);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(" Файл создан ");
            Console.WriteLine(pathSaveFile);
            File.WriteAllText(@"C:\Users\User\source\repos\Tyuiu.PaulikKV.Sprint5.Review\Tyuiu.PaulikKV.Sprint5.TaskReview.V18\bin\Debug\OutPutDataFileTask7V18.txt", result, Encoding.Default);

            Console.ReadKey();
        }
    }
}
