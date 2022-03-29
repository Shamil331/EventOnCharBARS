using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BARSGroupEvents
{
    public class EventOnChar
    {
        public event EventHandler<char> ? OnKeyPressed;
        public void Run()
        {
            char PressedChar = Console.ReadKey().KeyChar;
            while (PressedChar!='c')
            {
                OnKeyPressed?.Invoke(this, PressedChar);
                PressedChar=Console.ReadKey().KeyChar;
            }
            Console.WriteLine("\nБыла нажата 'c'");
        }
    }
}
