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
        protected DateTime datumnastupu;
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
            this.datumnastupu = datumnastupu;
            this.hodinovaMzda = hodinovamzda;
        }

        public int PocetDni()
        {
            int pomocna = 0;
            TimeSpan rozdil = DateTime.Now - datumnastupu;
            pomocna = (int)rozdil.TotalDays;
            return pomocna; 
        }
        public int OdpracujHodiny(int pocethodin)
        {
           return odpracHodiny += pocethodin;
        }
        public int VypoctiMzdu()
        {
            int mzda = HodinovaMzda*odpracHodiny;
            return mzda;
        }
        public override string ToString()
        {
            return "Jmeno " + jmeno + " prijmeni" + prijmeni + " datum nastupu: " + datumnastupu.ToString() +"tvoje hodinova mzda"+hodinovaMzda+" odpracovane hodiny"+OdpracujHodiny().ToString()+" tvoje mzda" + VypoctiMzdu().ToString();
        }
    }
}
