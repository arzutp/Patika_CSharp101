using System;

namespace interfaceOrnek
{
    public class Corolla : IOtomobil
    {
        public Marka HangiMarka()
        {
            return Marka.Ford;
        }

        public int KacTekerlek()
        {
            return 4;
        }

        public Renk StandartRengi()
        {
            return Renk.Beyaz;
        }
    }
}