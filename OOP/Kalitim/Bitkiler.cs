using System;

namespace Kalitim{
    public class Bitkiler : Canlilar{
        public Bitkiler()
        {
            base.Beslenme();
            base.Bosaltım();
            base.Solunum();
        }
        protected void Fotosentez(){
            Console.WriteLine("Bitkiler Fototentez yapar");
        }
    }

    public class TohumluBitkiler : Bitkiler{
        public TohumluBitkiler()
        {
            base.Fotosentez();
        }
        public void TohumlaCogalma(){
             Console.WriteLine("Bitkiler topumla çoğalır");
        }
    }

    public class TohumsuzBitkiler : Bitkiler{
        public TohumsuzBitkiler()
        {
            base.Fotosentez();
        }
        public void SporlaCogalma(){
             Console.WriteLine("Bitkiler sporla çoğalır");
        }
    }
}