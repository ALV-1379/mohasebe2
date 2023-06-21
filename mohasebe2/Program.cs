using System;

namespace mohasebe2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("adad aval ra vared konid");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("adad dovom ra vared konid");
            int y = Convert.ToInt32(Console.ReadLine());

            int a = (int)Math.Pow(x, 5);
            int b = (int)Math.Pow(x, 4);
            int c = a + 2 * b;
            int k = (int)Math.Pow(y, 2);
            k = k - 7;
            Console.WriteLine($"javab soal = {c * k}");
            Console.ReadKey();


        }
    }
}
