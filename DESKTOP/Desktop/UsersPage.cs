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
    public partial class UsersPage : Form
    {
        public UsersPage()
        {
            InitializeComponent();
        }

        private void customDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tableLayoutPanel_Users_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UsersPage_Load(object sender, EventArgs e)
        {
            updateUsersDgw("");
            //ctbSearch.KeyPress += ctbSearch_KeyPress;
        }
        private async void updateUsersDgw(string search)
        {
            cdgwUsers.DataSource = null;
            cdgwUsers.Columns.Clear();
            List<Dictionary<string, string>> response = (List<Dictionary<string, string>>)await ApiComm.SendPost(new Dictionary<string, string> { { "type", "getUsers" }, { "search", search } });
            if (response.Count >0)
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
                cdgwUsers.DataSource = dt;
                cdgwUsers.Columns.Add(btns);
                cdgwUsers.CellClick += cdgwUsers_CellClick;
            }
            
            
        }

        private void cdgwUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == cdgwUsers.Columns["Részletesen"].Index)
            {
                //ide meghívní a jó részletes formot ha lesz !!!
            }
        }

        private void ctbSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (e.KeyChar == (char)Keys.Enter)
            {
                Console.WriteLine("nig");
            }
        }

        private void btnKeres_Click(object sender, EventArgs e)
        {
            if (ctbSearch.Texts != ctbSearch.PlaceholderText)
            {
                updateUsersDgw(ctbSearch.Texts);
            }
            else
            {
                updateUsersDgw("");
            }
        }
    }
}
