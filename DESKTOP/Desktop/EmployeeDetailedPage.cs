using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop
{
    public partial class EmployeeDetailedPage : Form
    {
        private bool admin = false;
        private string mode = "employees";
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
                            //MessageBox.Show("Sikeresen megváltoztatta a jelszavát");
							using (CustomMessageBoxForm msgBox = new CustomMessageBoxForm("Sikeresen megváltoztatta a jelszavát.", "Figyelmeztetés", MessageBoxButtons.OK))
							{
								msgBox.ShowDialog();
							}
							ctbNewPass.Texts = "";
                            ctbNewPassAgain.Texts = "";
                            ctbOldPass.Texts = "";
                        }
                        else
                        {
                            //MessageBox.Show("Hibás a régi jelszó");
							using (CustomMessageBoxForm msgBox = new CustomMessageBoxForm("Hibás a régi jelszó.", "Figyelmeztetés", MessageBoxButtons.OK))
							{
								msgBox.ShowDialog();
							}
						}
                    }
                    else
                    {
                        //MessageBox.Show("A régi jelszó megegyezik az új jelszóval");
						using (CustomMessageBoxForm msgBox = new CustomMessageBoxForm("A régi jelszó megegyezik az új jelszóval.", "Figyelmeztetés", MessageBoxButtons.OK))
						{
							msgBox.ShowDialog();
						}
					}
                }
                else
                {
                    //MessageBox.Show("Az új jelszó nem egyezik meg a két mezőben");
					using (CustomMessageBoxForm msgBox = new CustomMessageBoxForm("Az új jelszó nem egyezik meg a két mezőben.", "Figyelmeztetés", MessageBoxButtons.OK))
					{
						msgBox.ShowDialog();
					}
				}
            }
            else
            {
                //MessageBox.Show("Az összes mezőt töltse ki");
				using (CustomMessageBoxForm msgBox = new CustomMessageBoxForm("Az összes mezőt töltse ki.", "Figyelmeztetés", MessageBoxButtons.OK))
				{
					msgBox.ShowDialog();
				}
			}
        }
        private async void UpdateEmployeesCdgw()
        {
            cdgvEmployees.Columns.Clear();
            ids.Clear();
            cdgvEmployees.DataSource = null;
            List<Dictionary<string, string>> response;
            if (mode == "employees")
            {
                response = (List<Dictionary<string, string>>)await ApiComm.SendPost(new Dictionary<string, string> { { "type", "getEmployees" } });
            }
            else
            {
                response = (List<Dictionary<string, string>>)await ApiComm.SendPost(new Dictionary<string, string> { { "type", "getSystemSettings" } });
            }
            
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
                        if (mode == "employees")
                        {
                            col.DataType = typeof(string);
                            col.ReadOnly = true;
                        }
                        else
                        {
                            col.DataType = typeof(int);
                        }
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
                if (mode == "employees")
                {
                    //add button row for detailed page
                    DataGridViewButtonColumn btns = new DataGridViewButtonColumn();
                    btns.Name = "Műveletek";
                    btns.Text = "Deaktivál";
                    btns.UseColumnTextForButtonValue = true;
                    cdgvEmployees.Columns.Add(btns);
                }

                   


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
            if (mode == "employees")
            {
                if (e.ColumnIndex == cdgvEmployees.Columns["Műveletek"].Index)
                {
                    if (ids[e.RowIndex] != LoginForm.employee)
                    {
						using (CustomMessageBoxForm msgBox = new CustomMessageBoxForm("Biztosan véglegesen deaktiválni szeretné ezt az alkalmazottat?", "Alkalmazott deaktiválása", MessageBoxButtons.YesNo))
						{
							DialogResult res = msgBox.ShowDialog();

							if (res == DialogResult.Yes)
							{
								await ApiComm.SendPost(new Dictionary<string, string> { { "type", "deactivateEmpl" }, { "empl_id", ids[e.RowIndex] } });
								UpdateEmployeesCdgw();

							}
						}
					}
                    else
                    {
                        //MessageBox.Show("Az admin felhasználót nem lehet törölni");
						using (CustomMessageBoxForm msgBox = new CustomMessageBoxForm("Az admin felhasználót nem lehet törölni.", "Bejelentkezés hiba", MessageBoxButtons.OK, MessageBoxIcon.Error))
						{
							msgBox.ShowDialog();
						}
					}
                }
            }
            
        }

        private async void cbtnDeleteEmpl_Click(object sender, EventArgs e)
        {
            if (admin)
            {
                AddEmployee add = new AddEmployee();
                add.ShowDialog();
                UpdateEmployeesCdgw();
            }
            else
            {
                using (CustomMessageBoxForm msgBox = new CustomMessageBoxForm("Biztosan véglegesen deaktiválni szeretné ezt az alkalmazottat?", "Alkalmazott deaktiválása", MessageBoxButtons.YesNo))
				{
					DialogResult res = msgBox.ShowDialog();

					if (res == DialogResult.Yes)
					{
						await ApiComm.SendPost(new Dictionary<string, string> { { "type", "deactivateEmpl" }, { "empl_id", LoginForm.employee } });
						LoginForm.main.Close();

					}
				}
			}
            
        }

        private void cbtnEmployees_Click(object sender, EventArgs e)
        {
            SaveChanges();
            cbtnEmployees.Enabled = false;
            cbtnSysSetting.Enabled = true;
            mode = "employees";
            UpdateEmployeesCdgw();
            lblCdgwTitle.Text = "Aktív alkalmazottak";
        }

        private void cbtnSysSetting_Click(object sender, EventArgs e)
        {
            cbtnEmployees.Enabled = true;
            cbtnSysSetting.Enabled = false;
            mode = "system_settings";
            UpdateEmployeesCdgw();
            lblCdgwTitle.Text = "Rendszer beállítások";
        }

        private void EmployeeDetailedPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (mode == "system_settings")
            {
                SaveChanges();
            }
            
        }
        private async void SaveChanges()
        {
            if (checkChanges())
            {
                Dictionary<string, string> data = new Dictionary<string, string>();
                data["type"] = "updateSystemSettings";
                for (int i = 0; i < cdgvEmployees.Rows[0].Cells.Count; i++)
                {
                    data[cdgvEmployees.Columns[i].Name] = cdgvEmployees.Rows[0].Cells[cdgvEmployees.Columns[i].Name].Value.ToString();
                }
                await ApiComm.SendPost(data);
                data.Remove("type");
                LoginForm.main.system_settings = new Dictionary<string, string>(data);
            }
        }

        private bool checkChanges() { 
            bool res = false;
            foreach(var pair in LoginForm.main.system_settings)
            {
                if (cdgvEmployees.Rows[0].Cells[pair.Key].ToString() != pair.Value)
                {
                    res = true;
                }
            }
            return res;
        }
    }
}
