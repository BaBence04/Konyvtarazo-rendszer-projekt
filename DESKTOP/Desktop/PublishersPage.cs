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
                        //col.ReadOnly = true;
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
                        if (item.Key == "publisher_id")
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
                //disable sorting just so it works
                foreach (DataGridViewColumn column in cdgvPublishers.Columns)
                {
                    column.SortMode = DataGridViewColumnSortMode.NotSortable;
                }
                cdgvPublishers.MultiSelect = false;
            }
        }

        private void PublishersPage_Load(object sender, EventArgs e)
        {
            updatePublishersCdgw("");
            ctbSearch.KeyPress += ctbSearch_KeyPress;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (ctbSearch.Texts != ctbSearch.PlaceholderText)
            {
                updatePublishersCdgw(ctbSearch.Texts);
            }
            else
            {
                updatePublishersCdgw("");
            }
        }
        private void ctbSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (ctbSearch.Texts != ctbSearch.PlaceholderText)
            {
                updatePublishersCdgw(ctbSearch.Texts);
            }
            else
            {
                updatePublishersCdgw("");
            }
        }

        private async void cdgvPublishers_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            Dictionary<string,string> update  = new Dictionary<string,string>();
            update["type"] = "updatePublishers";
            update["id"] = ids[e.RowIndex];
            for (int i = 0;i<cdgvPublishers.Columns.Count;i++)
            {
                update[cdgvPublishers.Columns[i].Name] = (string)cdgvPublishers.Rows[e.RowIndex].Cells[i].Value;
            }
            await ApiComm.SendPost(update);
        }



        private async void cdgvPublishers_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            List<Dictionary<string, string>> result = (List<Dictionary<string, string>>)await ApiComm.SendPost(new Dictionary<string, string>() { { "type", "deletePublisher" }, { "id", ids[e.Row.Index] } });
            if (result.First()["state"] == "fail")
            {
                e.Cancel = true;
                MessageBox.Show("A kiadóhoz hozzá van rendelve legalább 1 könyv nem lehet törölni");
            }
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            AddPublisher add = new AddPublisher();
            if (add.ShowDialog() == DialogResult.OK)
            {
                if (ctbSearch.Texts != ctbSearch.PlaceholderText)
                {
                    updatePublishersCdgw(ctbSearch.Texts);
                }
                else
                {
                    updatePublishersCdgw("");
                }
            }
            
        }
       
    }
}
