namespace Final_MichaelQuinn
{
    partial class FormData
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
            this.DrpBoxType = new System.Windows.Forms.ComboBox();
            this.LblBrand = new System.Windows.Forms.Label();
            this.LblName = new System.Windows.Forms.Label();
            this.LblStock = new System.Windows.Forms.Label();
            this.LblSeason = new System.Windows.Forms.Label();
            this.LblStyle = new System.Windows.Forms.Label();
            this.LblSize = new System.Windows.Forms.Label();
            this.LblPrice = new System.Windows.Forms.Label();
            this.LblCost = new System.Windows.Forms.Label();
            this.DrpBoxStyle = new System.Windows.Forms.ComboBox();
            this.DrpBoxSize = new System.Windows.Forms.ComboBox();
            this.TxtBrand = new System.Windows.Forms.TextBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtStock = new System.Windows.Forms.TextBox();
            this.TxtSeason = new System.Windows.Forms.TextBox();
            this.TxtCost = new System.Windows.Forms.TextBox();
            this.TxtPrice = new System.Windows.Forms.TextBox();
            this.BtnSubmit = new System.Windows.Forms.Button();
            this.BtnGoBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblErrMsg = new System.Windows.Forms.Label();
            this.LblErrType = new System.Windows.Forms.Label();
            this.LblMark = new System.Windows.Forms.Label();
            this.LblMarkOut = new System.Windows.Forms.Label();
            this.LblProfit = new System.Windows.Forms.Label();
            this.LblProfitOut = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DrpBoxType
            // 
            this.DrpBoxType.FormattingEnabled = true;
            this.DrpBoxType.Items.AddRange(new object[] {
            "Food",
            "Beer",
            "Liquor",
            "Wine"});
            this.DrpBoxType.Location = new System.Drawing.Point(50, 36);
            this.DrpBoxType.Name = "DrpBoxType";
            this.DrpBoxType.Size = new System.Drawing.Size(121, 24);
            this.DrpBoxType.TabIndex = 0;
            this.DrpBoxType.Text = "Type";
            // 
            // LblBrand
            // 
            this.LblBrand.AutoSize = true;
            this.LblBrand.Location = new System.Drawing.Point(26, 88);
            this.LblBrand.Name = "LblBrand";
            this.LblBrand.Size = new System.Drawing.Size(46, 17);
            this.LblBrand.TabIndex = 1;
            this.LblBrand.Text = "Brand";
            this.LblBrand.Visible = false;
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(26, 132);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(45, 17);
            this.LblName.TabIndex = 1;
            this.LblName.Text = "Name";
            this.LblName.Visible = false;
            // 
            // LblStock
            // 
            this.LblStock.AutoSize = true;
            this.LblStock.Location = new System.Drawing.Point(26, 178);
            this.LblStock.Name = "LblStock";
            this.LblStock.Size = new System.Drawing.Size(133, 17);
            this.LblStock.TabIndex = 1;
            this.LblStock.Text = "Amount in Inventory";
            this.LblStock.Visible = false;
            // 
            // LblSeason
            // 
            this.LblSeason.AutoSize = true;
            this.LblSeason.Location = new System.Drawing.Point(26, 227);
            this.LblSeason.Name = "LblSeason";
            this.LblSeason.Size = new System.Drawing.Size(56, 17);
            this.LblSeason.TabIndex = 1;
            this.LblSeason.Text = "Season";
            this.LblSeason.Visible = false;
            // 
            // LblStyle
            // 
            this.LblStyle.AutoSize = true;
            this.LblStyle.Location = new System.Drawing.Point(319, 39);
            this.LblStyle.Name = "LblStyle";
            this.LblStyle.Size = new System.Drawing.Size(39, 17);
            this.LblStyle.TabIndex = 1;
            this.LblStyle.Text = "Style";
            this.LblStyle.Visible = false;
            // 
            // LblSize
            // 
            this.LblSize.AutoSize = true;
            this.LblSize.Location = new System.Drawing.Point(319, 97);
            this.LblSize.Name = "LblSize";
            this.LblSize.Size = new System.Drawing.Size(35, 17);
            this.LblSize.TabIndex = 1;
            this.LblSize.Text = "Size";
            this.LblSize.Visible = false;
            // 
            // LblPrice
            // 
            this.LblPrice.AutoSize = true;
            this.LblPrice.Location = new System.Drawing.Point(319, 222);
            this.LblPrice.Name = "LblPrice";
            this.LblPrice.Size = new System.Drawing.Size(79, 17);
            this.LblPrice.TabIndex = 1;
            this.LblPrice.Text = "Sales Price";
            this.LblPrice.Visible = false;
            // 
            // LblCost
            // 
            this.LblCost.AutoSize = true;
            this.LblCost.Location = new System.Drawing.Point(319, 178);
            this.LblCost.Name = "LblCost";
            this.LblCost.Size = new System.Drawing.Size(36, 17);
            this.LblCost.TabIndex = 1;
            this.LblCost.Text = "Cost";
            this.LblCost.Visible = false;
            // 
            // DrpBoxStyle
            // 
            this.DrpBoxStyle.FormattingEnabled = true;
            this.DrpBoxStyle.Location = new System.Drawing.Point(402, 39);
            this.DrpBoxStyle.Name = "DrpBoxStyle";
            this.DrpBoxStyle.Size = new System.Drawing.Size(121, 24);
            this.DrpBoxStyle.TabIndex = 3;
            this.DrpBoxStyle.Visible = false;
            // 
            // DrpBoxSize
            // 
            this.DrpBoxSize.FormattingEnabled = true;
            this.DrpBoxSize.Location = new System.Drawing.Point(402, 94);
            this.DrpBoxSize.Name = "DrpBoxSize";
            this.DrpBoxSize.Size = new System.Drawing.Size(121, 24);
            this.DrpBoxSize.TabIndex = 3;
            this.DrpBoxSize.Visible = false;
            // 
            // TxtBrand
            // 
            this.TxtBrand.Location = new System.Drawing.Point(175, 85);
            this.TxtBrand.Name = "TxtBrand";
            this.TxtBrand.Size = new System.Drawing.Size(100, 22);
            this.TxtBrand.TabIndex = 4;
            this.TxtBrand.Visible = false;
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(175, 127);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(100, 22);
            this.TxtName.TabIndex = 4;
            this.TxtName.Visible = false;
            // 
            // TxtStock
            // 
            this.TxtStock.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.TxtStock.Location = new System.Drawing.Point(175, 175);
            this.TxtStock.Name = "TxtStock";
            this.TxtStock.Size = new System.Drawing.Size(100, 22);
            this.TxtStock.TabIndex = 4;
            this.TxtStock.Text = "ex. \"24\"";
            this.TxtStock.Visible = false;
            this.TxtStock.Enter += new System.EventHandler(this.TxtStock_Enter);
            // 
            // TxtSeason
            // 
            this.TxtSeason.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.TxtSeason.Location = new System.Drawing.Point(175, 224);
            this.TxtSeason.Name = "TxtSeason";
            this.TxtSeason.Size = new System.Drawing.Size(100, 22);
            this.TxtSeason.TabIndex = 4;
            this.TxtSeason.Text = "ex. \"Fall\"";
            this.TxtSeason.Visible = false;
            this.TxtSeason.Enter += new System.EventHandler(this.TxtSeason_Enter);
            // 
            // TxtCost
            // 
            this.TxtCost.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.TxtCost.Location = new System.Drawing.Point(432, 172);
            this.TxtCost.Name = "TxtCost";
            this.TxtCost.Size = new System.Drawing.Size(78, 22);
            this.TxtCost.TabIndex = 4;
            this.TxtCost.Text = "ex. \"6.23\"";
            this.TxtCost.Visible = false;
            this.TxtCost.Enter += new System.EventHandler(this.TxtCost_Enter);
            // 
            // TxtPrice
            // 
            this.TxtPrice.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.TxtPrice.Location = new System.Drawing.Point(432, 219);
            this.TxtPrice.Name = "TxtPrice";
            this.TxtPrice.Size = new System.Drawing.Size(78, 22);
            this.TxtPrice.TabIndex = 4;
            this.TxtPrice.Text = "ex. \"14.99\"";
            this.TxtPrice.Visible = false;
            this.TxtPrice.Enter += new System.EventHandler(this.TxtPrice_Enter);
            // 
            // BtnSubmit
            // 
            this.BtnSubmit.BackColor = System.Drawing.Color.Lime;
            this.BtnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSubmit.Location = new System.Drawing.Point(432, 417);
            this.BtnSubmit.Name = "BtnSubmit";
            this.BtnSubmit.Size = new System.Drawing.Size(112, 47);
            this.BtnSubmit.TabIndex = 5;
            this.BtnSubmit.Text = "Submit";
            this.BtnSubmit.UseVisualStyleBackColor = false;
            this.BtnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // BtnGoBack
            // 
            this.BtnGoBack.BackColor = System.Drawing.Color.Red;
            this.BtnGoBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGoBack.Location = new System.Drawing.Point(29, 417);
            this.BtnGoBack.Name = "BtnGoBack";
            this.BtnGoBack.Size = new System.Drawing.Size(130, 47);
            this.BtnGoBack.TabIndex = 5;
            this.BtnGoBack.Text = "Go Back";
            this.BtnGoBack.UseVisualStyleBackColor = false;
            this.BtnGoBack.Visible = false;
            this.BtnGoBack.Click += new System.EventHandler(this.BtnGoBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(419, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "$";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(419, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "$";
            this.label2.Visible = false;
            // 
            // LblErrMsg
            // 
            this.LblErrMsg.AutoSize = true;
            this.LblErrMsg.ForeColor = System.Drawing.Color.Red;
            this.LblErrMsg.Location = new System.Drawing.Point(26, 261);
            this.LblErrMsg.Name = "LblErrMsg";
            this.LblErrMsg.Size = new System.Drawing.Size(0, 17);
            this.LblErrMsg.TabIndex = 7;
            // 
            // LblErrType
            // 
            this.LblErrType.AutoSize = true;
            this.LblErrType.ForeColor = System.Drawing.Color.Red;
            this.LblErrType.Location = new System.Drawing.Point(177, 42);
            this.LblErrType.Name = "LblErrType";
            this.LblErrType.Size = new System.Drawing.Size(0, 17);
            this.LblErrType.TabIndex = 8;
            // 
            // LblMark
            // 
            this.LblMark.AutoSize = true;
            this.LblMark.Location = new System.Drawing.Point(319, 270);
            this.LblMark.Name = "LblMark";
            this.LblMark.Size = new System.Drawing.Size(132, 17);
            this.LblMark.TabIndex = 9;
            this.LblMark.Text = "Markup Percentage";
            this.LblMark.Visible = false;
            // 
            // LblMarkOut
            // 
            this.LblMarkOut.AutoSize = true;
            this.LblMarkOut.Location = new System.Drawing.Point(466, 270);
            this.LblMarkOut.Name = "LblMarkOut";
            this.LblMarkOut.Size = new System.Drawing.Size(0, 17);
            this.LblMarkOut.TabIndex = 10;
            // 
            // LblProfit
            // 
            this.LblProfit.AutoSize = true;
            this.LblProfit.Location = new System.Drawing.Point(319, 314);
            this.LblProfit.Name = "LblProfit";
            this.LblProfit.Size = new System.Drawing.Size(85, 17);
            this.LblProfit.TabIndex = 11;
            this.LblProfit.Text = "Profit/(Loss)";
            this.LblProfit.Visible = false;
            // 
            // LblProfitOut
            // 
            this.LblProfitOut.AutoSize = true;
            this.LblProfitOut.Location = new System.Drawing.Point(466, 314);
            this.LblProfitOut.Name = "LblProfitOut";
            this.LblProfitOut.Size = new System.Drawing.Size(0, 17);
            this.LblProfitOut.TabIndex = 12;
            // 
            // FormData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 476);
            this.Controls.Add(this.LblProfitOut);
            this.Controls.Add(this.LblProfit);
            this.Controls.Add(this.LblMarkOut);
            this.Controls.Add(this.LblMark);
            this.Controls.Add(this.LblErrType);
            this.Controls.Add(this.LblErrMsg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnGoBack);
            this.Controls.Add(this.BtnSubmit);
            this.Controls.Add(this.TxtPrice);
            this.Controls.Add(this.TxtCost);
            this.Controls.Add(this.TxtSeason);
            this.Controls.Add(this.TxtStock);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.TxtBrand);
            this.Controls.Add(this.DrpBoxSize);
            this.Controls.Add(this.DrpBoxStyle);
            this.Controls.Add(this.LblCost);
            this.Controls.Add(this.LblPrice);
            this.Controls.Add(this.LblSize);
            this.Controls.Add(this.LblStyle);
            this.Controls.Add(this.LblSeason);
            this.Controls.Add(this.LblStock);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.LblBrand);
            this.Controls.Add(this.DrpBoxType);
            this.Name = "FormData";
            this.Text = "Add Item";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox DrpBoxType;
        private System.Windows.Forms.Label LblBrand;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Label LblStock;
        private System.Windows.Forms.Label LblSeason;
        private System.Windows.Forms.Label LblStyle;
        private System.Windows.Forms.Label LblSize;
        private System.Windows.Forms.Label LblPrice;
        private System.Windows.Forms.Label LblCost;
        private System.Windows.Forms.ComboBox DrpBoxStyle;
        private System.Windows.Forms.ComboBox DrpBoxSize;
        private System.Windows.Forms.TextBox TxtBrand;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TextBox TxtStock;
        private System.Windows.Forms.TextBox TxtSeason;
        private System.Windows.Forms.TextBox TxtCost;
        private System.Windows.Forms.TextBox TxtPrice;
        private System.Windows.Forms.Button BtnSubmit;
        private System.Windows.Forms.Button BtnGoBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblErrMsg;
        private System.Windows.Forms.Label LblErrType;
        private System.Windows.Forms.Label LblMark;
        private System.Windows.Forms.Label LblMarkOut;
        private System.Windows.Forms.Label LblProfit;
        private System.Windows.Forms.Label LblProfitOut;
    }
}