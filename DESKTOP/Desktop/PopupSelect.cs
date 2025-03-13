using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Services;
using System.Windows.Forms;

namespace Desktop
{
    public partial class PopupSelect : Form
    {
        private string searchMode, startMode, optionalId;
        public string res1, res2, res3, id;
        private bool canReserve, canBook;
        private List<string> ids = new List<string>();

        [Category("Border")]
        [Browsable(true)]
        public float BorderWidth { get; set; } = 1.0f;
        [Category("Border")]
        [Browsable(true)]
        public Color BorderColor { get; set; } = Color.Black;

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            using (Pen pen = new Pen(BorderColor, BorderWidth))
            {
                Rectangle borderRect = new Rectangle(
                    (int)(BorderWidth / 2),
                    (int)(BorderWidth / 2),
                    (int)(this.ClientSize.Width - BorderWidth),
                    (int)(this.ClientSize.Height - BorderWidth)
                );

                e.Graphics.DrawRectangle(pen, borderRect);
            }
        }

        public PopupSelect(string mode, string id)
        {
            startMode = mode;
            optionalId = id;
            switch (mode)
            {
                case "userTakeback":
                    searchMode = "getBorrowedBooks";
                    break;
                case "bookOrReserve":
                    searchMode = "getBookStates";
                    getUserStatus();
                    break;
                case "getAuthors":
                    searchMode = mode;
                    break;
                case "getCategories":
                    searchMode = mode;
                    break;
                case "deactivateBook":
                    searchMode = "getBooks";
                    break;
                case "getPublishers":
                    searchMode = mode;
                    break;
            }
            InitializeComponent();

            FormDragger.MakeDraggable(this);
            this.BorderColor = Color.FromArgb(10, 123, 106);
            this.BorderWidth = 2;
        }
        public PopupSelect(string mode)
        {
            startMode = mode;
            switch (mode)
            {
                case "getUsers":
                    searchMode = mode;
                    break;
                case "userBorrow":
                    searchMode = "getBooks";
                    break ;
                case "getPublishers":
                    searchMode= mode;
                    break ;
                case "getLangs":
                    searchMode= mode;
                    break ;
                case "getReservables":
                    searchMode = "getReservables";
                    break ;


            }
            InitializeComponent();

            FormDragger.MakeDraggable(this);
            //this.BorderColor = Color.FromArgb(10, 123, 106);
            //this.BorderWidth = 2;
        }
        

        private async void updateSelectDgv(string search)
        {
            cdgwSelect.DataSource = null;
            cdgwSelect.Columns.Clear();
            ids.Clear();
            List<Dictionary<string, string>> response;
            DataGridViewButtonColumn btns = new DataGridViewButtonColumn();
            if (searchMode == "getLangs")
            {
                response = (List<Dictionary<string, string>>)await ApiComm.SendPost(new Dictionary<string, string> { { "type", searchMode } });
            }
            else if (searchMode == "getAuthors" || searchMode == "getCategories")
            {
                response = (List<Dictionary<string, string>>)await ApiComm.SendPost(new Dictionary<string, string> { { "type", searchMode }, { "ISBN_id", "-1" }, { "inverse", "1" } });
            }
            else
            {
                response = (List<Dictionary<string, string>>)await ApiComm.SendPost(new Dictionary<string, string> { { "type", searchMode }, { "search", search } });
            }
            if (response.Count > 0)
            {
                DataTable dt = new DataTable();
                DataColumn col;
                DataRow row;
                //make the dataset columns
                if (startMode == "getLangs")
                {
                    ctbSearch.Visible = false;
                    cbtnSearch.Visible = false;
                }
                if (startMode != "userTakeback")
                {
                    foreach (KeyValuePair<string, string> item in response[0])
                    {
                        if (item.Key != "user_id" && item.Key != "book_id" && item.Key != "id" && item.Key != "ISBN_id" && item.Key != "publisher_id" && item.Key != "lang_id" && item.Key != "author_id" && item.Key != "genre_id" && item.Key != "available")
                        {
                            col = new DataColumn();
                            col.DataType = typeof(string);
                            if (startMode == "getLangs" || startMode == "getAuthors" || startMode == "getCategories")
                            {
                                col.ReadOnly = false;
                                col.ColumnName = item.Key;
                            }
                            else
                            {
                                col.ReadOnly = true;
                                col.ColumnName = item.Key;
                            }

                            col.Caption = item.Key;
                            dt.Columns.Add(col);
                        }

                    }
                    if (startMode == "getAuthors" || startMode == "getCategories")
                    {
                        ctbSearch.Visible = false;
                        cbtnSearch.Text = "Választás";
                        
                    }
                    else
                    {
                        //add button row for detailed page
                        btns.Name = "Választás";
                        btns.Text = "Választ";
                        btns.UseColumnTextForButtonValue = true;
                    }
                    
                }
                else
                {
                    ctbSearch.Visible = false;
                    cbtnSearch.Text = "Visszavétel";
                    //cbtnSearch.Visible = false;
                    col = new DataColumn();
                    col.DataType = typeof(string);
                    col.ReadOnly = true;
                    col.ColumnName = "ISBN";
                    col.Caption = "ISBN";
                    dt.Columns.Add(col);
                    col = new DataColumn();
                    col.DataType = typeof(string);
                    col.ReadOnly = true;
                    col.ColumnName = "title";
                    col.Caption = "title";
                    dt.Columns.Add(col); col = new DataColumn();
                    col.DataType = typeof(string);
                    col.ReadOnly = true;
                    col.ColumnName = "fizetendo";
                    col.Caption = "fizetendo";
                    dt.Columns.Add(col);
                    //add checkbox
                    DataGridViewCheckBoxColumn checkRow = new DataGridViewCheckBoxColumn();
                    checkRow.Name = "Választás";
                    cdgwSelect.Columns.Add(checkRow);
                }
                
                

                //search for only available books if we want books
                if (startMode == "userBorrow")
                {
                    response = response.Where(x => x["status"] == "available" && x["available"] == "1").ToList();
                }
                if (startMode == "bookOrReserve")
                {
                    if (!canBook && !canReserve)
                    {
						using (CustomMessageBoxForm msgBox = new CustomMessageBoxForm("Ez a felhasználó nem tud se foglalni sem előjegyezni, mert már a maximális van mind a kettőből",	"Figyelmeztetés", MessageBoxButtons.OK,	MessageBoxIcon.Warning))
						{
							msgBox.ShowDialog();
						}

						this.Close();

					}
					if (!canBook)
                    {
                        response = response.Where(x => x["state"] != "booking").ToList();
                    }if (!canReserve)
                    {
                        response = response.Where(x => x["state"] != "reservation").ToList();
                    }
                }
                if (startMode == "deactivateBook")
                {
                    response = response.Where(x => x["status"] != "booked" && x["available"] == "1" && x["ISBN"] == optionalId).ToList();
                }
                if ((startMode == "getAuthors" || startMode == "getCategories") && optionalId.Length>0)
                {
                    string key = startMode == "getAuthors" ? "author" : "genre";
                    response = response.Where(x => !optionalId.Split(';').Contains(x[key])).ToList();
                }
                if (startMode == "getReservables")
                {
                    response = response.Where(x => x["state"] == "reservation").ToList();
                }
                //make rows
                if (!((startMode == "getLangs" || startMode == "getAuthors" || startMode == "getCategories") && response.First().Values.ToList()[0] == ""))
                {
                    if (startMode == "getPublishers" && optionalId!= null)
                    {
                        row = dt.NewRow();
                        foreach (KeyValuePair<string, string> item in response.Where(x => x["name"] == optionalId).First())
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
                    else if (startMode == "getAuthors" || startMode == "getCategories")
                    {
                        foreach (string item in optionalId.Split(';'))
                        {
                            row = dt.NewRow();
                            row[startMode == "getAuthors" ? "author" : "genre"] = item;
                            dt.Rows.Add(row);
                            
                        }
                    }
                    for (int i = 0; i < response.Count(); i++)
                    {
                        row = dt.NewRow();
                        if (startMode != "userTakeback")
                        {
                            foreach (KeyValuePair<string, string> item in response[i])
                            {

                                if (item.Key == "user_id" || item.Key == "book_id" || item.Key == "id" || item.Key == "ISBN_id" || item.Key == "publisher_id" || item.Key == "lang_id" || item.Key == "author_id" || item.Key == "genre_id")
                                {
                                    ids.Add(item.Value);
                                }
                                else if (item.Key != "available")
                                {
                                    row[item.Key] = item.Value;
                                }
                            }
                        }
                        else
                        {
                            ids.Add(response[i]["book_id"]);
                            for (int j = 0; j < 3; j++)
                            {
                                row[dt.Columns[j].ColumnName] = response[i][dt.Columns[j].ColumnName];
                            }
                        }
                        if (!(startMode == "getPublishers" && optionalId != null && response[i]["name"] == optionalId))
                        {
                            dt.Rows.Add(row);

                        }

                            
                    }
                }

                //disable ordering
                foreach (DataGridViewColumn column in cdgwSelect.Columns)
                {
                    column.SortMode = DataGridViewColumnSortMode.NotSortable;
                }
                cdgwSelect.DataSource = dt;
                if (startMode != "userTakeback" && startMode != "getAuthors" && startMode != "getCategories")
                {
                    cdgwSelect.Columns.Add(btns);

                }
                else
                {
                    DataGridViewCheckBoxColumn checkRow = new DataGridViewCheckBoxColumn();
                    checkRow.Name = "Választás";
                    checkRow.FalseValue = false;
                    cdgwSelect.Columns.Add(checkRow);
                    foreach(var checkbox in cdgwSelect.Rows.Cast<DataGridViewRow>().Select(x => x.Cells["Választás"]))
                    {
                        checkbox.Value = false;
                    }
                    if (startMode == "getAuthors" || startMode == "getCategories")
                    {
                        for (int i = 0; i < optionalId.Split(';').Length; i++)
                        {
                            cdgwSelect.Rows[i].Cells["Választás"].Value = true;
                        }
                    }
                    
                }
                
            }
        }

        private void cdgwSelect_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            cdgwSelect.Rows[e.RowIndex].Cells[0].ReadOnly = false;
        }

        private void cdgwSelect_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != cdgwSelect.ColumnCount-1 && cdgwSelect.AllowUserToAddRows)
            {
                if (cdgwSelect.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() != "")
                {
                    cdgwSelect.Rows[e.RowIndex].Cells[e.ColumnIndex].ReadOnly = true;
                }
                else
                {
                    cdgwSelect.Rows[e.RowIndex].Cells[e.ColumnIndex].ReadOnly = false;
                }
            }
            
        }

        private void PopupSelect_Load(object sender, EventArgs e)
        {
            if (startMode == "userTakeback")
            {
                updateSelectDgv(optionalId);
            }
            else
            {
                updateSelectDgv("");
            }
            if (startMode == "getLangs" || startMode == "getAuthors" || startMode == "getCategories" || startMode == "getPublishers")
            {
                cdgwSelect.AllowUserToAddRows = true;
                cdgwSelect.UserAddedRow += cdgwSelect_UserAddedRow;
            }
            ctbSearch.KeyPress += ctbSearch_KeyPress;
            cdgwSelect.CellClick += cdgwSelect_CellClick;
        }

        private void cdgwSelect_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            if (startMode == "getAuthors" || startMode == "getCategories")
            {
                e.Row.Cells["Választás"].Value = false;
            }
           
        }

        private void cbtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void cbtnSearch_Click(object sender, EventArgs e)
        {
            if (startMode != "userTakeback" && startMode != "getAuthors" && startMode != "getCategories")
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
            else
            {
                if (startMode == "userTakeback")
                {
                    CustomMessageBoxForm pop = new CustomMessageBoxForm($"Fizetendő: {cdgwSelect.Rows.Cast<DataGridViewRow>().Where(x => (bool)x.Cells["Választás"].Value).Sum(x => int.Parse((string)x.Cells["fizetendo"].Value))} Ft a késedelmekből", "Biztosan vissza szeretné venni ezeket a könyveket?", MessageBoxButtons.YesNo);
                    if (pop.ShowDialog() == DialogResult.Yes)
                    {
                        foreach (DataGridViewRow row in cdgwSelect.Rows.Cast<DataGridViewRow>().Where(x => (bool)x.Cells["Választás"].Value))
                        {
                            var output = (List<Dictionary<string, string>>)await ApiComm.SendPost(new Dictionary<string, string> { { "type", "returnBook" }, { "user_id", optionalId }, { "bookID", ids[row.Index] }, { "empl_id", LoginForm.employee } });
                        }
                        LoginForm.main.CheckForBookings(true);
                    }
                }
                else
                {
                    res1 = String.Join(";",cdgwSelect.Rows.Cast<DataGridViewRow>().Where(x => (bool)x.Cells["Választás"].Value).Select(x => x.Cells[startMode=="getAuthors"?"author":"genre"].Value).ToArray());
                    //id = ids[e.RowIndex];
                    this.DialogResult = DialogResult.OK;
                }
                
                
                this.Close();
            }
            
        }

        private void ctbSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (startMode != "userTakeback")
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
            
        }
        private async void cdgwSelect_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (startMode != "userTakeback" && startMode != "getAuthors" && startMode != "getCategories")
            {
                if (e.ColumnIndex == cdgwSelect.Columns["Választás"].Index && e.RowIndex != -1)
                {
                    if (startMode == "bookOrReserve")
                    {
                        MessageBox.Show("Biztosan végre szeretné hajtani a műveletet");//yesNo vagy OK
                        List<Dictionary<string, string>> resp = (List<Dictionary<string, string>>)await ApiComm.SendPost(new Dictionary<string, string> { { "type", "addReservationOrBooking" }, { "ISBN", ids[e.RowIndex] }, { "userid", optionalId } });
                        if (resp.First()["status"] != (string)cdgwSelect.Rows[e.RowIndex].Cells[2].Value)
                        {
                            using (CustomMessageBoxForm msgBox = new CustomMessageBoxForm("Közben megváltozott a foglalás.", "Figyelmeztetés", true)) //a true miatt lesz gomb nelkuli.
                            {
                                msgBox.ShowDialog();
                            }

                        }
                        this.Close();
                    }
                    else if (startMode == "getLangs")
                    {
                        if (cdgwSelect.Rows[e.RowIndex].Cells[0].Value.GetType() != typeof(System.DBNull))
                        {
                            res1 = (string)cdgwSelect.Rows[e.RowIndex].Cells[0].Value;
                            //id = ids[e.RowIndex];
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }

                    }
                    else if (startMode == "deactivateBook")
                    {
                        await ApiComm.SendPost(new Dictionary<string, string> { { "type", "deactivateBook" }, { "book_id", ids[e.RowIndex] } });
                        cdgwSelect.Rows.RemoveAt(e.RowIndex);
                        ids.RemoveAt(e.RowIndex);
                    }
                    else if (startMode == "getPublishers")
                    {
                        if (cdgwSelect.Rows[e.RowIndex].Cells[0].Value.GetType() != typeof(System.DBNull) && cdgwSelect.Rows[e.RowIndex].Cells[1].Value.GetType() != typeof(System.DBNull) && cdgwSelect.Rows[e.RowIndex].Cells[2].Value.GetType() != typeof(System.DBNull) && cdgwSelect.Rows[e.RowIndex].Cells[3].Value.GetType() != typeof(System.DBNull))
                        {
                            res1 = (string)cdgwSelect.Rows[e.RowIndex].Cells[0].Value;
                            res2 = (string)cdgwSelect.Rows[e.RowIndex].Cells[1].Value;
                            res3 = (string)cdgwSelect.Rows[e.RowIndex].Cells[2].Value;
                            if (ids.Count <= e.RowIndex)
                            {
                                List<Dictionary<string, string>> data = (List<Dictionary<string, string>>)await ApiComm.SendPost(new Dictionary<string, string> { { "type", "addPublisher" }, { "name", cdgwSelect.Rows[e.RowIndex].Cells[0].Value.ToString() }, { "phone", cdgwSelect.Rows[e.RowIndex].Cells[1].Value.ToString() }, { "email", cdgwSelect.Rows[e.RowIndex].Cells[2].Value.ToString() }, { "webpage", cdgwSelect.Rows[e.RowIndex].Cells[3].Value.ToString() } });
                                if (data.First()["state"] == "fail")
                                {
                                    //MessageBox.Show("Ezzel a névvel már létezik kiadó");
                                    using (CustomMessageBoxForm msgBox = new CustomMessageBoxForm("Ezzel a névvel már létezik kiadó", "Figyelmeztetés", true)) //a true miatt lesz gomb nelkuli.
                                    {
                                        msgBox.ShowDialog();
                                    }

                                }
                                else
                                {
                                    this.DialogResult = DialogResult.OK;
                                    this.Close();
                                }
                            }



                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            //MessageBox.Show("Ha újat szertne hozzáadni kérem az összes adatot adja meg");
                            using (CustomMessageBoxForm msgBox = new CustomMessageBoxForm("Ha újat szertne hozzáadni kérem az összes adatot adja meg.", "Figyelmeztetés", true))
                            {
                                msgBox.ShowDialog();
                            }
                        }

                    }
                    else if (startMode != "userTakeback")
                    {
                        res1 = (string)cdgwSelect.Rows[e.RowIndex].Cells[0].Value;
                        res2 = (string)cdgwSelect.Rows[e.RowIndex].Cells[1].Value;
                        res3 = (string)cdgwSelect.Rows[e.RowIndex].Cells[2].Value;
                        id = ids[e.RowIndex];

                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
            }
            
        }
        private async void getUserStatus()
        {
            List<Dictionary<string, string>> resp = (List<Dictionary<string, string>>)await ApiComm.SendPost(new Dictionary<string, string> { { "type", "checkPermissions" }, { "id", optionalId } });
            canReserve = bool.Parse(resp.First()["reservation"]);
            canBook = bool.Parse(resp.First()["booking"]);
        }
    }
    }
