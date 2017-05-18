using Simple.PresentLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.Console1
{
    class Program
    {
        public static  void Main(string[] args)
        {
            UserEndpoint m = new UserEndpoint();
            string s = m.GetList();

            Console.WriteLine(s);

            Console.ReadLine();

        }
    } 
}
