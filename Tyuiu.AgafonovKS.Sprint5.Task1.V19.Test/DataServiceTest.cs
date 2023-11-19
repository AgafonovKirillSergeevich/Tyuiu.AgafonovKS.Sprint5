using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.AgafonovKS.Sprint5.Task1.V19.Lib;

namespace Tyuiu.AgafonovKS.Sprint5.Task1.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\Kirya\source\repos\Tyuiu.AgafonovKS.Sprint5\Tyuiu.AgafonovKS.Sprint5.Task1.V19\bin\Debug\OutPutFileTask1.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
