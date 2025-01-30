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
    public partial class PopupSelect : Form
    {
        private string searchMode;
        public string res1, res2, res3, id;
        private List<string> ids = new List<string>();
        public PopupSelect(string mode)
        {
            searchMode = mode;
            InitializeComponent();
        }

        private async void updateSelectDgv(string search)
        {
            cdgwSelect.DataSource = null;
            cdgwSelect.Columns.Clear();
            ids.Clear();
            List<Dictionary<string, string>> response = (List<Dictionary<string, string>>)await ApiComm.SendPost(new Dictionary<string, string> { { "type", searchMode }, { "search", search } });
            if (response.Count > 0)
            {
                DataTable dt = new DataTable();
                DataColumn col;
                DataRow row;
                //make the dataset columns
                foreach (KeyValuePair<string, string> item in response[0])
                {
                    if (item.Key != "user_id" && item.Key != "book_id")
                    {
                        col = new DataColumn();
                        col.DataType = typeof(string);
                        col.ReadOnly = true;
                        col.ColumnName = item.Key;
                        col.Caption = item.Key;
                        dt.Columns.Add(col);
                    }
                    
                }
                //add button row for detailed page
                DataGridViewButtonColumn btns = new DataGridViewButtonColumn();
                btns.Name = "Választás";
                btns.Text = "Választ";
                btns.UseColumnTextForButtonValue = true;

                //search for only available books if we want books
                if (searchMode == "getBooks")
                {
                    response = response.Where(x => x["status"] == "available").ToList();
                }
                //make rows
                for (int i = 0; i < response.Count(); i++)
                {
                    row = dt.NewRow();
                    foreach (KeyValuePair<string, string> item in response[i])
                    {
                        if (item.Key == "user_id" || item.Key == "book_id")
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

                cdgwSelect.DataSource = dt;
                cdgwSelect.Columns.Add(btns);
            }
        }

        private void PopupSelect_Load(object sender, EventArgs e)
        {
            updateSelectDgv("");
            ctbSearch.KeyPress += ctbSearch_KeyPress;
            cdgwSelect.CellClick += cdgwSelect_CellClick;
        }

        private void cbtnSearch_Click(object sender, EventArgs e)
        {
            if (ctbSearch.Texts != ctbSearch.PlaceholderText)
            {
                updateSelectDgv(ctbSearch.Texts);
            }
            else
            {
                updateSelectDgv("");
            }
        }

        private void ctbSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (ctbSearch.Texts != ctbSearch.PlaceholderText)
            {
                updateSelectDgv(ctbSearch.Texts);
            }
            else
            {
                updateSelectDgv("");
            }
        }
        private void cdgwSelect_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == cdgwSelect.Columns["Választás"].Index)
            {
                res1 = (string)cdgwSelect.Rows[e.RowIndex].Cells[0].Value;
                res2 = (string)cdgwSelect.Rows[e.RowIndex].Cells[1].Value;
                res3 = (string)cdgwSelect.Rows[e.RowIndex].Cells[2].Value;
                id = ids[e.RowIndex];
                
                this.DialogResult =  DialogResult.OK;
                this.Close();

            }
        }
    }
    }
