using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepNedarvning
{
    public abstract class Bil
    {
        public int BilPrisExAfgift { get; set; }
        public int BuyYear { get; set; }
        public string Brand { get; set; }
        public string RegNr { get; private set; }
        

        public Bil(int BilPris, int BuyYear, string Brand, string RegNr)
        {
            this.BilPrisExAfgift = BilPrisExAfgift;
            this.BuyYear = BuyYear;
            this.Brand = Brand;
            this.RegNr = RegNr;
            
        }

        public virtual int RegAfgift()
        {
            int Bilpris = BilPrisExAfgift * 105 / 100;
            if (BuyYear <= 2014)
            {
                if (Bilpris <= 80500)
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

        public abstract int HalfYear();

        public abstract int Range();
        
      
    }
}
