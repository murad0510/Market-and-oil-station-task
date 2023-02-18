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

        List<Check> checks = new List<Check>();

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
                amountOilLbl.Text = count.ToString();
            }
            catch (Exception)
            {
                LitirMoney = 0;
                count = LitirMoney + Money;
                amountOilLbl.Text = count.ToString();
            }
        }

        private void MoneyGasOil_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Money = (Double.Parse(MoneyGasOil.Text) / Double.Parse(label3.Text));
                count = LitirMoney + Money;
                amountOilLbl.Text = (double.Parse(amountOilLbl.Text) + double.Parse(MoneyGasOil.Text)).ToString();
                maskedTextBox1.Text = count.ToString();
            }
            catch (Exception)
            {
                Money = 0;
                count = LitirMoney + Money;
                amountOilLbl.Text = "0";
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
                money = (hamburhgerPrice + pizzaPrice + freePrice + cocaColaPrice);
                amountRestarantLbl.Text = money.ToString();
            }
            catch (Exception)
            {
                hamburhgerPrice = 0;
                money = (hamburhgerPrice + pizzaPrice + freePrice + cocaColaPrice);
                amountRestarantLbl.Text = money.ToString();
            }
        }

        private void PizzaAmountMaskedTxtBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                pizzaPrice = int.Parse(PizzaAmountMaskedTxtBox.Text) * double.Parse(PizzaPriceMaskedTextBox.Text);
                money = (hamburhgerPrice + pizzaPrice + freePrice + cocaColaPrice);
                amountRestarantLbl.Text = money.ToString();
            }
            catch (Exception)
            {
                pizzaPrice = 0;
                money = (hamburhgerPrice + pizzaPrice + freePrice + cocaColaPrice);
                amountRestarantLbl.Text = money.ToString();
            }
        }

        private void KokakolaAmountMaskedTxtBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                cocaColaPrice = double.Parse(CocaColaPriceMaskedTextBox.Text) * int.Parse(CocaColaAmountMaskedTxtBox.Text);
                money = (hamburhgerPrice + pizzaPrice + freePrice + cocaColaPrice);
                amountRestarantLbl.Text = money.ToString();
            }
            catch (Exception)
            {
                cocaColaPrice = 0;
                money = (hamburhgerPrice + pizzaPrice + freePrice + cocaColaPrice);
                amountRestarantLbl.Text = money.ToString();
            }
        }

        private void FreeAmountMaskedTxtBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                freePrice = double.Parse(FreePriceMaskedTextBox.Text) * int.Parse(FreeAmountMaskedTxtBox.Text);
                money = (hamburhgerPrice + pizzaPrice + freePrice + cocaColaPrice);
                amountRestarantLbl.Text = money.ToString();
            }
            catch (Exception)
            {
                freePrice = 0;
                money = (hamburhgerPrice + pizzaPrice + freePrice + cocaColaPrice);
                amountRestarantLbl.Text = money.ToString();
            }
        }
        Form2 form2 = new Form2();
        private void button1_Click(object sender, EventArgs e)
        {
            if (hamburhgerPrice > 0)
            {
                Check check = new Check();
                check.Name = HamburgerCheckBox.Text;
                check.Price = hamburhgerPrice;
                check.Count = int.Parse(HamburgerAmountMaskedTxtBox.Text);
                checks.Add(check);
            }
            if (pizzaPrice > 0)
            {
                Check check1 = new Check();
                check1.Name = PizzaCheckBox.Text;
                check1.Price = pizzaPrice;
                check1.Count = int.Parse(PizzaAmountMaskedTxtBox.Text);
                checks.Add(check1);
            }

            if (freePrice > 0)
            {
                Check check2 = new Check();
                check2.Name = FreeCheckBox.Text;
                check2.Price = freePrice;
                check2.Count = int.Parse(FreeAmountMaskedTxtBox.Text);
                checks.Add(check2);
            }

            if (cocaColaPrice > 0)
            {
                Check check3 = new Check();
                check3.Name = Coca_colaCheckBox.Text;
                check3.Price = cocaColaPrice;
                check3.Count = int.Parse(CocaColaAmountMaskedTxtBox.Text);
                checks.Add(check3);
            }

            if (amountOilLbl.Text != "" && amountRestarantLbl.Text != "")
            {
                int y = 100;
                label10.Text = (double.Parse(amountOilLbl.Text) + double.Parse(amountRestarantLbl.Text)).ToString();

                foreach (var item in checks)
                {
                    var uc = new UserControl1();
                    uc.FoodName = item.Name;
                    uc.FoodCount = item.Count;
                    uc.FoodPrice = item.Price;
                    uc.Location = new Point(0, y);
                    y += 100;
                    form2.Controls.Add(uc);
                    form2.CommonPrice = money;
                }
            }
            else if (amountOilLbl.Text == "")
            {
                label10.Text = amountRestarantLbl.Text;
                int y = 100;

                foreach (var item in checks)
                {
                    var uc = new UserControl1();
                    uc.FoodName = item.Name;
                    uc.FoodCount = item.Count;
                    uc.FoodPrice = item.Price;
                    uc.Location = new Point(0, y);
                    y += 100;
                    form2.Controls.Add(uc);
                    form2.CommonPrice = money;
                }
            }
            else if (amountRestarantLbl.Text == "")
            {
                label10.Text = amountOilLbl.Text;
            }
            form2.Show();
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