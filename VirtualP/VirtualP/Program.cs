using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualP
{
    class Program:BaseClass
    {
        static int z = 100;
        public override int Add(int x, int y)
        {
            return base.Add(x, y)+z;
        }
        static void Main(string[] args)
        {
            BaseClass baseclass = new BaseClass();
            Console.WriteLine(baseclass.Add(10,10));
            Console.WriteLine(new Program().Add(10,10));
            Console.ReadKey();
        }
    }
    class BaseClass {
        public virtual int Add(int x,int y) {
            return x + y;
        }
    }
}
