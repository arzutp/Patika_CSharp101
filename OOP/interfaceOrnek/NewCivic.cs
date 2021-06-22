using System;

namespace interfaceOrnek
{
    public class NewCivic : Otomobil
    {
        public override Marka HangiMarka()
        {
            return Marka.Honda;
        }

        public override Renk StandartRengi()
        {
            return Renk.Gri;
        }
    }
}