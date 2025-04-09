namespace _09._04._2025
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] b = { 1, 2, 4, 7, 3, 0, 4};

            // task 1
            //int counter = 0;
            //for (int i=0; i< b.Length;i++)
            //{
            //    if (b[i] % 2 == 0)
            //    {
            //        counter++;
            //    }
            //}
            //Console.WriteLine(counter);
            //Console.WriteLine(b.Length - counter);

            //task 2

            //int num = Convert.ToInt32(Console.ReadLine());
            //int counter = 0;
            //for (int i=0; i< b.Length; i++)
            //{
            //    if (b[i] < num)
            //    {
            //        counter++;  
            //    }
            //}
            //Console.WriteLine(counter);


            //task 3

            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = Convert.ToInt32(Console.ReadLine());

            int[] arr = { 7, 6, 5, 3, 4, 7, 6, 5, 8, 7, 6, 5 };

            int[] arr2 = { num1, num2, num3 };

            int counter = 0;

            for(int i =0; i< arr.Length; i++)
            {
                if (arr[i] == arr2[0] && arr[i+1] == arr2[1] && arr[i+2] == arr2[2])
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
