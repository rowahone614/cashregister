using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace cashregister
{
    public partial class Form1 : Form
    {
        const double MUTTON_PRICE = 22.75;
        const double GLUEHWEIN_PRICE = 7.50;
        const double TART_PRICE = 14.75;
        const double TAX_VALUE = 0.13;
        double subTotalValue;
        double grandTotalValue;
        double taxationValue;
        double gluehweinNumber;
        double muttonNumber;
        double tartNumber;
        double totalinGluehwein;
        double totalinMutton;
        double totalinTart;
        double tenderAmount;
        double changeAmount;

        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
           
            //numerical up-down conversions
            muttonNumber = Convert.ToDouble(muttonAmount.Value);
            gluehweinNumber = Convert.ToDouble(wineAmount.Value);
            tartNumber = Convert.ToDouble(tartAmount.Value);
            //calculations
            totalinTart = tartNumber * TART_PRICE;
            totalinGluehwein = gluehweinNumber * GLUEHWEIN_PRICE;
            totalinMutton = muttonNumber * MUTTON_PRICE;
            subTotalValue = totalinMutton + totalinGluehwein + totalinTart;
            taxationValue = TAX_VALUE * subTotalValue;
            grandTotalValue = taxationValue + subTotalValue;
            //label outputs
            subtotalLabel.Text = "Subtotal - " + subTotalValue.ToString("C");
            taxLabel.Text = "Tax Value - " + taxationValue.ToString("C");
            grandTotal.Text = "Grand Total - " + grandTotalValue.ToString("C");
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
                try
                {
                    tenderAmount = Convert.ToDouble(tenderValue.Text);
                    //calculation
                    changeAmount = tenderAmount - grandTotalValue;
                    //label output if input is numerical
                    changeValue.Text = "Your change is " + changeAmount.ToString("C");
                }
                catch
                {
                    //label output if input is not numerical
                    changeValue.Text = "PAY YOUR PRICE";
                }

        }



        private void PrintButton_Click(object sender, EventArgs e)
        {
            Graphics g = receiptOutPut.CreateGraphics();
            Font receiptFont = new Font("Courier New", 10);
            SolidBrush blackBrush = new SolidBrush(Color.Black);
            SoundPlayer printSound = new SoundPlayer(Properties.Resources.printSound);

            g.DrawString("Leg of Mutton x " + muttonNumber + " ... " + totalinMutton.ToString("C"), receiptFont, blackBrush, 0, 0);
            printSound.Play();
            Thread.Sleep(450);
            g.DrawString("Gluehwein x " + gluehweinNumber + " ....... " + totalinGluehwein.ToString("C"), receiptFont, blackBrush, 0, 20);
            Thread.Sleep(450);
            g.DrawString("Melon Tart x " + tartNumber + " ...... " + totalinTart.ToString("C"), receiptFont, blackBrush, 0, 40);
            Thread.Sleep(450);
            g.DrawString("Subtotal ............ " + subTotalValue.ToString("C"), receiptFont, blackBrush, 0, 80);
            printSound.Play();
            Thread.Sleep(450);
            g.DrawString("Tax Value ........... " + taxationValue.ToString("C"), receiptFont, blackBrush, 0, 100);
            Thread.Sleep(450);
            g.DrawString("Grand Total ......... " + grandTotalValue.ToString("C"), receiptFont, blackBrush, 0, 120);
            Thread.Sleep(450);
            g.DrawString("Amount Tendered ..... " + tenderAmount.ToString("C"), receiptFont, blackBrush, 0, 160);
            printSound.Play();
            Thread.Sleep(450);
            g.DrawString("Returned Change ..... " + changeAmount.ToString("C"), receiptFont, blackBrush, 0, 180);
            Thread.Sleep(450);
            g.DrawString("Thank Thou, Squire!", receiptFont, blackBrush, 40, 220);
            Thread.Sleep(450);
            g.DrawString("Good Morrow!", receiptFont, blackBrush, 65, 240);
            Thread.Sleep(450);
            g.DrawString("519-246-9420", receiptFont, blackBrush, 64, 260);
            

        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            Graphics r = receiptOutPut.CreateGraphics();
            r.Clear(Color.White);
            muttonAmount.Value = 0;
            wineAmount.Value = 0;
            tartAmount.Value = 0;
            subTotalValue = 0;
            grandTotalValue = 0;
            taxationValue = 0;
            changeAmount = 0;
            taxLabel.Text = "";
            subtotalLabel.Text = "";
            receiptOutPut.Text = "";
            grandTotal.Text = "";
            tenderValue.Text = "";
            changeValue.Text = "";
        }
    }
    
}
