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
    public partial class EmployeeDetailedPage : Form
    {
        private bool admin = false;
        private List<string> ids = new List<string>();
        public EmployeeDetailedPage()
        {
            InitializeComponent();
        }

        private void cbtnLogout_Click(object sender, EventArgs e)
        {
            LoginForm.main.Close();
        }

        private async void cbtnChangePass_Click(object sender, EventArgs e)
        {
            if (ctbNewPass.Texts!="" && ctbNewPassAgain.Texts!="" && ctbOldPass.Texts!="")
            {
                if (ctbNewPass.Texts == ctbNewPassAgain.Texts)
                {
                    if (ctbNewPass.Texts != ctbOldPass.Texts)
                    {
                        List<Dictionary<string, string>> resp = (List<Dictionary<string, string>>)await ApiComm.SendPost(new Dictionary<string, string> { { "type", "changeEmplPass" }, {"empl_id", LoginForm.employee },{ "oldPass", ctbOldPass.Texts }, { "newPass", ctbNewPass.Texts } });
                        if (resp.First()["result"] == "siker")
                        {
                            MessageBox.Show("Sikeresen megváltoztatta a jelszavát");
                            ctbNewPass.Texts = "";
                            ctbNewPassAgain.Texts = "";
                            ctbOldPass.Texts = "";
                        }
                        else
                        {
                            MessageBox.Show("Hibás a régi jelszó");
                        }
                    }
                    else
                    {
                        MessageBox.Show("A régi jelszó megegyezik az új jelszóval");
                    }
                }
                else
                {
                    MessageBox.Show("Az új jelszó nem egyezik meg a két mezőben");
                }
            }
            else
            {
                MessageBox.Show("Az összes mezőt töltse ki");
            }
        }
        private async void UpdateEmployeesCdgw()
        {
            cdgvEmployees.Columns.Clear();
            ids.Clear();
            cdgvEmployees.DataSource = null;
            List<Dictionary<string, string>> response = (List<Dictionary<string, string>>)await ApiComm.SendPost(new Dictionary<string, string> { { "type", "getEmployees" } });
            if (response.Count > 0)
            {
                DataTable dt = new DataTable();
                DataColumn col;
                DataRow row;
                //make the dataset columns
                foreach (KeyValuePair<string, string> item in response[0])
                {
                    if (item.Key != "empl_id")
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
                btns.Name = "Műveletek";
                btns.Text = "Deaktivál";
                btns.UseColumnTextForButtonValue = true;



                //make rows
                for (int i = 0; i < response.Count(); i++)
                {
                    row = dt.NewRow();
                    foreach (KeyValuePair<string, string> item in response[i])
                    {
                        if (item.Key == "empl_id")
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

                cdgvEmployees.DataSource = dt;
                cdgvEmployees.Columns.Add(btns);


                //disable sorting just so it works
                foreach (DataGridViewColumn column in cdgvEmployees.Columns)
                {
                    column.SortMode = DataGridViewColumnSortMode.NotSortable;
                }
            }
        }

        private async void EmployeeDetailedPage_Load(object sender, EventArgs e)
        {
            List<Dictionary<string, string>> resp = (List<Dictionary<string, string>>)await ApiComm.SendPost(new Dictionary<string, string> { {"type", "getEmployee" }, {"empl_id", LoginForm.employee } });
            lbName.Text = resp.First()["empl_name"];
            lbUname.Text = resp.First()["empl_uname"];
            if (resp.First()["admin"] == "1")
            {
                cbtnDeleteEmpl.Text = "Alkalmazott hozzáadása";
                admin = true;
                pEmpolyees.Visible = true;
                cdgvEmployees.CellClick += cdgvEmployees_CellClick;
                UpdateEmployeesCdgw();
            }
        }

        private async void cdgvEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == cdgvEmployees.Columns["Műveletek"].Index)
            {
                if (ids[e.RowIndex] != LoginForm.employee)
                {
                    if (MessageBox.Show("Biztosan véglegesen deaktiválni szeretné ezt az alkalmazottat?", "Alkalmazott deaktiválása", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        await ApiComm.SendPost(new Dictionary<string, string> { { "type", "deactivateEmpl" }, { "empl_id", ids[e.RowIndex] } });
                        UpdateEmployeesCdgw();
                    }
                }
                else
                {
                    MessageBox.Show("Az admin felhasználót nem lehet törölni");
                }
            }
        }

        private async void cbtnDeleteEmpl_Click(object sender, EventArgs e)
        {
            if (admin)
            {
                AddEmployee add = new AddEmployee();
                add.ShowDialog();
            }
            else
            {
                if (MessageBox.Show("Biztosan véglegesen deaktiválni szeretné ezt az alkalmazottat?", "Alkalmazott deaktiválása", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    await ApiComm.SendPost(new Dictionary<string, string> { { "type", "deactivateEmpl" }, { "empl_id", LoginForm.employee } });
                    LoginForm.main.Close();
                }
            }
            
        }
    }
}
