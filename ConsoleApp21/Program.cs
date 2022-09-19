using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
  public class Program
    {
        public double d;
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Perem(2,3);
            Console.WriteLine(program.d);
            Console.Read();
        }
        public int Perem(int a , int b)
        {     
            return  a + b;       
        }
    }

}
