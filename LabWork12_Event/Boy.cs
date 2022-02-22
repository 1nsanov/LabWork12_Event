using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork12_Event
{
    public class Boy
    {
        public void PrintIll()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Я не могу, я болен");
            Console.ResetColor();
        }
        public void PrintHill()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Ура!!! Я здоров");
            Console.ResetColor();
        }
    }
}
