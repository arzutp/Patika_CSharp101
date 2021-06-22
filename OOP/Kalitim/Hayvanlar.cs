using System;

namespace Kalitim{
        
    public class Hayvanlar : Canlilar{
        public Hayvanlar()
        {
            base.Beslenme();
            base.Bosaltım();
            base.Solunum();
        }
        protected void Adaptasyon(){
            Console.WriteLine("Hayvanlar adaptasyon yapar");
        }
    }

    public class Surungenler : Hayvanlar{
        public Surungenler()
        {
            base.Adaptasyon();
        }
        public void Surunerek(){
            Console.WriteLine("Sürünerek hareket eder");
        }
    }

    public class Kuslar : Hayvanlar{
        public Kuslar()
        {
            base.Adaptasyon();
        }
        public void Ucmak(){
            Console.WriteLine("Ucarak hareket eder");
        }
    }
}