using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using InventorySystem;

namespace Final_MichaelQuinn

/*
 Michael Quinn 9/18/2019
Final Project | This program should act like an inventory manager
    
    This program should not crash or take in garbage data besides names and Season from the beer class
   
 */
{
    public partial class FormData : Form
    {
        string indexSQL;// for updating and deleting in SQL

        //4 ways depending on class to enter the form
        public FormData(string itype, Item temp, string index) 
        {
            InitializeComponent();
            Show(itype, "on");
            ShowMarkAndPrice(temp.Markup, temp.Profit, ref noChange);
            TextChange(TxtCost);
            TextChange(TxtStock);
            TextChange(TxtPrice);
            TxtBrand.Text = temp.Brand;
            TxtName.Text = temp.Name;
            TxtStock.Text = temp.Stock;
            TxtPrice.Text = temp.Price;
            TxtCost.Text = temp.Cost;
            itemType = itype;
            indexSQL = index;
            LblSize.Visible = false;
            DrpBoxSize.Visible = false;
        }
        public FormData(string itype, Beer temp, string index)
        {
            InitializeComponent();
            TextChange(TxtCost);
            TextChange(TxtStock);
            TextChange(TxtPrice);
            TextChange(TxtSeason);
            Show(itype, "on");
            ShowMarkAndPrice(temp.Markup, temp.Profit, ref noChange);
            TypeAdd(temp.BeerTypes, DrpBoxStyle);
            TypeAdd(temp.BeerSizes, DrpBoxSize);
            DrpBoxSize.Text = temp.Size;
            DrpBoxStyle.Text = temp.Style;
            TxtBrand.Text = temp.Brand;
            TxtName.Text = temp.Name;
            TxtStock.Text = temp.Stock;
            TxtPrice.Text = temp.Price;
            TxtCost.Text = temp.Cost;
            TxtSeason.Text = temp.Season;
            itemType = itype;
            indexSQL = index;
        }
        public FormData(string itype, Liquor temp, string index)
        {
            InitializeComponent();
            TextChange(TxtCost);
            TextChange(TxtStock);
            TextChange(TxtPrice);
            Show(itype, "on");
            ShowMarkAndPrice(temp.Markup, temp.Profit, ref noChange);
            TypeAdd(temp.LiquorTypes, DrpBoxStyle);
            TypeAdd(temp.LiquorSizes, DrpBoxSize);
            DrpBoxSize.Text = temp.Size;
            DrpBoxStyle.Text = temp.Style;
            TxtBrand.Text = temp.Brand;
            TxtName.Text = temp.Name;
            TxtStock.Text = temp.Stock;
            TxtPrice.Text = temp.Price;
            TxtCost.Text = temp.Cost;
            itemType = itype;
            indexSQL = index;
        }
        public FormData(string itype, Wine temp, string index)
        {
            InitializeComponent();
            TextChange(TxtCost);
            TextChange(TxtStock);
            TextChange(TxtPrice);
            Show(itype, "on");
            ShowMarkAndPrice(temp.Markup, temp.Profit, ref noChange);
            TypeAdd(temp.WineTypes, DrpBoxStyle);
            TypeAdd(temp.WineSizes, DrpBoxSize);
            DrpBoxSize.Text = temp.Size;
            DrpBoxStyle.Text = temp.Style;
            TxtBrand.Text = temp.Brand;
            TxtName.Text = temp.Name;
            TxtStock.Text = temp.Stock;
            TxtPrice.Text = temp.Price;
            TxtCost.Text = temp.Cost;
            itemType = itype;
            indexSQL = index;
        }
        //
        public FormData()
        {
            InitializeComponent();
        }
        private bool noChange = false; //This bool is used to stop the txt box event when visiting form from search
        private int token = 0; //token acts as a boolean value for the two stages of the "Add Item" part of the form
        private string itemType;
        string[] types = { "Food", "Beer", "Liquor", "Wine" };

        //****EVENTS*******************************************
        //Submit and Update Button
        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            if (noChange == false)
            {


                if (token == 0)
                {
                    itemType = DrpBoxType.Text;
                    if (itemType == "Beer")
                    {
                        Beer temp = new Beer();
                        token++;
                        DropBoxEmpty(DrpBoxStyle);
                        DropBoxEmpty(DrpBoxSize);
                        TypeAdd(temp.BeerTypes, DrpBoxStyle);
                        TypeAdd(temp.BeerSizes, DrpBoxSize);
                        Show(itemType, "on");

                    }
                    else if (itemType == "Food")
                    {
                        token++;
                        DropBoxEmpty(DrpBoxStyle);
                        DropBoxEmpty(DrpBoxSize);
                        Show(itemType, "on");
                        LblSize.Visible = false;
                        DrpBoxSize.Visible = false;
                    }
                    else if (itemType == "Liquor" || itemType == "Wine")
                    {
                        token++;
                        DropBoxEmpty(DrpBoxStyle);
                        DropBoxEmpty(DrpBoxSize);
                        if (itemType == "Liquor")
                        {
                            Liquor temp = new Liquor();
                            TypeAdd(temp.LiquorTypes, DrpBoxStyle);
                            TypeAdd(temp.LiquorSizes, DrpBoxSize);
                        }
                        else
                        {
                            Wine temp = new Wine();
                            TypeAdd(temp.WineTypes, DrpBoxStyle);
                            TypeAdd(temp.WineSizes, DrpBoxSize);
                        }
                        Show(itemType, "on");
                    }

                    else { LblErrType.Text = "*Pick One*"; }
                    if (token == 1)
                    {
                        LblErrType.Text = "";
                    }
                }
                else if (token == 1)
                {

                    if (itemType == "Beer")
                    {
                        Beer temp = new Beer();

                        temp.Brand = TxtBrand.Text;
                        temp.Name = TxtName.Text;
                        temp.Style = DrpBoxStyle.Text;
                        temp.Size = DrpBoxSize.Text;
                        temp.Stock = TxtStock.Text;
                        temp.Price = TxtPrice.Text;
                        temp.Cost = TxtCost.Text;
                        temp.Season = TxtSeason.Text;
                        if (temp.ErrMsg.Length < 1)
                        {
                            token = 0;
                            MessageBox.Show(temp.Display());
                            Show(itemType, "off");
                            MessageBox.Show(temp.SendData(itemType));
                        }
                        LblErrMsg.Text = temp.ErrMsg;
                    }
                    else if (itemType == "Food")
                    {
                        Item temp = new Item();

                        temp.Brand = TxtBrand.Text;
                        temp.Name = TxtName.Text;
                        temp.Stock = TxtStock.Text;
                        temp.Price = TxtPrice.Text;
                        temp.Cost = TxtCost.Text;
                        if (temp.ErrMsg.Length < 1)
                        {
                            token = 0;
                            MessageBox.Show(temp.Display());
                            Show(itemType, "off");
                            MessageBox.Show(temp.SendData(itemType));
                        }
                        LblErrMsg.Text = temp.ErrMsg;
                    }
                    else if (itemType == "Liquor")
                    {
                        Liquor temp = new Liquor();

                        temp.Brand = TxtBrand.Text;
                        temp.Name = TxtName.Text;
                        temp.Style = DrpBoxStyle.Text;
                        temp.Size = DrpBoxSize.Text;
                        temp.Stock = TxtStock.Text;
                        temp.Price = TxtPrice.Text;
                        temp.Cost = TxtCost.Text;
                        if (temp.ErrMsg.Length < 1)
                        {
                            token = 0;
                            MessageBox.Show(temp.Display());
                            Show(itemType, "off");
                            MessageBox.Show(temp.SendData(itemType));
                        }
                        LblErrMsg.Text = temp.ErrMsg;
                    }
                    else
                    {
                        Wine temp = new Wine();

                        temp.Brand = TxtBrand.Text;
                        temp.Name = TxtName.Text;
                        temp.Style = DrpBoxStyle.Text;
                        temp.Size = DrpBoxSize.Text;
                        temp.Stock = TxtStock.Text;
                        temp.Price = TxtPrice.Text;
                        temp.Cost = TxtCost.Text;
                        if (temp.ErrMsg.Length < 1)
                        {
                            token = 0;
                            MessageBox.Show(temp.Display());
                            Show(itemType, "off");
                            MessageBox.Show(temp.SendData(itemType));
                        }
                        LblErrMsg.Text = temp.ErrMsg;
                    }
                }
            }
            else
            {
                if (itemType == "Food")
                {
                    Item temp = new Item();
                    temp.Brand = TxtBrand.Text;
                    temp.Name = TxtName.Text;
                    temp.Stock = TxtStock.Text;
                    temp.Price = TxtPrice.Text;
                    temp.Cost = TxtCost.Text;
                    temp.Markup = temp.GetMark(temp.Price, temp.Cost);
                    temp.Profit = temp.GetProfit(temp.Stock, temp.Price, temp.Cost);
                    if (temp.ErrMsg.Length < 1)
                    {
                        token = 0;
                        MessageBox.Show(temp.Display());
                        MessageBox.Show(temp.UpdateData(indexSQL));
                        this.Close();
                    }
                    LblErrMsg.Text = temp.ErrMsg;
                }
                else if (itemType == "Beer")
                {
                    Beer temp = new Beer();
                    temp.Brand = TxtBrand.Text;
                    temp.Name = TxtName.Text;
                    temp.Style = DrpBoxStyle.Text;
                    temp.Size = DrpBoxSize.Text;
                    temp.Stock = TxtStock.Text;
                    temp.Price = TxtPrice.Text;
                    temp.Cost = TxtCost.Text;
                    temp.Season = TxtSeason.Text;
                    temp.Markup = temp.GetMark(temp.Price, temp.Cost);
                    temp.Profit = temp.GetProfit(temp.Stock, temp.Price, temp.Cost);
                    if (temp.ErrMsg.Length < 1)
                    {
                        token = 0;
                        MessageBox.Show(temp.Display());
                        MessageBox.Show(temp.UpdateData(indexSQL));
                        this.Close();
                    }
                    LblErrMsg.Text = temp.ErrMsg;
                }
                else if (itemType == "Liquor")
                {
                    Liquor temp = new Liquor();
                    temp.Brand = TxtBrand.Text;
                    temp.Name = TxtName.Text;
                    temp.Style = DrpBoxStyle.Text;
                    temp.Size = DrpBoxSize.Text;
                    temp.Stock = TxtStock.Text;
                    temp.Price = TxtPrice.Text;
                    temp.Cost = TxtCost.Text;
                    temp.Markup = temp.GetMark(temp.Price, temp.Cost);
                    temp.Profit = temp.GetProfit(temp.Stock, temp.Price, temp.Cost);
                    if (temp.ErrMsg.Length < 1)
                    {
                        token = 0;
                        MessageBox.Show(temp.Display());
                        MessageBox.Show(temp.UpdateData(indexSQL));
                        this.Close();
                    }
                    LblErrMsg.Text = temp.ErrMsg;
                }
                else
                {
                    Wine temp = new Wine();
                    temp.Brand = TxtBrand.Text;
                    temp.Name = TxtName.Text;
                    temp.Style = DrpBoxStyle.Text;
                    temp.Size = DrpBoxSize.Text;
                    temp.Stock = TxtStock.Text;
                    temp.Price = TxtPrice.Text;
                    temp.Cost = TxtCost.Text;
                    temp.Markup = temp.GetMark(temp.Price, temp.Cost);
                    temp.Profit = temp.GetProfit(temp.Stock, temp.Price, temp.Cost);
                    if (temp.ErrMsg.Length < 1)
                    {
                        token = 0;
                        MessageBox.Show(temp.Display());
                        MessageBox.Show(temp.UpdateData(indexSQL));
                        this.Close();
                    }
                    LblErrMsg.Text = temp.ErrMsg;
                }
            }
        }

        //GoBack and Delete Button
        private void BtnGoBack_Click(object sender, EventArgs e)
        {
            if (noChange == false)
            {
                DropBoxEmpty(DrpBoxStyle);
                DropBoxEmpty(DrpBoxSize);
                token = 0;
                Show(itemType, "Off");
                LblErrMsg.Text = "";
            }
            else
            {
                Item temp = new Item();
                MessageBox.Show(temp.DeleteData(indexSQL));
                this.Close();
            }
        }
        
        //These are basically all the same event to change txt box color and empty when clicked on
        private void TxtStock_Enter(object sender, EventArgs e)
        {
            TextChange(TxtStock);
        }
        private void TxtPrice_Enter(object sender, EventArgs e)
        {
            TextChange(TxtPrice);
        }
        private void TxtSeason_Enter(object sender, EventArgs e)
        {
            TextChange(TxtSeason);
        }
        private void TxtCost_Enter(object sender, EventArgs e)
        {
            TextChange(TxtCost);
        }

        //*****FUNCTIONS********************************************

        //Loop empties items of the combo box
        private void DropBoxEmpty(ComboBox DrpBoxName)
        {
            while (DrpBoxName.Items.Count > 0)
            {
                DrpBoxName.Items.RemoveAt(0);
            }
        }

        //Changes the form based on the user's interaction
        private void Show(string type, string x)//x is to turn Show on or off
        {
            bool tempAns1 = false;
            bool tempAns2 = true;
            if (x == "on")
            {
                tempAns1 = true;
                tempAns2 = false;
            }
            LblStock.Visible = tempAns1;
            LblBrand.Visible = tempAns1;
            LblPrice.Visible = tempAns1;
            LblName.Visible = tempAns1;
            LblBrand.Text = "Brand Name";
            if (type == "Beer")
            {
                LblSeason.Visible = tempAns1;
                TxtSeason.Visible = tempAns1;
                LblBrand.Text = "Brewery Name";
            }
            LblSize.Visible = tempAns1;
            DrpBoxSize.Visible = tempAns1;
            if (type != "Food")
            {
                LblSize.Visible = tempAns1;
                LblStyle.Visible = tempAns1;
                DrpBoxStyle.Visible = tempAns1;
                DrpBoxSize.Visible = tempAns1;
            }
            TxtBrand.Visible = tempAns1;
            TxtName.Visible = tempAns1;
            TxtPrice.Visible = tempAns1;
            TxtStock.Visible = tempAns1;
            BtnGoBack.Visible = tempAns1;
            DrpBoxType.Visible = tempAns2;
            LblCost.Visible = tempAns1;
            TxtCost.Visible = tempAns1;
            label1.Visible = tempAns1;
            label2.Visible = tempAns1;
        }

        //This sets the design of the form and changes profit to be green or red
        //This is also the only function by ref I have
        private void ShowMarkAndPrice(string mark, string profit, ref bool tempAns1)
        {
            tempAns1 = true;
            LblMark.Visible = tempAns1;
            LblMarkOut.Visible = tempAns1;
            LblProfit.Visible = tempAns1;
            LblProfitOut.Visible = tempAns1;
            LblMarkOut.Text = mark;
            this.Text = "Update Item";
            BtnSubmit.Text = "Update";
            BtnGoBack.Text = "Delete";
            
            double.TryParse(profit, out double x);
            if (x > 0)
            {
                LblProfitOut.ForeColor = Color.Green;
                LblProfitOut.Text = "$" +profit;
            }
            else
            {
                LblProfitOut.ForeColor = Color.Red;
                double.TryParse(profit, out double y);
                y = y * -1;
                LblProfitOut.Text += "$(" + y + ")";
            }
        }

        //Function for Txt Box event
        private void TextChange(TextBox x)
        {
            if (noChange == false)
            {
                x.Text = "";
            }
            x.ForeColor = SystemColors.WindowText;
        }
        
        //Loop function that adds array items to the combo box
        private void TypeAdd(string[] type, ComboBox DrpBoxName)
        {
            foreach (string val in type)
            {
                DrpBoxName.Items.Add(val);
            }
        }
        //*************************************************************


        
        
        


        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
