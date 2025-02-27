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
    public partial class BookingsPage : Form
    {
        private List<string> ids = new List<string>();
        private List<string> states = new List<string>();

        public BookingsPage()
        {
            InitializeComponent();
        }

        private async void updateCdgvBookings(string search)
        {
            cdgvBookings.DataSource = null;
            cdgvBookings.Columns.Clear();
            ids.Clear();
            List<Dictionary<string, string>> response = (List<Dictionary<string, string>>)await ApiComm.SendPost(new Dictionary<string, string> { { "type", "getBookings" }, { "search", search } });
            if (response.Count > 0)
            {
                DataTable dt = new DataTable();
                DataColumn col;
                DataRow row;
                //make the dataset columns
                foreach (KeyValuePair<string, string> item in response[0])
                {
                    if (item.Key != "booking_id" && item.Key != "handled")
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
                        if (item.Key == "booking_id")
                        {
                            ids.Add(item.Value);
                        }else if(item.Key == "handled")
                        {
                            states.Add(item.Value);
                        }
                        else
                        {
                            row[item.Key] = item.Value;
                        }

                        

                    }
                    dt.Rows.Add(row);
                }

                cdgvBookings.DataSource = dt;

                for (int i = 0; i < cdgvBookings.RowCount; i++) {
                    if (states[i] == "0")
                    {
                        cdgvBookings.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                    }
                }


                //disable sorting just so it works
                foreach (DataGridViewColumn column in cdgvBookings.Columns)
                {
                    column.SortMode = DataGridViewColumnSortMode.NotSortable;
                }
            }
        }

        private void BookingsPage_Load(object sender, EventArgs e)
        {
            updateCdgvBookings("");
            ctbSearch.KeyPress += ctbSearch_KeyPress;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (ctbSearch.Texts != ctbSearch.PlaceholderText)
            {
                updateCdgvBookings(ctbSearch.Texts);
            }
            else
            {
                updateCdgvBookings("");
            }
        }
        private void ctbSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (ctbSearch.Texts != ctbSearch.PlaceholderText)
                {
                    updateCdgvBookings(ctbSearch.Texts);
                }
                else
                {
                    updateCdgvBookings("");
                }
            }

        }

        private async void cdgvBookings_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && states[e.RowIndex] == "0")
            {
                cdgvBookings.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(51, 51, 68);
                states[e.RowIndex] = "1";
                await ApiComm.SendPost(new Dictionary<string, string> { { "type", "changeHandled" }, { "id", ids[e.RowIndex] } });
                if(states.Where(x=>x == "0").Count() == 0)
                {
                    LoginForm.main.pbNewBookings.Visible = false;
                }
            }
        }
    }
}
