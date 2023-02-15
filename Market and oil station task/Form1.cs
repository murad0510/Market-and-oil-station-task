using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market_and_oil_station_task
{
    public partial class Form1 : Form
    {
        List<Oil> oils = new List<Oil>
        {
                new Oil
                {
                    OilName="Dizel",
                    OilPrice=1.80,
                },
                new Oil
                {
                    OilName="A-92",
                    OilPrice=2.40
                },
                new Oil
                {
                    OilName="Premium",
                    OilPrice = 2.90
                }
        };

        List<Market> market = new List<Market>
        {
            new Market
            {
                Name="Hot dog",
                Price=4,
            },
            new Market
            {
                Name="Hamburger",
                Price=5.40,
            },
            new Market
            {
                Name="Pizza",
                Price=7.20,
            },
            new Market
            {
                Name="Koka-kola",
                Price=0.50,
            }
        };

        public Form1()
        {
            InitializeComponent();

            GasolineComboBox.DisplayMember = nameof(Oil.OilName);
            GasolineComboBox.Items.AddRange(oils.ToArray());
            GasolineComboBox.SelectedIndex = 0;
        }

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

        private void GasolineComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var result = GasolineComboBox.SelectedItem;
            for (int i = 0; i < oils.Count; i++)
            {
                if (oils[i].OilName == result.ToString())
                {
                    label3.Text = oils[i].OilPrice.ToString();
                    break;
                }
            }
        }

        private void LiterGasoIilRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (IsClicked)
            {
                LitrGasoil.Enabled = true;
                MoneyGasOil.Enabled = false;
            }
            IsClicked = !IsClicked;
        }
        double count = 0;
        private void MoneyGsoilRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (IsClicked)
            {
                MoneyGasOil.Enabled = true;
                LitrGasoil.Enabled = false;
            }
            IsClicked = !IsClicked;
        }

        public bool IsEmpty { get; set; } = false;
        double LitirMoney = 0;
        double Money = 0;

        private void LitrGasoil_TextChanged(object sender, EventArgs e)
        {
            try
            {
                LitirMoney = (Double.Parse(LitrGasoil.Text) * Double.Parse(label3.Text));
                count = LitirMoney + Money;
                label6.Text = count.ToString();
            }
            catch (Exception)
            {
                LitirMoney = 0;
                count = LitirMoney + Money;
                label6.Text = count.ToString();
            }
        }

        private void MoneyGasOil_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Money = (Double.Parse(MoneyGasOil.Text) / Double.Parse(label3.Text));
                count = LitirMoney + Money;
                label6.Text = (double.Parse(label6.Text) + double.Parse(MoneyGasOil.Text)).ToString();
                maskedTextBox1.Text = count.ToString();
            }
            catch (Exception)
            {
                Money = 0;
                count = LitirMoney + Money;
                label6.Text = "0";
                maskedTextBox1.Text = count.ToString();
            }
        }

        public bool IsClicked { get; set; } = true;
        double money = 0;
        double hamburhgerPrice = 0;
        double pizzaPrice = 0;
        double freePrice = 0;
        double cocaColaPrice = 0;

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {

            HamburgerAmountMaskedTxtBox.Enabled = true;

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {


            PizzaAmountMaskedTxtBox.Enabled = true;

        }

        private void FreeCheckBox_CheckedChanged(object sender, EventArgs e)
        {


            FreeAmountMaskedTxtBox.Enabled = true;

        }

        private void Coca_colaCheckBox_CheckedChanged(object sender, EventArgs e)
        {

            CocaColaAmountMaskedTxtBox.Enabled = true;

        }

        private void HamburgerAmountMaskedTxtBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                hamburhgerPrice = int.Parse(HamburgerAmountMaskedTxtBox.Text) * double.Parse(HamburgerPriceMaskedTextBox.Text);
                money = (hamburhgerPrice + pizzaPrice + freePrice + cocaColaPrice) / 100;
                label14.Text = money.ToString();
            }
            catch (Exception)
            {
                hamburhgerPrice = 0;
                money = (hamburhgerPrice + pizzaPrice + freePrice + cocaColaPrice) / 100;
                label14.Text = money.ToString();
            }
        }

        private void PizzaAmountMaskedTxtBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                pizzaPrice = int.Parse(PizzaAmountMaskedTxtBox.Text) * double.Parse(PizzaPriceMaskedTextBox.Text);
                money = (hamburhgerPrice + pizzaPrice + freePrice + cocaColaPrice) / 100;
                label14.Text = money.ToString();
            }
            catch (Exception)
            {
                pizzaPrice = 0;
                money = (hamburhgerPrice + pizzaPrice + freePrice + cocaColaPrice) / 100;
                label14.Text = money.ToString();
            }
        }

        private void KokakolaAmountMaskedTxtBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                cocaColaPrice = double.Parse(CocaColaPriceMaskedTextBox.Text) * int.Parse(CocaColaAmountMaskedTxtBox.Text);
                money = (hamburhgerPrice + pizzaPrice + freePrice + cocaColaPrice) / 100;
                label14.Text = money.ToString();
            }
            catch (Exception)
            {
                cocaColaPrice = 0;
                money = (hamburhgerPrice + pizzaPrice + freePrice + cocaColaPrice) / 100;
                label14.Text = money.ToString();
            }
        }

        private void FreeAmountMaskedTxtBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                freePrice = double.Parse(FreePriceMaskedTextBox.Text) * int.Parse(FreeAmountMaskedTxtBox.Text);
                money = (hamburhgerPrice + pizzaPrice + freePrice + cocaColaPrice) / 100;
                label14.Text = money.ToString();
            }
            catch (Exception)
            {
                freePrice = 0;
                money = (hamburhgerPrice + pizzaPrice + freePrice + cocaColaPrice) / 100;
                label14.Text = money.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (label6.Text != "" && label6.Text != "")
            {
                label10.Text = (double.Parse(label6.Text) + double.Parse(label14.Text)).ToString();
            }
            else if (label6.Text == "")
            {
                label10.Text = label14.Text;
            }
            else if (label6.Text == "")
            {
                label10.Text = label6.Text;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            ExitButton.BackColor = Color.Red;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            ExitButton.BackColor = Color.White;
        }
    }
}