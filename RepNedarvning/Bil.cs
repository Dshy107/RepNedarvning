using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepNedarvning
{
    public class Bil
    {
        public int BilPrisExAfgift { get; set; }
        public int BuyYear { get; set; }
        public string Brand { get; set; }
        public string RegNr { get; private set; }
        public int KmPl { get; set; }

        public Bil(int BilPris, int BuyYear, string Brand, string RegNr, int KmPl)
        {
            this.BilPrisExAfgift = BilPrisExAfgift;
            this.BuyYear = BuyYear;
            this.Brand = Brand;
            this.RegNr = RegNr;
            this.KmPl = KmPl;
        }

        public virtual int RegAfgift()
        {
            int Bilpris = BilPrisExAfgift * 105 / 100;
            if (BuyYear <= 2014)
            {
                if (Bilpris > 80500)
                {
                    int Efterpris = Bilpris - 80500;
                    Bilpris = Bilpris - Efterpris;
                    Efterpris = Efterpris * 180 / 100;
                    Bilpris = Efterpris + Bilpris;
                    return Bilpris;
                }
            }
            else if(BuyYear >= 2015)
            {
                
                if (Bilpris > 81700)
                {
                    int Efterpris = Bilpris - 81700;
                    Bilpris = Bilpris - Efterpris;
                    Efterpris = Efterpris * 180 / 100;
                    Bilpris = Efterpris + Bilpris;
                    return Bilpris;
                }
            }
            return Bilpris;
        }

        public int TotalPris()
        {
            return BilPrisExAfgift;
        }

        public virtual int HalfYear()
        {
            return 1000;
        }
      
    }
}
