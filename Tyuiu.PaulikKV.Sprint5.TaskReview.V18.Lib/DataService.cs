using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.PaulikKV.Sprint5.TaskReview.V18.Lib
{
    public class DataService : ISprint5Task7V18
    {
        public string LoadDataAndSave(string path)
        {
            string file = @"C:\Users\user\source\repos\Tyuiu.PaulikKV.Sprint5.Review\Tyuiu.PaulikKV.Sprint5.TaskReview.V18\bin\Debug\InPutDataFileTask7V18.txt";
            string result;
            using (StreamReader streamReader = File.OpenText(file))
            {
                string str = streamReader.ReadToEnd();
                result = str.Replace("н", "нн");
            }
            return result;
        }
    }
}
