using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumereProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public NumarNatural n = new NumarNatural();

        private void button1_Click(object sender, EventArgs e)
        {
            double d = 0;
            d = 91234567890;
            d+= 91234567890;
            n.addNewNumar("91234567890");
            this.textBox2.Text += "\r\n";
            this.textBox2.Text =  n.printNumar();
            this.textBox2.Text += "\r\n";
            this.textBox2.Text += n.printNumarReverse();
            this.textBox2.Text += "\r\n";
            n = n.adunare(n, n);
            this.textBox2.Text += "\r\n";
            this.textBox2.Text += n.printNumar();
            this.textBox2.Text += "\r\n";
            this.textBox2.Text += n.printNumarReverse();
            this.textBox2.Text += "\r\n";
            this.textBox2.Text += d.ToString();
            this.textBox2.Text += "\r\n";
            if (n.printNumar()!= d.ToString()) { this.textBox2.Text += "\r\n" + " ERROR "; }
        }
    }
}
