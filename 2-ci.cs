using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _222
{
    class Program
    {
        static void Main(string[] args)
        {



            Console.WriteLine("Eded daxil edin");
            int eded = Convert.ToInt32(Console.ReadLine());
            int result = _sade(eded);
            if (result == 0)
            {
                Console.WriteLine("{0}sade eded deyil", eded);
            }
            else
            {
                Console.WriteLine("{0} sade ededdir", eded);
            }
            Console.Read();
        }

        static  int _sade(int eded)
        {
            int i;
            for (i = 2; i <= eded - 1; i++)
            {
                if (eded % i == 0)
                {
                    return 0;
                }
            }
            if (i == eded)
            {
                return 1;
            }
            return 0;


        }

    }
}
    
    
    











   
