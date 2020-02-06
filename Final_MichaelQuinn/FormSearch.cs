using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventorySystem;

namespace Final_MichaelQuinn
{
    public partial class FormSearch : Form
    {
        public FormSearch()
        {
            InitializeComponent();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            Item temp = new Item();
            DataSet ds = temp.FindItem(DrpBoxType.Text, TxtName.Text, TxtBrand.Text);
            DGVResults.DataSource = ds;
            DGVResults.DataMember = ds.Tables["ItemSearchTemp"].ToString();
        }

        public void DgvResults_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string type = DGVResults.Rows[e.RowIndex].Cells[1].Value.ToString();
            if (type == "Food")
            {

                Item nItem = new Item();
                string itemID = DGVResults.Rows[e.RowIndex].Cells[0].Value.ToString();
                nItem.Brand = DGVResults.Rows[e.RowIndex].Cells[2].Value.ToString();
                nItem.Name = DGVResults.Rows[e.RowIndex].Cells[3].Value.ToString();
                nItem.Stock = DGVResults.Rows[e.RowIndex].Cells[6].Value.ToString();
                nItem.Price = DGVResults.Rows[e.RowIndex].Cells[8].Value.ToString();
                nItem.Markup = DGVResults.Rows[e.RowIndex].Cells[9].Value.ToString();
                nItem.Profit = DGVResults.Rows[e.RowIndex].Cells[10].Value.ToString();
                nItem.Cost = DGVResults.Rows[e.RowIndex].Cells[11].Value.ToString();
                FormData show = new FormData(type, nItem, itemID);
                show.ShowDialog();
            }
            else if (type == "Beer")
            {
                Beer nItem = new Beer();
                string itemID = DGVResults.Rows[e.RowIndex].Cells[0].Value.ToString();
                nItem.Brand = DGVResults.Rows[e.RowIndex].Cells[2].Value.ToString();
                nItem.Name = DGVResults.Rows[e.RowIndex].Cells[3].Value.ToString();
                nItem.Style = DGVResults.Rows[e.RowIndex].Cells[4].Value.ToString();
                nItem.Season = DGVResults.Rows[e.RowIndex].Cells[5].Value.ToString();
                nItem.Stock = DGVResults.Rows[e.RowIndex].Cells[6].Value.ToString();
                nItem.Size = DGVResults.Rows[e.RowIndex].Cells[7].Value.ToString();
                nItem.Price = DGVResults.Rows[e.RowIndex].Cells[8].Value.ToString();
                nItem.Markup = DGVResults.Rows[e.RowIndex].Cells[9].Value.ToString();
                nItem.Profit = DGVResults.Rows[e.RowIndex].Cells[10].Value.ToString();
                nItem.Cost = DGVResults.Rows[e.RowIndex].Cells[11].Value.ToString();
                FormData show = new FormData(type, nItem, itemID);
                show.ShowDialog();
            }
            else if(type == "Liquor")
            {
                Liquor nItem = new Liquor();
                string itemID = DGVResults.Rows[e.RowIndex].Cells[0].Value.ToString();
                nItem.Brand = DGVResults.Rows[e.RowIndex].Cells[2].Value.ToString();
                nItem.Name = DGVResults.Rows[e.RowIndex].Cells[3].Value.ToString();
                nItem.Style = DGVResults.Rows[e.RowIndex].Cells[4].Value.ToString();
                nItem.Stock = DGVResults.Rows[e.RowIndex].Cells[6].Value.ToString();
                nItem.Size = DGVResults.Rows[e.RowIndex].Cells[7].Value.ToString();
                nItem.Price = DGVResults.Rows[e.RowIndex].Cells[8].Value.ToString();
                nItem.Markup = DGVResults.Rows[e.RowIndex].Cells[9].Value.ToString();
                nItem.Profit = DGVResults.Rows[e.RowIndex].Cells[10].Value.ToString();
                nItem.Cost = DGVResults.Rows[e.RowIndex].Cells[11].Value.ToString();
                FormData show = new FormData(type, nItem, itemID);
                show.ShowDialog();
            }
            else
            {
                Wine nItem = new Wine();
                string itemID = DGVResults.Rows[e.RowIndex].Cells[0].Value.ToString();
                nItem.Brand = DGVResults.Rows[e.RowIndex].Cells[2].Value.ToString();
                nItem.Name = DGVResults.Rows[e.RowIndex].Cells[3].Value.ToString();
                nItem.Style = DGVResults.Rows[e.RowIndex].Cells[4].Value.ToString();
                nItem.Stock = DGVResults.Rows[e.RowIndex].Cells[6].Value.ToString();
                nItem.Size = DGVResults.Rows[e.RowIndex].Cells[7].Value.ToString();
                nItem.Price = DGVResults.Rows[e.RowIndex].Cells[8].Value.ToString();
                nItem.Markup = DGVResults.Rows[e.RowIndex].Cells[9].Value.ToString();
                nItem.Profit = DGVResults.Rows[e.RowIndex].Cells[10].Value.ToString();
                nItem.Cost = DGVResults.Rows[e.RowIndex].Cells[11].Value.ToString();
                FormData show = new FormData(type, nItem, itemID);
                show.ShowDialog();
            }

            DGVResults.DataSource = null;
            
            
        
        }
    }
}
