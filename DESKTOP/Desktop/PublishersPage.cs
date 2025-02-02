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
    public partial class PublishersPage : Form
    {
        List<string> ids = new List<string>();
        public PublishersPage()
        {
            InitializeComponent();
        }
        private async void updatePublishersCdgw(string search)
        {
            cdgvPublishers.DataSource = null;
            cdgvPublishers.Columns.Clear();
            ids.Clear();
            List<Dictionary<string, string>> response = (List<Dictionary<string, string>>)await ApiComm.SendPost(new Dictionary<string, string> { { "type", "getPublishers" }, { "search", search } });
            if (response.Count > 0)
            {
                DataTable dt = new DataTable();
                DataColumn col;
                DataRow row;
                //make the dataset columns
                foreach (KeyValuePair<string, string> item in response[0])
                {
                    if (item.Key != "publisher_id")
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


                //make rows
                for (int i = 0; i < response.Count(); i++)
                {
                    row = dt.NewRow();
                    foreach (KeyValuePair<string, string> item in response[i])
                    {
                        if (item.Key == "user_id")
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
                cdgvPublishers.DataSource = dt;
            }
        }
    }
}
