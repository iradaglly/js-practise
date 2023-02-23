using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double skafx = 1, skafy = 4 , skafz=5.5;
            double doorx = 4, doory = 4;

            if (((doorx >= skafx) && (doory >= skafy)))
            {
                Console.WriteLine("kece biler.");
            }
            else if ((doorx >= skafz) && (doory >= skafx))
            {
                Console.WriteLine("kece biler.");
            }
            else if ((doorx >= skafy) && (doory >= skafz))
            {
                Console.WriteLine("kece biler.");
            }
            else if (((doorx >= skafy) && (doory >= skafz)) || ((doorx >= skafx) && (doory >= skafy)))
            {
                Console.WriteLine("kece biler.");
            }
            else if (((doorx >= skafy) && (doory >= skafz)) || ((doorx >= skafz) && (doory >= skafx)))
            {
                Console.WriteLine("kece biler.");
            }
            else
            {
                Console.WriteLine("Kece bilmez!");
            }
        }
    }
}
