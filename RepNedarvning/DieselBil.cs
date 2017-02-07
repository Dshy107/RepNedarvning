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
        public bool pf { get; internal set; }

        public DieselBil(int BilPris, int BuyYear, string Brand, string RegNr, int KmPl, bool pf) : base(BilPris, BuyYear, Brand, RegNr, KmPl)
        {
           
            this.Partikelfilter = pf;
        }
        public DieselBil(int BilPris, int BuyYear, string Brand, string RegNr, int KmPl) : this(BilPris, BuyYear, Brand, RegNr, KmPl, true)
        {
            this.Brand = Brand;
            this.BilPrisExAfgift = BilPrisExAfgift;
            this.BuyYear = BuyYear;
            this.KmPl = KmPl;
            
        }

       

        public override int HalfYear()
        {
            if (Partikelfilter!= true)
            {
                return 1000 + 500;
            }
            return 1000;
        }
        public override string ToString()
        {
            return Brand + " " + BilPrisExAfgift + " " + BuyYear + " " + RegNr + " " + KmPl;
        }

    }
}
