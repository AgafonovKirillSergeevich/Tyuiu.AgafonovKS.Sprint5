using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.AgafonovKS.Sprint5.Task6.V18.Lib
{
    public class DataService : ISprint5Task6V18
    {
        public int LoadFromDataFile(string path)
        {
            int count = 0;
            string str = File.ReadAllText(path);
            string[] s = str.Split();
            int n;
            for (int i = 0; i < s.Length; i++)
            {
                if (int.TryParse(s[i], out n) && s[i].Length == 1)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
