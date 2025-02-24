using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop
{
    public partial class BorrowingsPage : Form
    {
        private List<string> ids = new List<string>();
        public BorrowingsPage()
        {
            InitializeComponent();
        }


        private async void updateCdgvBorrowings(string search)
        {
            cdgvBorrowings.DataSource = null;
            cdgvBorrowings.Columns.Clear();
            ids.Clear();
            List<Dictionary<string, string>> response = (List<Dictionary<string, string>>)await ApiComm.SendPost(new Dictionary<string, string> { { "type", "getBorrowings" }, { "search", search } });
            if (response.Count > 0)
            {
                DataTable dt = new DataTable();
                DataColumn col;
                DataRow row;
                //make the dataset columns
                foreach (KeyValuePair<string, string> item in response[0])
                {
                    if (item.Key != "borrowing_id")
                    {
                        col = new DataColumn();
                        col.DataType = typeof(string);
                        col.ReadOnly = true;
                        col.ColumnName = item.Key;
                        col.Caption = item.Key;
                        dt.Columns.Add(col);
                    }

                }



                //make rows
                for (int i = 0; i < response.Count(); i++)
                {
                    row = dt.NewRow();
                    foreach (KeyValuePair<string, string> item in response[i])
                    {
                        if (item.Key == "borrowing_id")
                        {
                            ids.Add(item.Value);
                        }
                        else
                        {
                            row[item.Key] = item.Value;
                        }

                    }
                    dt.Rows.Add(row);
                }

                cdgvBorrowings.DataSource = dt;



                //disable sorting just so it works
                foreach (DataGridViewColumn column in cdgvBorrowings.Columns)
                {
                    column.SortMode = DataGridViewColumnSortMode.NotSortable;
                }
            }
        }

        private void BorrowingsPage_Load(object sender, EventArgs e)
        {
            updateCdgvBorrowings("");
            ctbSearch.KeyPress += ctbSearch_KeyPress;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (ctbSearch.Texts != ctbSearch.PlaceholderText)
            {
                updateCdgvBorrowings(ctbSearch.Texts);
            }
            else
            {
                updateCdgvBorrowings("");
            }
        }
        private void ctbSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (ctbSearch.Texts != ctbSearch.PlaceholderText)
                {
                    updateCdgvBorrowings(ctbSearch.Texts);
                }
                else
                {
                    updateCdgvBorrowings("");
                }
            }

        }
    }
}
