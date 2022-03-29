using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BARSGroupEvents
{
    public class Program
    {
        static void Main(string []args)
        {
            var PressedKey = new EventOnChar();
            PressedKey.OnKeyPressed += PressedKey_OnKeyPressed;
            PressedKey.Run();
        }
        private static void PressedKey_OnKeyPressed(object sender, char e)
        {
            Console.WriteLine($"-{e}");
        }

    }
}