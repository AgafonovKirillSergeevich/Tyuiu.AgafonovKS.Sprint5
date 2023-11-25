using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.AgafonovKS.Sprint5.Task5.V11.Lib
{
    public class DataService : ISprint5Task5V11
    {
        public double LoadFromDataFile(string path)
        {

            using (StreamReader sr = new StreamReader(path))
            {
                int product = 1;

                string[] strNumbs = File.ReadAllLines(path);

                foreach (string line in strNumbs)
                    {                       
                        string[] numbers = line.Split(' ');

                        foreach (string number in numbers)
                        {
                            if (int.TryParse(number, out int parsedNumber))
                            {
                                if (parsedNumber % 2 != 0)
                                {
                                    product *= parsedNumber;
                                }
                            }
                            
                        }
                    }
                    return product;
            }
        }
    }
}
