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
		public AllBooksPage()
		{
			InitializeComponent();
		}

        private void AllBooksPage_Load(object sender, EventArgs e)
        {
			updateBooksDgv("");

		}

		private async void updateBooksDgv(string search)
		{
			cdgvBooks.DataSource = null;
            cdgvBooks.Columns.Clear();
            List<Dictionary<string, string>> response = (List<Dictionary<string, string>>)await ApiComm.SendPost(new Dictionary<string, string> { { "type", "getBooks" }, { "search", search } });
            if (response.Count>0)
            {
                DataTable dt = new DataTable();
                DataColumn col;
                DataRow row;
                //make the dataset columns
                foreach (KeyValuePair<string, string> item in response[0])
                {
                    col = new DataColumn();
                    col.DataType = typeof(string);
                    col.ReadOnly = true;
                    col.ColumnName = item.Key;
                    col.Caption = item.Key;
                    dt.Columns.Add(col);
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
                        row[item.Key] = item.Value;
                    }
                    dt.Rows.Add(row);
                }
                
                cdgvBooks.DataSource = dt;
                cdgvBooks.Columns.Add(btns);
                cdgvBooks.Columns.Add(btncol);

                cdgvBooks.CellClick += cdgvBooks_CellClick;
                addBtnTextsManual();
            }
            
        }
        private void addBtnTextsManual()
        {
            foreach (DataGridViewRow row in cdgvBooks.Rows)
            {
                if ((string)row.Cells[3].Value == "borrowed")
                {
                    row.Cells[5].Value = "Visszavétel";
                }
                else
                {
					//row.Cells[5].Value = "Kiadás";
					// Nekem itt hibát dobott, úgyohgy kikommenteltem, hogy tudjam a többi részét csinálni. Error: System.ArgumentOutOfRangeException: 'Index was out of range. Must be non-negative and less than the size of the collection.
					//Parameter name: index'

				}
                

            }
        }
        private void cdgvBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == cdgvBooks.Columns["Részletesen"].Index)
            {
                //ide meghívní a jó részletes formot ha lesz !!!
            }
            else if(e.ColumnIndex == cdgvBooks.Columns["Műveletek"].Index)
            {
                if ((string)cdgvBooks.Rows[e.RowIndex].Cells[3].Value == "borrowed")
                {
                    LoginForm.main.OpenChildForm(new BookTakebackPage((string)cdgvBooks.Rows[e.RowIndex].Cells[0].Value));
                }
                else 
                {
                    LoginForm.main.OpenChildForm(new BookLendingPage((string)cdgvBooks.Rows[e.RowIndex].Cells[0].Value));
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
	}
}
