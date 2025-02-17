using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop
{
	public partial class AllBooksPage : Form
	{
        private List<string> ids = new List<string>();  
		public AllBooksPage()
		{
			InitializeComponent();
		}

        private void AllBooksPage_Load(object sender, EventArgs e)
        {
            ctbSearch.KeyPress += ctbSearch_KeyPress;
            cdgvBooks.CellClick += cdgvBooks_CellClick;
           
        }


		private async void updateBooksDgv(string search)
		{
			cdgvBooks.DataSource = null;
            cdgvBooks.Columns.Clear();
            ids.Clear();
            List<Dictionary<string, string>> response = (List<Dictionary<string, string>>)await ApiComm.SendPost(new Dictionary<string, string> { { "type", "getBooks" }, { "search", search } });
            if (response.Count>0)
            {
                DataTable dt = new DataTable();
                DataColumn col;
                DataRow row;
                //make the dataset columns
                foreach (KeyValuePair<string, string> item in response[0])
                {
                    if (item.Key != "book_id" && item.Key != "available")
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
                btns.Name = "Részletesen";
                btns.Text = "Részletes";
                btns.UseColumnTextForButtonValue = true;
                //add button column for booking/available/borrowed
                DataGridViewButtonColumn btncol = new DataGridViewButtonColumn();
                btncol.Name = "Műveletek";
                


                //make rows
                for (int i = 0; i < response.Count(); i++)
                {
                    row = dt.NewRow();
                    foreach (KeyValuePair<string, string> item in response[i])
                    {
                        if (item.Key == "book_id")
                        {
                            ids.Add(item.Value);
                        }
                        else if(item.Key != "available")
                        {
                            row[item.Key] = item.Value;
                        }
                        
                    }
                    dt.Rows.Add(row);
                }
                
                cdgvBooks.DataSource = dt;
                cdgvBooks.Columns.Add(btns);
                cdgvBooks.Columns.Add(btncol);


                //disable sorting just so it works
                foreach (DataGridViewColumn column in cdgvBooks.Columns)
                {
                    column.SortMode = DataGridViewColumnSortMode.NotSortable;
                }
                addBtnTextsManual();
            }
            
        }
        private void addBtnTextsManual()
        {
            foreach (DataGridViewRow row in cdgvBooks.Rows)
            {
                if ((string)row.Cells[2].Value == "borrowed")
                {
                    row.Cells[4].Value = "Visszavétel";
                }
                else
                {
					row.Cells[4].Value = "Kiadás";

				}
                

            }
        }
        private void cdgvBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == cdgvBooks.Columns["Részletesen"].Index)
            {
                LoginForm.main.OpenChildForm(new BookDetailedPage((string)cdgvBooks.Rows[e.RowIndex].Cells["isbn"].Value));
            }
            else if(e.ColumnIndex == cdgvBooks.Columns["Műveletek"].Index)
            {
                if ((string)cdgvBooks.Rows[e.RowIndex].Cells[2].Value == "borrowed")
                {
                    LoginForm.main.OpenChildForm(new BookTakebackPage(ids[e.RowIndex]));
                }
                else if((string)cdgvBooks.Rows[e.RowIndex].Cells[2].Value == "booked")
                {
                    LoginForm.main.OpenChildForm(new BookLendingPage(ids[e.RowIndex], "booking"));
                }
                else
                {
                    LoginForm.main.OpenChildForm(new BookLendingPage(ids[e.RowIndex], "book_id"));
                }

            }
        }

		private void btnSearch_Click(object sender, EventArgs e)
		{
			if (ctbSearch.Texts != ctbSearch.PlaceholderText)
			{
				updateBooksDgv(ctbSearch.Texts);
			}
			else
			{
				updateBooksDgv("");
			}
		}

		private void ctbSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            if(ctbSearch.Texts != ctbSearch.PlaceholderText)
            {
                updateBooksDgv(ctbSearch.Texts);
            }
            else
            {
                updateBooksDgv("");
            }
        }

        private void AllBooksPage_VisibleChanged(object sender, EventArgs e)
        {
            if(this.Visible == true)
            {
                if (ctbSearch.Texts != ctbSearch.PlaceholderText)
                {
                    updateBooksDgv(ctbSearch.Texts);
                }
                else
                {
                    updateBooksDgv("");
                }
            }
        }
    }
}
