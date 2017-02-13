using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepNedarvning
{
    class ElBil : Bil
    {
        public int BatteriKapacitet { get; private set; }
        public int KmPrKW { get; private set; }
        public ElBil(int BilPris, int BuyYear, string Brand, string RegNr, int BatteriKapacitet, int KmPrKW) : base(BilPris, BuyYear, Brand, RegNr)
        {
            this.BatteriKapacitet = BatteriKapacitet;
            this.KmPrKW = KmPrKW;
        }
        public override int RegAfgift()
        {
            return base.RegAfgift() * 20 / 100;
        }
        public override int HalfYear()
        {
            return 0;
        }

        public override int Range()
        {
            return BatteriKapacitet * KmPrKW;
        }
        public override string ToString()
        {
            return Brand + " " + BilPrisExAfgift + " " + BuyYear + " " + RegNr + " " + BatteriKapacitet + " " + KmPrKW;
        }
    }
}
