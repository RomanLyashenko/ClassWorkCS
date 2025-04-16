using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewNamespace3
{
    internal class prime
    {
        private List<int> arr = new List<int>();

        public void arr4(int max)
        {
            for (int i = 2; i < max; i++)
            {
                bool flag = false;

                for (int j = 2; j * j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        flag = true;
                        break;
                    }
                }

                if (!flag)
                {
                    this.arr.Add(i);
                    Console.WriteLine(i);
                }
            }
        }
    }
}
