using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepNedarvning
{
    public class DieselBil : Bil
    {
        

        public bool Partikelfilter { get; private set; }
        public int Tank { get; set; }
        public bool pf { get; internal set; }

        public DieselBil(int BilPris, int BuyYear, string Brand, string RegNr, int KmPl, bool pf, int Tank) : base(BilPris, BuyYear, Brand, RegNr, KmPl)
        {
           
            this.Partikelfilter = pf;
            this.Tank = Tank;
        }
        public DieselBil(int BilPris, int BuyYear, string Brand, string RegNr, int KmPl, int Tank) : this(BilPris, BuyYear, Brand, RegNr, KmPl, true, Tank)
        {
            this.Brand = Brand;
            this.BilPrisExAfgift = BilPrisExAfgift;
            this.BuyYear = BuyYear;
            this.KmPl = KmPl;
            this.Tank = Tank;
        }

       public override int Range()
        {
            return KmPl * Tank;
        }

        public override int HalfYear()
        {
            if (KmPl <= 15)
            {
                return 2000;
            }
            else
            {
                if (KmPl <= 15 && KmPl <= 25)
                {
                    return 1000;
                }
                else
                {
                    if (KmPl > 25)
                    {
                        return 350;
                    }
                }
            }
            if (Partikelfilter!= true)
            {
                return 1000 + 500;
            }
            return 1000;
        }
        public override string ToString()
        {
            return Brand + " " + BilPrisExAfgift + " " + BuyYear + " " + RegNr + " " + KmPl + " " + Tank;
        }

    }
}
