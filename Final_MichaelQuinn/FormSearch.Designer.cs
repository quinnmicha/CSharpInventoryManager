namespace Final_MichaelQuinn
{
    partial class FormSearch
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
            this.DGVResults = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DrpBoxType = new System.Windows.Forms.ComboBox();
            this.TxtBrand = new System.Windows.Forms.TextBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.BtnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVResults)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVResults
            // 
            this.DGVResults.AllowUserToAddRows = false;
            this.DGVResults.AllowUserToDeleteRows = false;
            this.DGVResults.AllowUserToOrderColumns = true;
            this.DGVResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVResults.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DGVResults.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.DGVResults.Location = new System.Drawing.Point(12, 178);
            this.DGVResults.Name = "DGVResults";
            this.DGVResults.ReadOnly = true;
            this.DGVResults.RowHeadersWidth = 51;
            this.DGVResults.RowTemplate.Height = 24;
            this.DGVResults.Size = new System.Drawing.Size(818, 203);
            this.DGVResults.TabIndex = 0;
            this.DGVResults.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvResults_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search by Type, Name, Brand, or a combination";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(490, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(455, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Brand or Brewery";
            // 
            // DrpBoxType
            // 
            this.DrpBoxType.FormattingEnabled = true;
            this.DrpBoxType.Items.AddRange(new object[] {
            "Food",
            "Beer",
            "Liquor",
            "Wine"});
            this.DrpBoxType.Location = new System.Drawing.Point(108, 50);
            this.DrpBoxType.Name = "DrpBoxType";
            this.DrpBoxType.Size = new System.Drawing.Size(121, 24);
            this.DrpBoxType.TabIndex = 3;
            // 
            // TxtBrand
            // 
            this.TxtBrand.Location = new System.Drawing.Point(593, 50);
            this.TxtBrand.Name = "TxtBrand";
            this.TxtBrand.Size = new System.Drawing.Size(100, 22);
            this.TxtBrand.TabIndex = 4;
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(593, 92);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(100, 22);
            this.TxtName.TabIndex = 4;
            // 
            // BtnSearch
            // 
            this.BtnSearch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSearch.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnSearch.Location = new System.Drawing.Point(679, 419);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(151, 55);
            this.BtnSearch.TabIndex = 5;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = false;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // FormSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 496);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.TxtBrand);
            this.Controls.Add(this.DrpBoxType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGVResults);
            this.Name = "FormSearch";
            this.Text = "Manage Inventory";
            ((System.ComponentModel.ISupportInitialize)(this.DGVResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVResults;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox DrpBoxType;
        private System.Windows.Forms.TextBox TxtBrand;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Button BtnSearch;
    }
}