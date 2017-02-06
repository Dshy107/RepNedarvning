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
        public DieselBil(int BilPris, int BuyYear, string Brand, string RegNr, int KmPl, bool pf) : base(BilPris, BuyYear, Brand, RegNr, KmPl)
        {
            this.Brand = Brand;
            this.BilPrisExAfgift = BilPrisExAfgift;
            this.BuyYear = BuyYear;
            this.KmPl = KmPl;
            this.Partikelfilter = pf;
        }
        public DieselBil(int pris) : this(pris, true)
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
                return base.HalfYear() + 500;
            }
            return base.HalfYear();
        }
        
    }
}
