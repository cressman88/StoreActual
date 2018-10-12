using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media; 

namespace StoreActual
{
    public partial class Form1 : Form
    {
        //global values
        const double STICK = 59.99;
        const double SKATES = 69.99;
        const double HELMET = 44.99;
        const double TAX = 0.13;
        int numHelmet;
        int numSkates;
        int numStick;
        double subtotal;
        double tax;
        double total;
        double numTendered;
        double tendered;

        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            numHelmet = Convert.ToInt16(helmetInput.Text);
            numSkates = Convert.ToInt16(skatesInput.Text);
            numStick = Convert.ToInt16(stickInput.Text);
            subtotal = numHelmet * HELMET + numSkates * SKATES + numStick * STICK;
            subtotLabel.Text = subtotal.ToString("C");

            tax = subtotal * TAX;
            taxtwoLabel.Text = tax.ToString("C");

            total = tax + subtotal;
            grandtotalLabel.Text = total.ToString("C");
        }

        private void taxtwoLabel_Click(object sender, EventArgs e)
        {

        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            numTendered = Convert.ToInt16(tenInput.Text);
            tendered = numTendered - total;
            changeLabel.Text = tendered.ToString("C");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer(Properties.Resources.receipt);
            player.Play();
            Graphics g = this.CreateGraphics();   
            Pen drawPen = new Pen(Color.Black, 2);
            g.DrawRectangle(drawPen, 250, 30, 200, 300);

            Font drawFont = new Font("Consolas", 8, FontStyle.Bold);
            SolidBrush drawBrush = new SolidBrush(Color.Black);

            g.DrawString("Jacob's Hockey Shop", drawFont, drawBrush, 288, 40);
            g.DrawString("order number: 1752" +
                "\nOct 11, 2018" +
                "\n" +
                "\nStick             " + numStick + " @ " + STICK.ToString("C") +
                "\nSkates            " + numSkates + " @ " + SKATES.ToString("C") +
                "\nHelmet            " + numHelmet + " @ " + HELMET.ToString("C") +
                "\n" +
                "\nSubtotal              " + subtotal.ToString("C") +
                "\nTax                   " + tax.ToString("C") +
                "\nGrand Total           " + total.ToString("C") +
                "\n" +
                "\nTendered              " + numTendered.ToString("C") +
                "\nChange                " + tendered.ToString("C") + 
                "\n" +
                "\nHave a great day, play on!", drawFont, drawBrush, 255, 70);

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            numStick = 0;
            numSkates = 0;
            numHelmet = 0;
            tendered = 0;
            numTendered = 0;
            tenInput.Text = "";
            stickInput.Text = "";
            skatesInput.Text = "";
            helmetInput.Text = "";
            subtotLabel.Text = "";
            taxtwoLabel.Text = "";
            grandtotalLabel.Text = "";

            this.Refresh();
        }
    }
}
