using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZamestnanecDedicnost
{
    internal class Vedouci : Zamestnanec
    {
         int priplatekZaVedeni;
        string titul;
        public Vedouci(string jmeno, string prijmeni, DateTime datumnastupu, int hodinovamzda, int priplatekZaVedeni,string titul) : base (jmeno, prijmeni, datumnastupu, hodinovamzda)
        {
            this.priplatekZaVedeni = priplatekZaVedeni;
            this.titul = titul;
            base.prijmeni+=" a jeho titul "+titul;
        }
        public override int VypoctiMzdu()
        {
            int vypocet= (HodinovaMzda * odpracHodiny)+priplatekZaVedeni;
            return vypocet;
        }
    }
}