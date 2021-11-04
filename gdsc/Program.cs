using System;

namespace gdsc
{
    class Program
    {
        static void Main(string[] args)
        {
            bool logging=true;
            for (int i = 9; i >= 0; i-=2)
            {
                Console.WriteLine(i);
                if(i==7)
                {
                    if(logging==true)
                    {
                        Console.WriteLine("We found 7!");
                    }
                   

                }
            }
            int i = 0;
            do
            {
                Console.WriteLine(i);
                i++;
            } while (false);
        }
       
       /* void Print()
        {
            string name = Console.ReadLine();
            Console.WriteLine("Hello World!");
            Console.WriteLine($"Hello {name}");
        } */
    }
}
