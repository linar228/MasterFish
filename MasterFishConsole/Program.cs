using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MasterFishCore;

namespace MasterFishConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Fish test = new Fish("Семга", 13, 24);
            Console.WriteLine(test.Name);
            Console.ReadKey();
        }
    }
}
