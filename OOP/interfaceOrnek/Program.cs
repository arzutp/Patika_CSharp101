using System;

namespace interfaceOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            Focus focus = new Focus();
            Console.WriteLine(focus.HangiMarka().ToString());
            Console.WriteLine(focus.StandartRengi().ToString());
            Console.WriteLine(focus.KacTekerlek().ToString());
            
            Civic civic = new Civic();
            Console.WriteLine(focus.HangiMarka().ToString());
            
            
        }
    }
}
