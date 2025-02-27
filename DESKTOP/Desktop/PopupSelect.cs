using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            }
            InitializeComponent();
            
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
        }
        

        private async void updateSelectDgv(string search)
        {
            cdgwSelect.DataSource = null;
            cdgwSelect.Columns.Clear();
            ids.Clear();
            List<Dictionary<string, string>> response;
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
                            }
                            else
                            {
                                col.ReadOnly = true;
                            }
                            col.ColumnName = item.Key;
                            col.Caption = item.Key;
                            dt.Columns.Add(col);
                        }

                    }
                }
                else
                {
                    ctbSearch.Visible = false;
                    cbtnSearch.Visible = false;
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
                }
                
                //add button row for detailed page
                DataGridViewButtonColumn btns = new DataGridViewButtonColumn();
                btns.Name = "Választás";
                btns.Text = "Választ";
                btns.UseColumnTextForButtonValue = true;

                //search for only available books if we want books
                if (startMode == "userBorrow")
                {
                    response = response.Where(x => x["status"] == "available" && x["available"] == "1").ToList();
                }
                if (startMode == "bookOrReserve")
                {
                    if (!canBook && !canReserve)
                    {
                        MessageBox.Show("Ez a felhasználó nem tud se foglalni sem előjegyezni, mert már a maximális van mind a kettőből");
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
                if (startMode == "getAuthors" || startMode == "getCategories")
                {
                    string key = startMode == "getAuthors" ? "author" : "genre";
                    response = response.Where(x => !optionalId.Split(';').Contains(x[key])).ToList();
                }
                if (startMode == "getReservables")
                {
                    response = response.Where(x => x["state"] == "reservation").ToList();
                }
                //make rows
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
                            else if(item.Key != "available")
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
                    
                    dt.Rows.Add(row);
                }
                //disable ordering
                foreach (DataGridViewColumn column in cdgwSelect.Columns)
                {
                    column.SortMode = DataGridViewColumnSortMode.NotSortable;
                }
                cdgwSelect.DataSource = dt;
                cdgwSelect.Columns.Add(btns);
            }
        }

        private void cdgwSelect_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            cdgwSelect.Rows[e.RowIndex].Cells[0].ReadOnly = false;
        }

        private void cdgwSelect_CellEnter(object sender, DataGridViewCellEventArgs e)
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
            if (startMode == "getLangs" || startMode == "getAuthors" || startMode == "getCategories")
            {
                cdgwSelect.AllowUserToAddRows = true;
                
            }
            ctbSearch.KeyPress += ctbSearch_KeyPress;
            cdgwSelect.CellClick += cdgwSelect_CellClick;
        }

        private void cbtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
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
            if (e.ColumnIndex == cdgwSelect.Columns["Választás"].Index && e.RowIndex != -1)
            {
                if (startMode == "bookOrReserve")
                {
                    MessageBox.Show("Biztosan végre szeretné hajtani a műveletet");
                    List<Dictionary<string, string>> resp = (List<Dictionary<string, string>>)await ApiComm.SendPost(new Dictionary<string, string> { { "type", "addReservationOrBooking" }, { "ISBN", ids[e.RowIndex] }, { "userid", optionalId } });
                    if (resp.First()["status"] != (string)cdgwSelect.Rows[e.RowIndex].Cells[2].Value)
                    {
                        MessageBox.Show("Közben megváltozott a foglalás");
                    }
                    this.Close();
                }
                else if (startMode == "getLangs" || startMode == "getAuthors" || startMode == "getCategories")
                {
                    res1 = (string)cdgwSelect.Rows[e.RowIndex].Cells[0].Value;
                    //id = ids[e.RowIndex];
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }else if (startMode == "deactivateBook")
                {
                    await ApiComm.SendPost(new Dictionary<string, string> { { "type", "deactivateBook" }, { "book_id", ids[e.RowIndex] } });
                    cdgwSelect.Rows.RemoveAt(e.RowIndex);
                    ids.RemoveAt(e.RowIndex);
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
                else
                {
                    LoginForm.main.OpenChildForm(new BookTakebackPage(ids[e.RowIndex]));
                    this.Close();
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
