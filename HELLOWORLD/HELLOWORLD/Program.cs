using System;

namespace HELLOWORLD
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("MERHABA \"DÜNYA!\"");
               Console.Write("Text Something! = ");
               string sa=Console.ReadLine();
               Console.WriteLine(sa.GetType());
               Console.Read();*/
            /*int a = 5;
            int b = 4;
            int c = 5;
            Console.WriteLine(a<b);


            while (a <= 10)
            {
                Console.Write(a.ToString() + " ");
                a++;
            }

            Console.WriteLine();

            do
            {
                Console.Write(c.ToString() + " ");
                c++;
            } while (c <= 10);

            Console.WriteLine();
            for (int i = 0; i < b; i++)
            {
                Console.Write((i+1).ToString() + " ");
            }*/

            //string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            /*for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }*/
            /* int i = 0;
             while (i<cars.Length)
             {
                 Console.WriteLine(cars[i]);
                 i++;
             }*/
            /*
            foreach (string item in cars)
            {
                Console.WriteLine(item);
            }
            */

            int[] sayi = new int[] { 5,3,2,8,10,3};
            Array.Sort(sayi);
            for (int i = 0; i < sayi.Length; i++)
            {
                Console.Write(sayi[i].ToString()+" ");
            }
            Console.WriteLine("HELLO WORLD");
            Console.WriteLine("HELLO WORLD");
            Console.Read();
        }
    }
}
