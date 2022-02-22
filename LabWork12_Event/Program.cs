using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork12_Event
{
    class Program
    {
        static void Main(string[] args)
        {
            var flower = new Flower();
            var girl = new Girl();
            var boy = new Boy();

            flower.removeLeafEvent += girl.PrintWish;
            flower.removeLeafEvent += boy.PrintIll;
            flower.removeLastLeafEvent += girl.PrintWishHill;
            flower.removeLastLeafEvent += boy.PrintHill;

            for (int i = 0; i < girl.Wishs.Length; i++)
            {
                flower.RemoveLeafEvent();
            }
            flower.RemoveLastLeafEvent();

            Console.ReadLine();
        }
    }
}
