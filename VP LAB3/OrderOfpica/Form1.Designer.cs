namespace OrderOfpica
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtLarge = new System.Windows.Forms.TextBox();
            this.txtMedium = new System.Windows.Forms.TextBox();
            this.txtSmall = new System.Windows.Forms.TextBox();
            this.rbLarge = new System.Windows.Forms.RadioButton();
            this.rbMedium = new System.Windows.Forms.RadioButton();
            this.rbSmall = new System.Windows.Forms.RadioButton();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.txtKetchup = new System.Windows.Forms.TextBox();
            this.txtCheese = new System.Windows.Forms.TextBox();
            this.txtSpices = new System.Windows.Forms.TextBox();
            this.cbKetchup = new System.Windows.Forms.CheckBox();
            this.cbCheese = new System.Windows.Forms.CheckBox();
            this.cbSpices = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtTotalPriceBeer = new System.Windows.Forms.TextBox();
            this.txtTotalPriceJuice = new System.Windows.Forms.TextBox();
            this.txtTotalPriceCocaCola = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPriceBeer = new System.Windows.Forms.TextBox();
            this.txtPriceJuice = new System.Windows.Forms.TextBox();
            this.txtPriceCocaCola = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtQuantityBeer = new System.Windows.Forms.TextBox();
            this.txtQuantityJuice = new System.Windows.Forms.TextBox();
            this.txtQuantityCocaCola = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.txtPriceOfTheDesert = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lbDeserts = new System.Windows.Forms.ListBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.txtPayed = new System.Windows.Forms.TextBox();
            this.txtChange = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtLarge);
            this.groupBox1.Controls.Add(this.txtMedium);
            this.groupBox1.Controls.Add(this.txtSmall);
            this.groupBox1.Controls.Add(this.rbLarge);
            this.groupBox1.Controls.Add(this.rbMedium);
            this.groupBox1.Controls.Add(this.rbSmall);
            this.groupBox1.Location = new System.Drawing.Point(12, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(321, 181);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Size of pizza";
            // 
            // txtLarge
            // 
            this.txtLarge.Location = new System.Drawing.Point(135, 130);
            this.txtLarge.Name = "txtLarge";
            this.txtLarge.Size = new System.Drawing.Size(134, 20);
            this.txtLarge.TabIndex = 5;
            this.txtLarge.Text = "500";
            this.txtLarge.TextChanged += new System.EventHandler(this.txtLarge_TextChanged);
            // 
            // txtMedium
            // 
            this.txtMedium.Location = new System.Drawing.Point(135, 72);
            this.txtMedium.Name = "txtMedium";
            this.txtMedium.Size = new System.Drawing.Size(134, 20);
            this.txtMedium.TabIndex = 3;
            this.txtMedium.Text = "300";
            this.txtMedium.TextChanged += new System.EventHandler(this.txtMedium_TextChanged);
            // 
            // txtSmall
            // 
            this.txtSmall.Location = new System.Drawing.Point(135, 16);
            this.txtSmall.Name = "txtSmall";
            this.txtSmall.Size = new System.Drawing.Size(134, 20);
            this.txtSmall.TabIndex = 1;
            this.txtSmall.Text = "200";
            this.txtSmall.TextChanged += new System.EventHandler(this.txtSmall_TextChanged);
            // 
            // rbLarge
            // 
            this.rbLarge.AutoSize = true;
            this.rbLarge.Location = new System.Drawing.Point(11, 133);
            this.rbLarge.Name = "rbLarge";
            this.rbLarge.Size = new System.Drawing.Size(52, 17);
            this.rbLarge.TabIndex = 4;
            this.rbLarge.TabStop = true;
            this.rbLarge.Text = "Large";
            this.rbLarge.UseVisualStyleBackColor = true;
            this.rbLarge.CheckedChanged += new System.EventHandler(this.rbLarge_CheckedChanged);
            // 
            // rbMedium
            // 
            this.rbMedium.AutoSize = true;
            this.rbMedium.Location = new System.Drawing.Point(11, 75);
            this.rbMedium.Name = "rbMedium";
            this.rbMedium.Size = new System.Drawing.Size(62, 17);
            this.rbMedium.TabIndex = 2;
            this.rbMedium.TabStop = true;
            this.rbMedium.Text = "Medium";
            this.rbMedium.UseVisualStyleBackColor = true;
            this.rbMedium.CheckedChanged += new System.EventHandler(this.rbMedium_CheckedChanged);
            // 
            // rbSmall
            // 
            this.rbSmall.AutoSize = true;
            this.rbSmall.Location = new System.Drawing.Point(11, 19);
            this.rbSmall.Name = "rbSmall";
            this.rbSmall.Size = new System.Drawing.Size(48, 17);
            this.rbSmall.TabIndex = 0;
            this.rbSmall.TabStop = true;
            this.rbSmall.Text = "small";
            this.rbSmall.UseVisualStyleBackColor = true;
            this.rbSmall.CheckedChanged += new System.EventHandler(this.rbSmall_CheckedChanged);
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.txtKetchup);
            this.GroupBox2.Controls.Add(this.txtCheese);
            this.GroupBox2.Controls.Add(this.txtSpices);
            this.GroupBox2.Controls.Add(this.cbKetchup);
            this.GroupBox2.Controls.Add(this.cbCheese);
            this.GroupBox2.Controls.Add(this.cbSpices);
            this.GroupBox2.Location = new System.Drawing.Point(339, 0);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(324, 181);
            this.GroupBox2.TabIndex = 1;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Feautures";
            // 
            // txtKetchup
            // 
            this.txtKetchup.Location = new System.Drawing.Point(158, 132);
            this.txtKetchup.Name = "txtKetchup";
            this.txtKetchup.Size = new System.Drawing.Size(118, 20);
            this.txtKetchup.TabIndex = 5;
            this.txtKetchup.Text = "20";
            this.txtKetchup.TextChanged += new System.EventHandler(this.txtKetchup_TextChanged);
            // 
            // txtCheese
            // 
            this.txtCheese.Location = new System.Drawing.Point(158, 72);
            this.txtCheese.Name = "txtCheese";
            this.txtCheese.Size = new System.Drawing.Size(118, 20);
            this.txtCheese.TabIndex = 3;
            this.txtCheese.Text = "30";
            this.txtCheese.TextChanged += new System.EventHandler(this.txtCheese_TextChanged);
            // 
            // txtSpices
            // 
            this.txtSpices.Location = new System.Drawing.Point(158, 16);
            this.txtSpices.Name = "txtSpices";
            this.txtSpices.Size = new System.Drawing.Size(118, 20);
            this.txtSpices.TabIndex = 1;
            this.txtSpices.Text = "40";
            this.txtSpices.TextChanged += new System.EventHandler(this.txtSpices_TextChanged);
            // 
            // cbKetchup
            // 
            this.cbKetchup.AutoSize = true;
            this.cbKetchup.Location = new System.Drawing.Point(11, 134);
            this.cbKetchup.Name = "cbKetchup";
            this.cbKetchup.Size = new System.Drawing.Size(66, 17);
            this.cbKetchup.TabIndex = 4;
            this.cbKetchup.Text = "Ketchup";
            this.cbKetchup.UseVisualStyleBackColor = true;
            this.cbKetchup.CheckedChanged += new System.EventHandler(this.cbKetchup_CheckedChanged);
            // 
            // cbCheese
            // 
            this.cbCheese.AutoSize = true;
            this.cbCheese.Location = new System.Drawing.Point(11, 76);
            this.cbCheese.Name = "cbCheese";
            this.cbCheese.Size = new System.Drawing.Size(89, 17);
            this.cbCheese.TabIndex = 2;
            this.cbCheese.Text = "Extra Cheese";
            this.cbCheese.UseVisualStyleBackColor = true;
            this.cbCheese.CheckedChanged += new System.EventHandler(this.cbCheese_CheckedChanged);
            // 
            // cbSpices
            // 
            this.cbSpices.AutoSize = true;
            this.cbSpices.Location = new System.Drawing.Point(11, 20);
            this.cbSpices.Name = "cbSpices";
            this.cbSpices.Size = new System.Drawing.Size(58, 17);
            this.cbSpices.TabIndex = 0;
            this.cbSpices.Text = "Spices";
            this.cbSpices.UseVisualStyleBackColor = true;
            this.cbSpices.CheckedChanged += new System.EventHandler(this.cbSpices_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtTotalPriceBeer);
            this.groupBox3.Controls.Add(this.txtTotalPriceJuice);
            this.groupBox3.Controls.Add(this.txtTotalPriceCocaCola);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtPriceBeer);
            this.groupBox3.Controls.Add(this.txtPriceJuice);
            this.groupBox3.Controls.Add(this.txtPriceCocaCola);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtQuantityBeer);
            this.groupBox3.Controls.Add(this.txtQuantityJuice);
            this.groupBox3.Controls.Add(this.txtQuantityCocaCola);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(12, 187);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(651, 185);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Drink";
            // 
            // txtTotalPriceBeer
            // 
            this.txtTotalPriceBeer.Location = new System.Drawing.Point(511, 140);
            this.txtTotalPriceBeer.Name = "txtTotalPriceBeer";
            this.txtTotalPriceBeer.ReadOnly = true;
            this.txtTotalPriceBeer.Size = new System.Drawing.Size(100, 20);
            this.txtTotalPriceBeer.TabIndex = 11;
            // 
            // txtTotalPriceJuice
            // 
            this.txtTotalPriceJuice.Location = new System.Drawing.Point(511, 87);
            this.txtTotalPriceJuice.Name = "txtTotalPriceJuice";
            this.txtTotalPriceJuice.ReadOnly = true;
            this.txtTotalPriceJuice.Size = new System.Drawing.Size(100, 20);
            this.txtTotalPriceJuice.TabIndex = 7;
            // 
            // txtTotalPriceCocaCola
            // 
            this.txtTotalPriceCocaCola.Location = new System.Drawing.Point(511, 33);
            this.txtTotalPriceCocaCola.Name = "txtTotalPriceCocaCola";
            this.txtTotalPriceCocaCola.ReadOnly = true;
            this.txtTotalPriceCocaCola.Size = new System.Drawing.Size(100, 20);
            this.txtTotalPriceCocaCola.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(508, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Total Price";
            // 
            // txtPriceBeer
            // 
            this.txtPriceBeer.Location = new System.Drawing.Point(353, 140);
            this.txtPriceBeer.Name = "txtPriceBeer";
            this.txtPriceBeer.Size = new System.Drawing.Size(100, 20);
            this.txtPriceBeer.TabIndex = 10;
            this.txtPriceBeer.Text = "80";
            this.txtPriceBeer.TextChanged += new System.EventHandler(this.txtPriceBeer_TextChanged);
            // 
            // txtPriceJuice
            // 
            this.txtPriceJuice.Location = new System.Drawing.Point(353, 87);
            this.txtPriceJuice.Name = "txtPriceJuice";
            this.txtPriceJuice.Size = new System.Drawing.Size(100, 20);
            this.txtPriceJuice.TabIndex = 6;
            this.txtPriceJuice.Text = "70";
            this.txtPriceJuice.TextChanged += new System.EventHandler(this.txtPriceJuice_TextChanged);
            // 
            // txtPriceCocaCola
            // 
            this.txtPriceCocaCola.Location = new System.Drawing.Point(353, 33);
            this.txtPriceCocaCola.Name = "txtPriceCocaCola";
            this.txtPriceCocaCola.Size = new System.Drawing.Size(100, 20);
            this.txtPriceCocaCola.TabIndex = 2;
            this.txtPriceCocaCola.Text = "60";
            this.txtPriceCocaCola.TextChanged += new System.EventHandler(this.txtPriceCocaCola_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(350, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Price";
            // 
            // txtQuantityBeer
            // 
            this.txtQuantityBeer.Location = new System.Drawing.Point(193, 140);
            this.txtQuantityBeer.Name = "txtQuantityBeer";
            this.txtQuantityBeer.Size = new System.Drawing.Size(100, 20);
            this.txtQuantityBeer.TabIndex = 9;
            this.txtQuantityBeer.Text = "0";
            this.txtQuantityBeer.TextChanged += new System.EventHandler(this.txtQuantityBeer_TextChanged);
            // 
            // txtQuantityJuice
            // 
            this.txtQuantityJuice.Location = new System.Drawing.Point(193, 87);
            this.txtQuantityJuice.Name = "txtQuantityJuice";
            this.txtQuantityJuice.Size = new System.Drawing.Size(100, 20);
            this.txtQuantityJuice.TabIndex = 5;
            this.txtQuantityJuice.Text = "0";
            this.txtQuantityJuice.TextChanged += new System.EventHandler(this.txtQuantityJuice_TextChanged);
            // 
            // txtQuantityCocaCola
            // 
            this.txtQuantityCocaCola.Location = new System.Drawing.Point(193, 33);
            this.txtQuantityCocaCola.Name = "txtQuantityCocaCola";
            this.txtQuantityCocaCola.Size = new System.Drawing.Size(100, 20);
            this.txtQuantityCocaCola.TabIndex = 1;
            this.txtQuantityCocaCola.Text = "0";
            this.txtQuantityCocaCola.TextChanged += new System.EventHandler(this.txtQuantityCocaCola_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(190, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Beer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Apple juice / orange";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Coca Cola / Fanta / Spryte";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnCancel);
            this.groupBox4.Controls.Add(this.btnOrder);
            this.groupBox4.Controls.Add(this.txtPriceOfTheDesert);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.lbDeserts);
            this.groupBox4.Location = new System.Drawing.Point(12, 378);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(293, 141);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Desert";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(147, 101);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(122, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(147, 68);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(122, 23);
            this.btnOrder.TabIndex = 3;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // txtPriceOfTheDesert
            // 
            this.txtPriceOfTheDesert.Location = new System.Drawing.Point(147, 42);
            this.txtPriceOfTheDesert.Name = "txtPriceOfTheDesert";
            this.txtPriceOfTheDesert.Size = new System.Drawing.Size(122, 20);
            this.txtPriceOfTheDesert.TabIndex = 2;
            this.txtPriceOfTheDesert.Text = "0";
            this.txtPriceOfTheDesert.TextChanged += new System.EventHandler(this.txtPriceOfTheDesert_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(144, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Price of the desert:";
            // 
            // lbDeserts
            // 
            this.lbDeserts.FormattingEnabled = true;
            this.lbDeserts.Items.AddRange(new object[] {
            "Fruit pie",
            "Ice cream",
            "Cake"});
            this.lbDeserts.Location = new System.Drawing.Point(3, 16);
            this.lbDeserts.Name = "lbDeserts";
            this.lbDeserts.Size = new System.Drawing.Size(120, 108);
            this.lbDeserts.TabIndex = 0;
            this.lbDeserts.SelectedIndexChanged += new System.EventHandler(this.lbDeserts_SelectedIndexChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtTotalPrice);
            this.groupBox5.Controls.Add(this.txtPayed);
            this.groupBox5.Controls.Add(this.txtChange);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Location = new System.Drawing.Point(311, 378);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(352, 141);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Pay Price";
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Location = new System.Drawing.Point(150, 21);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.ReadOnly = true;
            this.txtTotalPrice.Size = new System.Drawing.Size(100, 20);
            this.txtTotalPrice.TabIndex = 1;
            this.txtTotalPrice.Text = "0";
            // 
            // txtPayed
            // 
            this.txtPayed.Location = new System.Drawing.Point(150, 65);
            this.txtPayed.Name = "txtPayed";
            this.txtPayed.Size = new System.Drawing.Size(100, 20);
            this.txtPayed.TabIndex = 3;
            this.txtPayed.Text = "0";
            this.txtPayed.TextChanged += new System.EventHandler(this.txtPayed_TextChanged);
            // 
            // txtChange
            // 
            this.txtChange.Location = new System.Drawing.Point(150, 99);
            this.txtChange.Name = "txtChange";
            this.txtChange.Size = new System.Drawing.Size(100, 20);
            this.txtChange.TabIndex = 5;
            this.txtChange.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 106);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Change:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Payed:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Total sum to pay:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 536);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtLarge;
        private System.Windows.Forms.TextBox txtMedium;
        private System.Windows.Forms.TextBox txtSmall;
        private System.Windows.Forms.RadioButton rbLarge;
        private System.Windows.Forms.RadioButton rbMedium;
        private System.Windows.Forms.RadioButton rbSmall;
        private System.Windows.Forms.GroupBox GroupBox2;
        private System.Windows.Forms.TextBox txtKetchup;
        private System.Windows.Forms.TextBox txtCheese;
        private System.Windows.Forms.TextBox txtSpices;
        private System.Windows.Forms.CheckBox cbKetchup;
        private System.Windows.Forms.CheckBox cbCheese;
        private System.Windows.Forms.CheckBox cbSpices;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTotalPriceBeer;
        private System.Windows.Forms.TextBox txtTotalPriceJuice;
        private System.Windows.Forms.TextBox txtTotalPriceCocaCola;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPriceBeer;
        private System.Windows.Forms.TextBox txtPriceJuice;
        private System.Windows.Forms.TextBox txtPriceCocaCola;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtQuantityBeer;
        private System.Windows.Forms.TextBox txtQuantityJuice;
        private System.Windows.Forms.TextBox txtQuantityCocaCola;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.TextBox txtPriceOfTheDesert;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lbDeserts;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.TextBox txtPayed;
        private System.Windows.Forms.TextBox txtChange;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
    }
}

