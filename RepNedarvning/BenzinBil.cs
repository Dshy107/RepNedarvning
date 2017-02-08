using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepNedarvning
{
    public sealed class BenzinBil : Bil
    {
        public int Tank { get; set; }
        public BenzinBil(int BilPris, int BuyYear, string Brand, string RegNr, int KmPl, int Tank) : base(BilPris, BuyYear, Brand, RegNr, KmPl)
        {
            this.Tank = Tank;
        }
        public override int Range()
        {
            return KmPl * Tank;
        }
        public override int HalfYear()
        {
            if (KmPl <= 20)
            {
                return 1200;
            }
            else
            {
                if (KmPl <= 20 && KmPl <= 28)
                {
                    return 600;
                }
                else
                {
                    if (KmPl > 28)
                    {
                        return 320;
                    }
                }
            }
            
            return 1000;
        }
        public override string ToString()
        {
            return Brand + " " + BilPrisExAfgift + " " + BuyYear + " " + RegNr + " " + KmPl;
        }
    }
    }
}
