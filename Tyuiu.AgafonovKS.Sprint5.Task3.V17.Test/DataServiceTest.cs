using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.AgafonovKS.Sprint5.Task3.V17.Lib;

namespace Tyuiu.AgafonovKS.Sprint5.Task3.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\kirya\source\repos\Tyuiu.AgafonovKS.Sprint5\Tyuiu.AgafonovKS.Sprint5.Task3.V17\bin\Debug\OutPutFileTask3.bin";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
