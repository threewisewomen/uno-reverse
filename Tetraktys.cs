using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uno_reverse
{
    public class Tetraktys
    {
        public void TetraktysMain()
        {
            int decad = 10;
            int counter = 0;
            for (int i = 1; i <= decad; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                    counter += 1;

                }
                Console.WriteLine("---");
                if (counter == decad)
                {
                    break;
                }

            }
        }
    }
}
