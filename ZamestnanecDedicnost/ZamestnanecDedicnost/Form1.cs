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
    }
}
