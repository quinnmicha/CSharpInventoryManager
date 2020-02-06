using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValleyLibrary;
using System.Data;
using System.Data.SqlClient;

namespace InventorySystem
{
    public class Item
    {
        private string brand, name, stock, cost, price, markup, profit;
        protected string strConnect = "Data Source = sql.neit.edu\\studentsqlserver,4500; Initial Catalog = SE245_MQuinn; User ID = SE245_MQuinn; Password = A1B2C3";


        protected string errMsg;


        public string Brand
        {
            get { return brand; }
            set
            {
                if (ValleyLib.IsFilled(value) == true) { brand = value; }
                else { errMsg += "\nDon't leave Brand blank"; }
            }
        }
        public string Name
        {
            get { return name; }
            set
            {
                if (ValleyLib.IsFilled(value) == true) { name = value; }
                else { errMsg += "\nDon't leave Name blank"; }
            }
        }
        public string Stock
        {
            get { return stock; }
            set
            {

                if (ValleyLib.IsStringWholeNumber(value) == true)
                {
                    stock = value;
                }
                else
                {
                    errMsg += "\nStock must be a whole number, greater than 0 ";
                }
            }
        }
        public string Price
        {
            get { return price; }
            set
            {

                if (ValleyLib.IsDoubOver0(value) == true)
                {
                    price = value;
                }
                else
                {
                    errMsg += "\nPrice must be set greater than 0 (ex. 21.99)";
                }
            }
        }
        public string Cost
        {
            get { return cost; }
            set
            {

                if (ValleyLib.IsDoubOver0(value) == true)
                {
                    cost = value;
                }
                else
                {
                    errMsg += "\nCost must be set greater than 0 (ex. 4.99)";
                }
            }
        }
        public string Markup//Only used in data pull
        {
            get { return markup; }
            set { markup = value; }
        }
        public string Profit//Only used in data pull
        {
            get;
            set;
        }
        
        public string StrConnect
        {
            get { return strConnect; }
        }
        public string ErrMsg
        {
            get { return errMsg; }
        }

        public Item()
        {
            brand = "";
            name = "";
            stock = "";
            price = "";
            cost = "";
            markup = "";
            profit = "";
            errMsg = "";
        }

        
        public string DeleteData(string index)
        {
            string didWeMakeIt = "";
            SqlConnection connection = new SqlConnection(StrConnect);

            string deleteData = "Delete From Store Where ID = @ID;";
            SqlCommand deleteCom = new SqlCommand();
            deleteCom.CommandText = deleteData;
            deleteCom.Connection = connection;

            deleteCom.Parameters.AddWithValue("@ID", Convert.ToInt32(index));


            try
            {
                connection.Open();
                int recs = deleteCom.ExecuteNonQuery();
                didWeMakeIt = $"Deleted {recs} record into the database";
            }
            catch (SqlException ex)
            {
                didWeMakeIt = ex.Message;
            }
            finally { }

            return didWeMakeIt;
        }

        public virtual string Display()
        {
            return $"Brand : {brand} \nName : {name}\nCost : ${cost}\nPrice : ${price}\nStock : {stock}";
        }

        public DataSet FindItem(string type, string name, string brand) 
        {
            DataSet ds = new DataSet();
            SqlCommand select = new SqlCommand();
            string strSelect = "SELECT * FROM Store Where 0=0 ";

            if (type.Length > 0 && type != "Type")
            {
                strSelect += "AND Type like @Type ";
                select.Parameters.AddWithValue("@Type", "%" + type + "%");
            }
            if (name.Length > 0)
            {
                strSelect += "AND Name LIKE @Name ";
                select.Parameters.AddWithValue("@Name", "%" + name + "%");
            }
            if (brand.Length > 0)
            {
                strSelect += "AND Brand LIKE @Brand ";
                select.Parameters.AddWithValue("@Brand", "%" + brand + "%");
            }

            string connString = strConnect;
            SqlConnection connection = new SqlConnection(connString);
            select.Connection = connection;
            select.CommandText = strSelect;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = select;

            connection.Open();
            da.Fill(ds, "ItemSearchTemp");
            connection.Close();

            return ds;
        }

        //Does the math on the markup percentage
        public string GetMark(string price, string cost)
        {
            return Convert.ToInt32(((Convert.ToDouble(price) - Convert.ToDouble(cost)) / Convert.ToDouble(cost)) * 100).ToString() + "%";
        }
            
        //Does the math on the projected profit
        public string GetProfit(string stock, string price, string cost)
        {
            return ((Convert.ToInt32(stock) * Convert.ToDouble(price)) - (Convert.ToInt32(stock) * Convert.ToDouble(cost))).ToString();
        }
        
        public string SendData(string itemType)
        {
            string didWeMakeIt = "";
            SqlConnection connection = new SqlConnection(StrConnect);
            Markup = GetMark(Price, Cost);
            Profit = GetProfit(Stock, Price, Cost);


            string insertData = "INSERT INTO Store (Type, Brand, Name, Stock, Price, Markup, Profit, Cost) VALUES (@Type, @Brand, @Name, @Stock, @Price, @Markup, @Profit, @Cost)";
            SqlCommand insertCom = new SqlCommand();
            insertCom.CommandText = insertData;
            insertCom.Connection = connection;

            insertCom.Parameters.AddWithValue("@Type", itemType);
            insertCom.Parameters.AddWithValue("@Brand", Brand);
            insertCom.Parameters.AddWithValue("@Name", Name);
            insertCom.Parameters.AddWithValue("@Stock", Convert.ToInt32(Stock));
            insertCom.Parameters.AddWithValue("@Price", Convert.ToDouble(Price));
            insertCom.Parameters.AddWithValue("@Markup", Markup);
            insertCom.Parameters.AddWithValue("@Profit", Profit);
            insertCom.Parameters.AddWithValue("@Cost", Cost);

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

        public string UpdateData(string index)
        {
            string didWeMakeIt = "";
            SqlConnection connection = new SqlConnection(StrConnect);


            string updateData = "UPDATE Store SET Brand = @Brand, Name = @Name, Stock = @Stock, Markup = @Markup, Profit = @Profit, Price = @Price, Cost = @Cost Where ID = @ID;";
            SqlCommand updateCom = new SqlCommand();
            updateCom.CommandText = updateData;
            updateCom.Connection = connection;

            updateCom.Parameters.AddWithValue("@Brand", Brand);
            updateCom.Parameters.AddWithValue("@Name", Name);
            updateCom.Parameters.AddWithValue("@Stock", Convert.ToInt32(Stock));
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
