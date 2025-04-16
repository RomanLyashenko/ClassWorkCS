using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewNamespace2
{
    internal class even
    {
        private List<int> arr = new List<int>();
        public void arr2(int max)
        {
            this.arr.Add(0);

            for (int i = 0; i < max; i++)
            {
                if(i% 2 == 0)
                {
                    this.arr.Add(i);
                    Console.WriteLine(i);
                }
            }
        }
    }
}
