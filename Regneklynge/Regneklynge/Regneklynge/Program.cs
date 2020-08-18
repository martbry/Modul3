using System;

namespace Regneklynge
{
    class Program
    {
        static void Main(string[] args)
        {
            Regneklynge regneklynge1 = new Regneklynge();

            for (int i = 0; i < 101; i++)
            { 
                regneklynge1.InsertNode(4, 1024);
            }

            Console.WriteLine(regneklynge1.RackCount());
            Console.WriteLine(regneklynge1.CpuCount());
        }
    }
}
