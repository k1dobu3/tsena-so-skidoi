using System;

namespace Cost1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите стоимость товара:");
            double c;
            double r;
            double x = Convert.ToInt32(Console.ReadLine());

            if (x >= 500 && x <= 1000)
            {
                c = x * 0.97;
                Console.WriteLine("Цена товара с учетом скидки: " + c);
            }
            else if (x > 1000);
            {
                r = x * 0.95;
                Console.WriteLine("Цена товара с учетом скидки: " + r);
            }

        }
    }
}
