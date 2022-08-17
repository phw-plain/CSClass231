using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSClass2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Wanted<string> wanstedString = new Wanted<string>("String");
            Wanted<int> wanstedInt = new Wanted<int>(52273);
            Wanted<double> wanstedDouble = new Wanted<double>(52.273);
            Console.WriteLine(wanstedString.Value);
            Console.WriteLine(wanstedInt.Value);
            Console.WriteLine(wanstedDouble.Value);
        }
    }
}
