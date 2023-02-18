using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market_and_oil_station_task
{
    public partial class UserControl1 : UserControl
    {

        public string FoodName
        {
            get { return nameLbl.Text; }
            set { nameLbl.Text = value; }
        }

        public int FoodCount
        {
            get { return int.Parse(countLbl.Text); }
            set { countLbl.Text = value.ToString(); }
        }

        public double FoodPrice
        {
            get { return double.Parse(priceLbl.Text); }
            set { priceLbl.Text = value.ToString(); }
        }


        public UserControl1()
        {
            InitializeComponent();

        }

        private void nameLbl_Click(object sender, EventArgs e)
        {

        }
    }
}
