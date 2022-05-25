using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Drawer
    {
        public void Draw()
        {
            for (int yFun = 0; yFun < height; yFun++)
            {
                Console.WriteLine();
                Console.Write($"{yFun}");
                for (int i = 0; i < width; i++)
                {
                    Console.Write("@");
                }
            }
        }
    }
}
