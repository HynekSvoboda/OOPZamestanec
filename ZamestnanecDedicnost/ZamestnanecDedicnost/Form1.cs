using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZamestnanecDedicnost
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
        }
        Zamestnanec zamestnanec;
        Vedouci vedouci;

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                zamestnanec.OdpracujHodiny((int)numericUpDown2.Value);
                label5.Text = zamestnanec.ToString();
            }
            else
            {
                vedouci.OdpracujHodiny((int)numericUpDown2.Value);
                label5.Text = vedouci.ToString();
            }
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            zamestnanec = new Zamestnanec(textBox1.Text, textBox2.Text, dateTimePicker1.Value, (int)numericUpDown1.Value);
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            vedouci = new Vedouci(textBox1.Text, textBox2.Text, dateTimePicker1.Value, (int)numericUpDown1.Value, (int)numericUpDown3.Value, textBox3.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vytvořte třídu Zamestnanec, která bude obsahovat:\r\n Soukromý atribut jméno\r\n Soukromý atribut příjmen\r\n Soukromý atribut datumNastupu\r\n Vlastnost HodinovaMzda pouze pro čtení – mzda v Kč za hodinu\r\n Soukromý atribut odpracHodiny inicializovaný na 0 – eviduje celkový počet\r\nodpracovaných hodin\r\nTřída bude obsahovat jediný konstruktor\r\n Nastaví jméno, příjmení, datum nástupu, hodinovou mzdu\r\nTřída bude obsahovat metody:\r\n PocetDni - vrátí počet dní od nástupu do zaměstnání\r\n OdpracujHodiny – zvýší odpracované hodiny o zadaný počet\r\n VypoctiMzdu – na základě hodinové mzdy a odpracovaných hodin vypočítá mzdu\r\n Vypis – bude vracet víceřádkový text se všemi údaji o zaměstnanci včetně\r\nvypočítané mzdy\r\nVytvořte třídu Vedouci odvozenou od třídy Zamestnanec.\r\nTřída zdědí všechny atributy, vlastnosti a metody od zaměstnance a navíc bude\r\nobsahovat:\r\n Soukromý atribut priplatekZaVedeni – pevná částka, o kterou se bude zvyšovat\r\nvypočítaná mzda.\r\n Soukromý atribut titul\r\n\r\nKonstruktor nastaví stejné údaje jako předek a navíc nastaví příplatek za vedení a titul.\r\nVyužijte konstruktor předka.\r\nPřepište metodu VypoctiMzdu – celková mzda bude zvýšena o příplatek za vedení.\r\nVyužijte metodu předka.\r\nVytvořte instanci třídy Vedouci a vyzkoušejte v programu.\r\nPři kliku na RadioButtons vytvořte instanci Zaměstnance nebo Vedoucího. Při kliku na\r\ntlačítko nastavte počet odpracovaných hodin a objekt vypište a vypište i jeho plat.");
        }
    }
}
