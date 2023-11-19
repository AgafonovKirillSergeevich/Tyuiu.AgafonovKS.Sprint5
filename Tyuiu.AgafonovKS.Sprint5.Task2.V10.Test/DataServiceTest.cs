using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.AgafonovKS.Sprint5.Task2.V10.Lib;

namespace Tyuiu.AgafonovKS.Sprint5.Task2.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\kirya\source\repos\Tyuiu.AgafonovKS.Sprint5\Tyuiu.AgafonovKS.Sprint5.Task2.V10\bin\Debug\OutPutFileTask2.csv";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
