using System;

namespace HelloWorld6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("a");
            int a = 5;
            Console.WriteLine("b");
            int b = 6;
            Console.WriteLine("c");
            int c = 7;
            if (a > b)
            {
                if (c > a)
                {
                    Console.WriteLine(c);
                    Console.WriteLine(a);
                    Console(WriteLine(b);
                } else if (b > c)
                {
                    Console.WriteLine(a);
                    Console.WriteLine(b);
                    Console.WriteLine(c);

                }
                else
                {
                    Console.WriteLine(a);
                    Console.WriteLine(c);
                    Console.WrtiteLine(b);
                }
            }
            else
            {
                if (c > b)
                {
                    Console.WriteLine(c);
                    Console.WriteLine(b);
                    Console.WriteLine(a);
                }

                else if(a>c)
                {
                    Console.WriteLine(b);
                    Console.WriteLine(a);
                    Console.WriteLine(c);

                }
                else
                {
                    Console.WriteLine(b);
                    Console.WriteLine(c);
                    Console.WriteLine(a);
                }
                    
                
            }
        }
    }
}
