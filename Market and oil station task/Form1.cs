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

            FoodCheckedListBox.DisplayMember = nameof(Market.Name);
            FoodCheckedListBox.Items.AddRange(market.ToArray());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

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

        public bool IsClicked { get; set; } = true;
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
                label6.Text = count.ToString();

            }
            catch (Exception)
            {
                Money = 0;
                count = LitirMoney + Money;
                label6.Text = count.ToString();
            }

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            HotDogAmountMaskedTxtBox.Enabled = false;
        }

        private void FoodCheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
