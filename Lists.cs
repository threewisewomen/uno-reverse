using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uno_reverse
{
    public class Lists
    {
        public static int SearchInList(List<int> F, int x)
        {
            for (int i = 0; i < F.Count; i++)
            {
                if (F[i] == x)
                {
                    Console.WriteLine($"{F[i]} is in position {i}");
                    return F[i];
                }
            }
            return -1;
        }

        public static List<int> SortList(List<int> F)
        {
            int cunter = 0;
            int temp = 0;
            for(int j  = 0; j < F.Count;j++)
            {
                for (int i = 0; i < F.Count; i++)
                {
                    if (i + 1 == F.Count)
                    {
                        break;
                    }

                    if (F[i] > F[i + 1])
                    {
                        temp = F[i];
                        F[i] = F[i + 1];
                        F[i + 1] = temp;
                    }
                    cunter++;
                }

            }
            Console.WriteLine(cunter);
            return F;
        }
        public static List<int> AddList(List<int> X, List<int> Y)
        {
            List<int> sumList = new List<int>();
            for (int i = 0; i < X.Count; i++)
            {
                sumList.Add(X[i] + Y[i]);
            }
            return sumList;
        }

    }

}
