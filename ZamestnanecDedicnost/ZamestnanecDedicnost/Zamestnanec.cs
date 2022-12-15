using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZamestnanecDedicnost
{
    
    class Zamestnanec
    {
        protected string jmeno;
        protected string prijmeni;
        protected DateTime datumNastupu;
        protected int hodinovaMzda;
        protected int odpracHodiny = 0;
        public int HodinovaMzda
        {
            get
                {
                return hodinovaMzda;
                }
        }

        public Zamestnanec(string jmeno, string prijmeni, DateTime datumnastupu, int hodinovamzda)
        {
            this.jmeno = jmeno;
            this.prijmeni = prijmeni;
            this.datumNastupu = datumnastupu;
            this.hodinovaMzda = hodinovamzda;
        }

        public int PocetDni()
        {
            int pomocna = 0;
            TimeSpan rozdil = DateTime.Now - datumNastupu;
            pomocna = (int)rozdil.TotalDays;
            if (pomocna < 0) return 0;
            else return pomocna; 
        }
        public int OdpracujHodiny(int pocethodin)
        {
           return odpracHodiny += pocethodin;
        }
        public virtual int VypoctiMzdu()
        {
            int mzda = HodinovaMzda*odpracHodiny;
            return mzda;
        }
        public override string ToString()
        {
            return jmeno + prijmeni + ", datum nastupu: " + datumNastupu.ToShortDateString() +", tvoje hodinova mzda "+hodinovaMzda+",\nodpracovane hodiny "+odpracHodiny.ToString()+", tvoje mzda " + VypoctiMzdu().ToString()+", pocet dni od nastupu "+PocetDni().ToString();
        }
    }
}
