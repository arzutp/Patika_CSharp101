using System;

namespace Kalitim
{
    class Program
    {
        static void Main(string[] args)
        {
            TohumluBitkiler tohumluBitkiler = new TohumluBitkiler();
            tohumluBitkiler.TohumlaCogalma();

            Console.WriteLine("--------Martı---------");
            Kuslar marti = new Kuslar();
            marti.Ucmak();
        }
    }
}
