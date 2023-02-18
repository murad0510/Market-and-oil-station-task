using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market_and_oil_station_task
{
    public partial class Form2 : Form
    {
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle,
                                                                  Color.FromArgb(23, 42, 58),
                                                                  Color.FromArgb(117, 221, 221),
                                                                  90F))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }

        private double commonPrice;

        public double CommonPrice
        {
            get { return commonPrice; }
            set { amountLbl.Text = value.ToString(); }
        }

        public Form2()
        {
            InitializeComponent();
        }
    }
}












































//private string hamburhger;

//public string Hamburhger
//{
//    get { return hamburhger; }
//    set
//    {
//        if (PriceHamburger != 0)
//        {
//            label1.Text = value;
//            hamburhger = value;

//        }
//    }
//}

//private double priceHamburger = 10;

//public double PriceHamburger
//{
//    get { return priceHamburger; }
//    set
//    {
//        if (PriceHamburger != 0)
//        {
//            label1.Text = value.ToString();
//            priceHamburger = value;

//        }
//    }
//}

//private string pizza;

//public string Pizza
//{
//    get { return pizza; }
//    set
//    {
//        if (PricePizza != 0)
//        {
//            pizza = value;
//            label2.Text = value;
//        }
//    }
//}

//private double pricePizza;

//public double PricePizza
//{
//    get { return pricePizza; }
//    set
//    {
//        if (PricePizza != 0)
//        {
//            pricePizza = value;
//            label2.Text = value.ToString();

//        }
//    }
//}

//private string cocaCola;

//public string CocaCola
//{
//    get { return cocaCola; }
//    set
//    {
//        if (PriceCola != 0)
//        {
//            label3.Text = value;
//            cocaCola = value;

//        }
//    }
//}

//private double priceCola;

//public double PriceCola
//{
//    get { return priceCola; }
//    set
//    {
//        if (PriceCola != 0)
//        {
//            label3.Text = value.ToString();
//            priceCola = value;

//        }
//    }
//}

//private string free;

//public string Free
//{
//    get { return free; }
//    set
//    {
//        if (FreePrice != 0)
//        {
//            label4.Text = value;
//            free = value;

//        }
//    }
//}

//private double freePrice;

//public double FreePrice
//{
//    get { return freePrice; }
//    set
//    {
//        if (FreePrice != 0)
//        {
//            label4.Text = value.ToString();
//            freePrice = value;

//        }
//    }
//}