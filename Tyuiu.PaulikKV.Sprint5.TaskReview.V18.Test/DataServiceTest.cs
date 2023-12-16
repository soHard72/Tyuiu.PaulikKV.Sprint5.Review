using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.PaulikKV.Sprint5.TaskReview.V18.Lib;

namespace Tyuiu.PaulikKV.Sprint5.TaskReview.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\user\source\repos\Tyuiu.PaulikKV.Sprint5.Review\Tyuiu.PaulikKV.Sprint5.TaskReview.V18\bin\Debug\InPutDataFileTask7V18.txt";
            FileInfo fileinfo = new FileInfo(path);
            bool fileexists = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileexists);
        }

        public void CheckedExistsFileOutPut()
        {
            string path = @"C:\Users\User\source\repos\Tyuiu.PaulikKV.Sprint5.Review\Tyuiu.PaulikKV.Sprint5.TaskReview.V18\bin\Debug\OutPutDataFileTask7V18.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
