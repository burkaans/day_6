using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_6
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 4; i++) //i=0 - saakums, i<4 - i ir liidz 3, i++ - i=i+1(shaadi arii der), jaaieveero seciiba!
            {
                Console.WriteLine(i);
            }
            int skaititajs = 0;
            while (skaititajs != 5)
            {
                Console.WriteLine(skaititajs);
                skaititajs++;
            }
            Console.ReadLine();
        }
    }
}
