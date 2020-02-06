using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValleyLibrary;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;

namespace InventorySystem
{
    public class Wine : Item
    {
        private string style, size;
        private string[] wineTypes = { "Chardonnay", "Pinot Noir", "Merlot", "Red Blend" };
        private string[] wineSizes = { "750 ml", "1 Liter", "1.5 Liters" };
        public string[] WineTypes
        {
            get { return wineTypes; }
        }
        public string [] WineSizes
        {
            get { return wineSizes; }
        }
        public string Style
        {
            get { return style; }
            set
            {
                if (WineTypes.Contains(value)) { style = value; }
                else { errMsg += "\nPlease choose a style from the drop down menu"; }
            }
        }
        public string Size
        {
            get { return size; }
            set
            {
                if (WineSizes.Contains(value))
                {
                    size = value;
                }
                else { errMsg += "\nPlease select one size"; }
            }
        }
        public Wine() : base()
        {
            size = "";
            style = "";
        }

        public override string Display()
        {
            return base.Display() + $", {size} Bottles\nStyle : {style}";

        }

        public new string SendData(string itemType)
        {
            string didWeMakeIt = "";
            SqlConnection connection = new SqlConnection(StrConnect);
            Markup = GetMark(Price, Cost);
            Profit = GetProfit(Stock, Price, Cost);

            string insertData = "INSERT INTO Store (Type, Brand, Name, Style, Stock, Size, Price, Markup, Profit, Cost) VALUES (@Type, @Brand, @Name, @Style, @Stock, @Size, @Price, @Markup, @Profit, @Cost)";
            SqlCommand insertCom = new SqlCommand();
            insertCom.CommandText = insertData;
            insertCom.Connection = connection;

            insertCom.Parameters.AddWithValue("@Type", itemType);
            insertCom.Parameters.AddWithValue("@Brand", Brand);
            insertCom.Parameters.AddWithValue("@Name", Name);
            insertCom.Parameters.AddWithValue("@Style", Style);
            insertCom.Parameters.AddWithValue("@Stock", Convert.ToInt32(Stock));
            insertCom.Parameters.AddWithValue("@Size", Size);
            insertCom.Parameters.AddWithValue("@Markup", Markup);
            insertCom.Parameters.AddWithValue("@Profit", Profit);
            insertCom.Parameters.AddWithValue("@Cost", Cost) ;
            insertCom.Parameters.AddWithValue("@Price", Convert.ToDouble(Price));

            try
            {
                connection.Open();
                int recs = insertCom.ExecuteNonQuery();
                didWeMakeIt = $"Inserted {recs} record into the database";
            }
            catch (SqlException ex)
            {
                didWeMakeIt = ex.Message;
            }
            finally { }

            return didWeMakeIt;
        }

        public new string UpdateData(string index)
        {
            string didWeMakeIt = "";
            SqlConnection connection = new SqlConnection(StrConnect);
            

            string updateData = "UPDATE Store SET Brand = @Brand, Name = @Name, Style = @Style, Stock = @Stock, Size = @Size, Markup = @Markup, Profit = @Profit, Price = @Price, Cost = @Cost Where ID = @ID;";
            SqlCommand updateCom = new SqlCommand();
            updateCom.CommandText = updateData;
            updateCom.Connection = connection;

            updateCom.Parameters.AddWithValue("@Brand", Brand);
            updateCom.Parameters.AddWithValue("@Name", Name);
            updateCom.Parameters.AddWithValue("@Style", Style);
            updateCom.Parameters.AddWithValue("@Stock", Convert.ToInt32(Stock));
            updateCom.Parameters.AddWithValue("@Size", Size);
            updateCom.Parameters.AddWithValue("@Price", Convert.ToDouble(Price));
            updateCom.Parameters.AddWithValue("@Markup", Markup);
            updateCom.Parameters.AddWithValue("@Profit", Profit);
            updateCom.Parameters.AddWithValue("@Cost", Cost);
            updateCom.Parameters.AddWithValue("@ID", Convert.ToInt32(index));

            try
            {
                connection.Open();
                int recs = updateCom.ExecuteNonQuery();
                didWeMakeIt = $"Updated {recs} record into the database";
            }
            catch (SqlException ex)
            {
                didWeMakeIt = ex.Message;
            }
            finally { }

            return didWeMakeIt;
        }
    }
}
