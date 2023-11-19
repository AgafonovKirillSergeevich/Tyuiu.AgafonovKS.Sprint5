using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.AgafonovKS.Sprint5.Task0.V18.Lib;


namespace Tyuiu.AgafonovKS.Sprint5.Task0.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\Kirya\source\repos\Tyuiu.AgafonovKS.Sprint5\Tyuiu.AgafonovKS.Sprint5.Task0.V18\bin\Debug\OutPutFileTask0.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
