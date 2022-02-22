using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork12_Event
{
    public class Girl
    {
        public string[] Wishs { get; set; }
        private static int CurrentWish { get; set; }
        public Girl()
        {
            Wishs = new string[] {
                "Хочу с тобой играть",
                "Хочу с тобой гулять",
                "Хочу с тобой плавать",
                "Хочу с тобой кататься",
                "Хочу с тобой бегать",
                "Хочу с тобой прыгать",
            };
            CurrentWish = 0; 
        }

        public void PrintWish()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            if (CurrentWish > Wishs.Length)
            {
                CurrentWish = 0;
            }
            Console.WriteLine(Wishs[CurrentWish]);
            CurrentWish++;
            Console.ResetColor();
        }
        public void PrintWishHill()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Хочу, чтобы ты выздоровел");
            Console.ResetColor();
        }
    }
}
