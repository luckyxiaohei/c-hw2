using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw2
{

    static class staticClass
    {
        public static int SC(string[] args)
        {
            if(args.Length < 1)
            {
                Console.WriteLine(args[0]);
            }
            else
            {
                Console.WriteLine(args[1] + args[2]);
            }
            return 0;

        }
    }

    class noneStatic
    {
        public int NSC(string[] args)
        {
            if (args.Length < 1)
            {
                Console.WriteLine(args[0]);
            }
            else
            {
                Console.WriteLine(args[1] + args[3]);
            }
            return 0;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            noneStatic nsc = new noneStatic();
           int a = nsc.NSC(args);
         
           int c= staticClass.SC(args);
            Console.ReadKey();
        }
    }
}
