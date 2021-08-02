namespace OilTaskWithMVP
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
            this.GasolineLbl = new System.Windows.Forms.Label();
            this.PriceLbl = new System.Windows.Forms.Label();
            this.GasolineComboBx = new System.Windows.Forms.ComboBox();
            this.PriceTextBx = new System.Windows.Forms.TextBox();
            this.AznLbl = new System.Windows.Forms.Label();
            this.OilGrpBx = new System.Windows.Forms.GroupBox();
            this.ChooseGrpBx = new System.Windows.Forms.GroupBox();
            this.LiterRadioBtn = new System.Windows.Forms.RadioButton();
            this.SummaryRadioBtn = new System.Windows.Forms.RadioButton();
            this.LiterTextBx = new System.Windows.Forms.TextBox();
            this.SummaryTextBx = new System.Windows.Forms.TextBox();
            this.AllPriceGrpBx = new System.Windows.Forms.GroupBox();
            this.SummaryLbl = new System.Windows.Forms.Label();
            this.AllPriceTextBx = new System.Windows.Forms.TextBox();
            this.AllPriceLbl = new System.Windows.Forms.Label();
            this.AllSummaryGroupBx = new System.Windows.Forms.GroupBox();
            this.PayBtn = new System.Windows.Forms.Button();
            this.AllSummaryTextBx = new System.Windows.Forms.TextBox();
            this.AllSummaryLbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.OilGrpBx.SuspendLayout();
            this.ChooseGrpBx.SuspendLayout();
            this.AllPriceGrpBx.SuspendLayout();
            this.AllSummaryGroupBx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // GasolineLbl
            // 
            this.GasolineLbl.AutoSize = true;
            this.GasolineLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GasolineLbl.ForeColor = System.Drawing.Color.Blue;
            this.GasolineLbl.Location = new System.Drawing.Point(16, 28);
            this.GasolineLbl.Name = "GasolineLbl";
            this.GasolineLbl.Size = new System.Drawing.Size(97, 25);
            this.GasolineLbl.TabIndex = 0;
            this.GasolineLbl.Text = "Gasoline";
            // 
            // PriceLbl
            // 
            this.PriceLbl.AutoSize = true;
            this.PriceLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceLbl.ForeColor = System.Drawing.Color.Blue;
            this.PriceLbl.Location = new System.Drawing.Point(16, 70);
            this.PriceLbl.Name = "PriceLbl";
            this.PriceLbl.Size = new System.Drawing.Size(61, 25);
            this.PriceLbl.TabIndex = 1;
            this.PriceLbl.Text = "Price";
            // 
            // GasolineComboBx
            // 
            this.GasolineComboBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GasolineComboBx.FormattingEnabled = true;
            this.GasolineComboBx.Location = new System.Drawing.Point(132, 21);
            this.GasolineComboBx.Name = "GasolineComboBx";
            this.GasolineComboBx.Size = new System.Drawing.Size(121, 32);
            this.GasolineComboBx.TabIndex = 2;
            // 
            // PriceTextBx
            // 
            this.PriceTextBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceTextBx.Location = new System.Drawing.Point(132, 70);
            this.PriceTextBx.Name = "PriceTextBx";
            this.PriceTextBx.Size = new System.Drawing.Size(121, 29);
            this.PriceTextBx.TabIndex = 3;
            // 
            // AznLbl
            // 
            this.AznLbl.AutoSize = true;
            this.AznLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AznLbl.ForeColor = System.Drawing.Color.Blue;
            this.AznLbl.Location = new System.Drawing.Point(259, 37);
            this.AznLbl.Name = "AznLbl";
            this.AznLbl.Size = new System.Drawing.Size(30, 16);
            this.AznLbl.TabIndex = 4;
            this.AznLbl.Text = "Azn";
            // 
            // OilGrpBx
            // 
            this.OilGrpBx.Controls.Add(this.SummaryLbl);
            this.OilGrpBx.Controls.Add(this.AllPriceGrpBx);
            this.OilGrpBx.Controls.Add(this.SummaryTextBx);
            this.OilGrpBx.Controls.Add(this.LiterTextBx);
            this.OilGrpBx.Controls.Add(this.ChooseGrpBx);
            this.OilGrpBx.Controls.Add(this.GasolineComboBx);
            this.OilGrpBx.Controls.Add(this.PriceLbl);
            this.OilGrpBx.Controls.Add(this.AznLbl);
            this.OilGrpBx.Controls.Add(this.GasolineLbl);
            this.OilGrpBx.Controls.Add(this.PriceTextBx);
            this.OilGrpBx.Location = new System.Drawing.Point(28, 12);
            this.OilGrpBx.Name = "OilGrpBx";
            this.OilGrpBx.Size = new System.Drawing.Size(310, 374);
            this.OilGrpBx.TabIndex = 5;
            this.OilGrpBx.TabStop = false;
            // 
            // ChooseGrpBx
            // 
            this.ChooseGrpBx.Controls.Add(this.SummaryRadioBtn);
            this.ChooseGrpBx.Controls.Add(this.LiterRadioBtn);
            this.ChooseGrpBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChooseGrpBx.Location = new System.Drawing.Point(21, 122);
            this.ChooseGrpBx.Name = "ChooseGrpBx";
            this.ChooseGrpBx.Size = new System.Drawing.Size(141, 91);
            this.ChooseGrpBx.TabIndex = 5;
            this.ChooseGrpBx.TabStop = false;
            this.ChooseGrpBx.Text = "Choose";
            // 
            // LiterRadioBtn
            // 
            this.LiterRadioBtn.AutoSize = true;
            this.LiterRadioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LiterRadioBtn.Location = new System.Drawing.Point(16, 21);
            this.LiterRadioBtn.Name = "LiterRadioBtn";
            this.LiterRadioBtn.Size = new System.Drawing.Size(58, 24);
            this.LiterRadioBtn.TabIndex = 0;
            this.LiterRadioBtn.TabStop = true;
            this.LiterRadioBtn.Text = "Liter";
            this.LiterRadioBtn.UseVisualStyleBackColor = true;
            // 
            // SummaryRadioBtn
            // 
            this.SummaryRadioBtn.AutoSize = true;
            this.SummaryRadioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SummaryRadioBtn.Location = new System.Drawing.Point(16, 61);
            this.SummaryRadioBtn.Name = "SummaryRadioBtn";
            this.SummaryRadioBtn.Size = new System.Drawing.Size(94, 24);
            this.SummaryRadioBtn.TabIndex = 1;
            this.SummaryRadioBtn.TabStop = true;
            this.SummaryRadioBtn.Text = "Summary";
            this.SummaryRadioBtn.UseVisualStyleBackColor = true;
            // 
            // LiterTextBx
            // 
            this.LiterTextBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LiterTextBx.Location = new System.Drawing.Point(168, 141);
            this.LiterTextBx.Name = "LiterTextBx";
            this.LiterTextBx.Size = new System.Drawing.Size(85, 26);
            this.LiterTextBx.TabIndex = 6;
            // 
            // SummaryTextBx
            // 
            this.SummaryTextBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SummaryTextBx.Location = new System.Drawing.Point(168, 181);
            this.SummaryTextBx.Name = "SummaryTextBx";
            this.SummaryTextBx.Size = new System.Drawing.Size(85, 26);
            this.SummaryTextBx.TabIndex = 7;
            // 
            // AllPriceGrpBx
            // 
            this.AllPriceGrpBx.Controls.Add(this.AllPriceLbl);
            this.AllPriceGrpBx.Controls.Add(this.AllPriceTextBx);
            this.AllPriceGrpBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllPriceGrpBx.Location = new System.Drawing.Point(21, 233);
            this.AllPriceGrpBx.Name = "AllPriceGrpBx";
            this.AllPriceGrpBx.Size = new System.Drawing.Size(268, 124);
            this.AllPriceGrpBx.TabIndex = 8;
            this.AllPriceGrpBx.TabStop = false;
            this.AllPriceGrpBx.Text = "All Price";
            // 
            // SummaryLbl
            // 
            this.SummaryLbl.AutoSize = true;
            this.SummaryLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SummaryLbl.ForeColor = System.Drawing.Color.Blue;
            this.SummaryLbl.Location = new System.Drawing.Point(259, 191);
            this.SummaryLbl.Name = "SummaryLbl";
            this.SummaryLbl.Size = new System.Drawing.Size(30, 16);
            this.SummaryLbl.TabIndex = 9;
            this.SummaryLbl.Text = "Azn";
            // 
            // AllPriceTextBx
            // 
            this.AllPriceTextBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllPriceTextBx.Location = new System.Drawing.Point(71, 48);
            this.AllPriceTextBx.Name = "AllPriceTextBx";
            this.AllPriceTextBx.Size = new System.Drawing.Size(116, 49);
            this.AllPriceTextBx.TabIndex = 8;
            this.AllPriceTextBx.Text = "00,00";
            // 
            // AllPriceLbl
            // 
            this.AllPriceLbl.AutoSize = true;
            this.AllPriceLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllPriceLbl.ForeColor = System.Drawing.Color.Blue;
            this.AllPriceLbl.Location = new System.Drawing.Point(193, 73);
            this.AllPriceLbl.Name = "AllPriceLbl";
            this.AllPriceLbl.Size = new System.Drawing.Size(43, 24);
            this.AllPriceLbl.TabIndex = 10;
            this.AllPriceLbl.Text = "Azn";
            // 
            // AllSummaryGroupBx
            // 
            this.AllSummaryGroupBx.Controls.Add(this.pictureBox1);
            this.AllSummaryGroupBx.Controls.Add(this.AllSummaryLbl);
            this.AllSummaryGroupBx.Controls.Add(this.AllSummaryTextBx);
            this.AllSummaryGroupBx.Controls.Add(this.PayBtn);
            this.AllSummaryGroupBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllSummaryGroupBx.Location = new System.Drawing.Point(28, 392);
            this.AllSummaryGroupBx.Name = "AllSummaryGroupBx";
            this.AllSummaryGroupBx.Size = new System.Drawing.Size(769, 144);
            this.AllSummaryGroupBx.TabIndex = 6;
            this.AllSummaryGroupBx.TabStop = false;
            this.AllSummaryGroupBx.Text = "All Summary";
            // 
            // PayBtn
            // 
            this.PayBtn.Location = new System.Drawing.Point(183, 79);
            this.PayBtn.Name = "PayBtn";
            this.PayBtn.Size = new System.Drawing.Size(156, 59);
            this.PayBtn.TabIndex = 0;
            this.PayBtn.Text = "Pay";
            this.PayBtn.UseVisualStyleBackColor = true;
            // 
            // AllSummaryTextBx
            // 
            this.AllSummaryTextBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllSummaryTextBx.Location = new System.Drawing.Point(533, 89);
            this.AllSummaryTextBx.Name = "AllSummaryTextBx";
            this.AllSummaryTextBx.Size = new System.Drawing.Size(116, 49);
            this.AllSummaryTextBx.TabIndex = 9;
            this.AllSummaryTextBx.Text = "00,00";
            // 
            // AllSummaryLbl
            // 
            this.AllSummaryLbl.AutoSize = true;
            this.AllSummaryLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllSummaryLbl.ForeColor = System.Drawing.Color.Blue;
            this.AllSummaryLbl.Location = new System.Drawing.Point(655, 114);
            this.AllSummaryLbl.Name = "AllSummaryLbl";
            this.AllSummaryLbl.Size = new System.Drawing.Size(43, 24);
            this.AllSummaryLbl.TabIndex = 11;
            this.AllSummaryLbl.Text = "Azn";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::OilTaskWithMVP.Properties.Resources._13;
            this.pictureBox1.Location = new System.Drawing.Point(37, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 565);
            this.Controls.Add(this.AllSummaryGroupBx);
            this.Controls.Add(this.OilGrpBx);
            this.Name = "Form1";
            this.Text = "BestOil";
            this.OilGrpBx.ResumeLayout(false);
            this.OilGrpBx.PerformLayout();
            this.ChooseGrpBx.ResumeLayout(false);
            this.ChooseGrpBx.PerformLayout();
            this.AllPriceGrpBx.ResumeLayout(false);
            this.AllPriceGrpBx.PerformLayout();
            this.AllSummaryGroupBx.ResumeLayout(false);
            this.AllSummaryGroupBx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label GasolineLbl;
        private System.Windows.Forms.Label PriceLbl;
        private System.Windows.Forms.ComboBox GasolineComboBx;
        private System.Windows.Forms.TextBox PriceTextBx;
        private System.Windows.Forms.Label AznLbl;
        private System.Windows.Forms.GroupBox OilGrpBx;
        private System.Windows.Forms.Label SummaryLbl;
        private System.Windows.Forms.GroupBox AllPriceGrpBx;
        private System.Windows.Forms.Label AllPriceLbl;
        private System.Windows.Forms.TextBox AllPriceTextBx;
        private System.Windows.Forms.TextBox SummaryTextBx;
        private System.Windows.Forms.TextBox LiterTextBx;
        private System.Windows.Forms.GroupBox ChooseGrpBx;
        private System.Windows.Forms.RadioButton SummaryRadioBtn;
        private System.Windows.Forms.RadioButton LiterRadioBtn;
        private System.Windows.Forms.GroupBox AllSummaryGroupBx;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label AllSummaryLbl;
        private System.Windows.Forms.TextBox AllSummaryTextBx;
        private System.Windows.Forms.Button PayBtn;
    }
}

