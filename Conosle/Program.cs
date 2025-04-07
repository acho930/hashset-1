using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conosle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 5, 3, 7, 3, 9, 5, 1, 7, 2 };
            HashSet<int> uniqueNumbers =new HashSet<int>(numbers);
            Console.WriteLine("Unikalni cisla");
            foreach(int num in uniqueNumbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}
