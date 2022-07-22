using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GAZ.CSHcourse2022.consoleapp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;
            while ((line = Console.ReadLine()) != null)
            {
                line = line.Replace(",", " y:");
                line = "x:" + line;
                Console.WriteLine(line);
            }
        }
    }
}
