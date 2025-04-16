using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewNamespace4
{
    internal class fibonacci
    {
        private List<int> arr = new List<int>();
        public void arr1(int max)
        {
            this.arr.Add(0);
            this.arr.Add(1);

            for (int i = 2; i < max; i++)
            {
                this.arr.Add(this.arr[i - 1] + this.arr[i - 2]);
                Console.WriteLine(arr[i]);
            }
        }
        
    }
}
