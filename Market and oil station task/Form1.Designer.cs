namespace Market_and_oil_station_task
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.MoneyGasOil = new System.Windows.Forms.MaskedTextBox();
            this.LitrGasoil = new System.Windows.Forms.MaskedTextBox();
            this.MoneyGsoilRadioBtn = new System.Windows.Forms.RadioButton();
            this.LiterGasoIilRadioBtn = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GasolineComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.HotDogAmountMaskedTxtBox = new System.Windows.Forms.MaskedTextBox();
            this.HamburgerAmountMaskedTxtBox = new System.Windows.Forms.MaskedTextBox();
            this.PizzaAmountMaskedTxtBox = new System.Windows.Forms.MaskedTextBox();
            this.KokakolaAmountMaskedTxtBox = new System.Windows.Forms.MaskedTextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.FoodCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gasoline";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.MoneyGasOil);
            this.groupBox1.Controls.Add(this.LitrGasoil);
            this.groupBox1.Controls.Add(this.MoneyGsoilRadioBtn);
            this.groupBox1.Controls.Add(this.LiterGasoIilRadioBtn);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.GasolineComboBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(533, 460);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Oil station";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(24, 338);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(474, 100);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Amount";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 31);
            this.label6.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(444, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 31);
            this.label5.TabIndex = 9;
            this.label5.Text = "AZN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(444, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 31);
            this.label4.TabIndex = 8;
            this.label4.Text = "Litr";
            // 
            // MoneyGasOil
            // 
            this.MoneyGasOil.Enabled = false;
            this.MoneyGasOil.Location = new System.Drawing.Point(351, 253);
            this.MoneyGasOil.Mask = "00000";
            this.MoneyGasOil.Name = "MoneyGasOil";
            this.MoneyGasOil.Size = new System.Drawing.Size(87, 38);
            this.MoneyGasOil.TabIndex = 7;
            this.MoneyGasOil.ValidatingType = typeof(int);
            this.MoneyGasOil.TextChanged += new System.EventHandler(this.MoneyGasOil_TextChanged);
            // 
            // LitrGasoil
            // 
            this.LitrGasoil.Enabled = false;
            this.LitrGasoil.Location = new System.Drawing.Point(351, 190);
            this.LitrGasoil.Mask = "00000";
            this.LitrGasoil.Name = "LitrGasoil";
            this.LitrGasoil.Size = new System.Drawing.Size(87, 38);
            this.LitrGasoil.TabIndex = 6;
            this.LitrGasoil.ValidatingType = typeof(int);
            this.LitrGasoil.TextChanged += new System.EventHandler(this.LitrGasoil_TextChanged);
            // 
            // MoneyGsoilRadioBtn
            // 
            this.MoneyGsoilRadioBtn.AutoSize = true;
            this.MoneyGsoilRadioBtn.Location = new System.Drawing.Point(24, 253);
            this.MoneyGsoilRadioBtn.Name = "MoneyGsoilRadioBtn";
            this.MoneyGsoilRadioBtn.Size = new System.Drawing.Size(191, 35);
            this.MoneyGsoilRadioBtn.TabIndex = 5;
            this.MoneyGsoilRadioBtn.TabStop = true;
            this.MoneyGsoilRadioBtn.Text = "petrol money";
            this.MoneyGsoilRadioBtn.UseVisualStyleBackColor = true;
            this.MoneyGsoilRadioBtn.CheckedChanged += new System.EventHandler(this.MoneyGsoilRadioBtn_CheckedChanged);
            // 
            // LiterGasoIilRadioBtn
            // 
            this.LiterGasoIilRadioBtn.AutoSize = true;
            this.LiterGasoIilRadioBtn.Location = new System.Drawing.Point(24, 190);
            this.LiterGasoIilRadioBtn.Name = "LiterGasoIilRadioBtn";
            this.LiterGasoIilRadioBtn.Size = new System.Drawing.Size(216, 35);
            this.LiterGasoIilRadioBtn.TabIndex = 4;
            this.LiterGasoIilRadioBtn.TabStop = true;
            this.LiterGasoIilRadioBtn.Text = "liter of gasoline";
            this.LiterGasoIilRadioBtn.UseVisualStyleBackColor = true;
            this.LiterGasoIilRadioBtn.CheckedChanged += new System.EventHandler(this.LiterGasoIilRadioBtn_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(345, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 31);
            this.label3.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Price";
            // 
            // GasolineComboBox
            // 
            this.GasolineComboBox.FormattingEnabled = true;
            this.GasolineComboBox.Location = new System.Drawing.Point(351, 67);
            this.GasolineComboBox.Name = "GasolineComboBox";
            this.GasolineComboBox.Size = new System.Drawing.Size(147, 39);
            this.GasolineComboBox.TabIndex = 1;
            this.GasolineComboBox.SelectedIndexChanged += new System.EventHandler(this.GasolineComboBox_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(234, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 31);
            this.label7.TabIndex = 1;
            this.label7.Text = "Azn";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.FoodCheckedListBox);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.KokakolaAmountMaskedTxtBox);
            this.groupBox3.Controls.Add(this.PizzaAmountMaskedTxtBox);
            this.groupBox3.Controls.Add(this.HamburgerAmountMaskedTxtBox);
            this.groupBox3.Controls.Add(this.HotDogAmountMaskedTxtBox);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(631, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(626, 470);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Small market";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(334, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 27);
            this.label8.TabIndex = 4;
            this.label8.Text = "4.00";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(334, 141);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 27);
            this.label9.TabIndex = 5;
            this.label9.Text = "5.40";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(334, 197);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 27);
            this.label10.TabIndex = 6;
            this.label10.Text = "7.20";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(334, 252);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 27);
            this.label11.TabIndex = 7;
            this.label11.Text = "0.50";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(317, 40);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 27);
            this.label12.TabIndex = 8;
            this.label12.Text = "Prices";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(446, 40);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(174, 27);
            this.label13.TabIndex = 9;
            this.label13.Text = "Amount of food";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // HotDogAmountMaskedTxtBox
            // 
            this.HotDogAmountMaskedTxtBox.Location = new System.Drawing.Point(516, 83);
            this.HotDogAmountMaskedTxtBox.Mask = "00";
            this.HotDogAmountMaskedTxtBox.Name = "HotDogAmountMaskedTxtBox";
            this.HotDogAmountMaskedTxtBox.Size = new System.Drawing.Size(40, 33);
            this.HotDogAmountMaskedTxtBox.TabIndex = 10;
            this.HotDogAmountMaskedTxtBox.ValidatingType = typeof(int);
            // 
            // HamburgerAmountMaskedTxtBox
            // 
            this.HamburgerAmountMaskedTxtBox.Location = new System.Drawing.Point(516, 138);
            this.HamburgerAmountMaskedTxtBox.Mask = "00";
            this.HamburgerAmountMaskedTxtBox.Name = "HamburgerAmountMaskedTxtBox";
            this.HamburgerAmountMaskedTxtBox.Size = new System.Drawing.Size(40, 33);
            this.HamburgerAmountMaskedTxtBox.TabIndex = 11;
            this.HamburgerAmountMaskedTxtBox.ValidatingType = typeof(int);
            // 
            // PizzaAmountMaskedTxtBox
            // 
            this.PizzaAmountMaskedTxtBox.Location = new System.Drawing.Point(516, 191);
            this.PizzaAmountMaskedTxtBox.Mask = "00";
            this.PizzaAmountMaskedTxtBox.Name = "PizzaAmountMaskedTxtBox";
            this.PizzaAmountMaskedTxtBox.Size = new System.Drawing.Size(40, 33);
            this.PizzaAmountMaskedTxtBox.TabIndex = 12;
            this.PizzaAmountMaskedTxtBox.ValidatingType = typeof(int);
            // 
            // KokakolaAmountMaskedTxtBox
            // 
            this.KokakolaAmountMaskedTxtBox.Location = new System.Drawing.Point(516, 246);
            this.KokakolaAmountMaskedTxtBox.Mask = "00";
            this.KokakolaAmountMaskedTxtBox.Name = "KokakolaAmountMaskedTxtBox";
            this.KokakolaAmountMaskedTxtBox.Size = new System.Drawing.Size(40, 33);
            this.KokakolaAmountMaskedTxtBox.TabIndex = 13;
            this.KokakolaAmountMaskedTxtBox.ValidatingType = typeof(int);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(23, 348);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(457, 100);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Amount";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(51, 53);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(97, 31);
            this.label14.TabIndex = 0;
            this.label14.Text = "label14";
            // 
            // FoodCheckedListBox
            // 
            this.FoodCheckedListBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FoodCheckedListBox.FormattingEnabled = true;
            this.FoodCheckedListBox.Location = new System.Drawing.Point(23, 86);
            this.FoodCheckedListBox.Name = "FoodCheckedListBox";
            this.FoodCheckedListBox.Size = new System.Drawing.Size(285, 268);
            this.FoodCheckedListBox.TabIndex = 15;
            this.FoodCheckedListBox.SelectedIndexChanged += new System.EventHandler(this.FoodCheckedListBox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 725);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox GasolineComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton MoneyGsoilRadioBtn;
        private System.Windows.Forms.RadioButton LiterGasoIilRadioBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox MoneyGasOil;
        private System.Windows.Forms.MaskedTextBox LitrGasoil;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.MaskedTextBox KokakolaAmountMaskedTxtBox;
        private System.Windows.Forms.MaskedTextBox PizzaAmountMaskedTxtBox;
        private System.Windows.Forms.MaskedTextBox HamburgerAmountMaskedTxtBox;
        private System.Windows.Forms.MaskedTextBox HotDogAmountMaskedTxtBox;
        private System.Windows.Forms.CheckedListBox FoodCheckedListBox;
    }
}

