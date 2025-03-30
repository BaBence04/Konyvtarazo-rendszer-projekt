using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace Desktop
{
    public partial class BookDetailedPage : Form
    {
        private string isbn, picBase64;
        private bool addMode = false;
        private Dictionary<string, string> original;
        private int distBtwCardsX = 1, distBtwCardsY = 1, authorNextLocationX, authorNextLocationY, categoryNextLocationX, categoryNextLocationY;
        private List<Label> authors = new List<Label>();


        private void cbtnAddAuthor_Click(object sender, EventArgs e)
        {
            PopupSelect pop = new PopupSelect("getAuthors", String.Join(";", authors.Select(x => x.Text).ToArray()));
            if (pop.ShowDialog() == DialogResult.OK)
            {
                pAuthors.Controls.Clear();
                authors.Clear();
                authorNextLocationX = 0;
                authorNextLocationY = 0;
                string[] author = pop.res1.Split(';');
                for (int i = 0; i < author.Length; i++)
                {
                    Label lbl = new Label();
                    int num;
                    if (authors.Count == 0)
                    {
                        num = 0;
                    }
                    else
                    {
                        num = int.Parse(authors.OrderBy(x => x.Name).Last().Name.Replace("lblAuthor", "")) + 1;
                    }
                    lbl.Name = "lblAuthor" + num;

                    lbl.AutoSize = true;
                    lbl.Text = author[i];
                    if (authorNextLocationX + lbl.Size.Width + distBtwCardsX > pAuthors.Size.Width)
                    {
                        authorNextLocationX = 0;
                        authorNextLocationY += lbl.Size.Height + distBtwCardsY;
                    }
                    lbl.Location = new Point(authorNextLocationX, authorNextLocationY);
                    authorNextLocationX += lbl.Size.Width + distBtwCardsX;
                    pAuthors.Controls.Add(lbl);
                    authors.Add(lbl);
                }


            }
        }
        private void cbtnAddCategory_Click(object sender, EventArgs e)
        {
            PopupSelect pop = new PopupSelect("getCategories", String.Join(";", categories.Select(x => x.Text).ToArray()));
            if (pop.ShowDialog() == DialogResult.OK)
            {
                pCategories.Controls.Clear();
                categories.Clear();
                categoryNextLocationX = 0;
                categoryNextLocationY = 0;
                string[] category = pop.res1.Split(';');
                for (int i = 0; i < category.Length; i++)
                {
                    Label lbl = new Label();
                    int num;
                    if (categories.Count == 0)
                    {
                        num = 0;
                    }
                    else
                    {
                        num = int.Parse(categories.OrderBy(x => x.Name).Last().Name.Replace("lblCategory", "")) + 1;
                    }
                    lbl.Name = "lblCategory" + num;
                    lbl.AutoSize = true;
                    lbl.Text = category[i];
                    if (categoryNextLocationX + lbl.Size.Width + distBtwCardsX > pCategories.Size.Width)
                    {
                        categoryNextLocationX = 0;
                        categoryNextLocationY += lbl.Size.Height + distBtwCardsY;
                    }
                    lbl.Location = new Point(categoryNextLocationX, categoryNextLocationY);
                    categoryNextLocationX += lbl.Size.Width + distBtwCardsX;
                    pCategories.Controls.Add(lbl);
                    categories.Add(lbl);
                }
            }
        }

        private void lblPublisher_Click(object sender, EventArgs e)
        {
            if (lblPublisher.Text != "Kiadó")
            {
                PopupSelect pub = new PopupSelect("getPublishers", lblPublisher.Text);
                if (pub.ShowDialog() == DialogResult.OK)
                {
                    lblPublisher.Text = pub.res1;
                }
            }
            else
            {
                PopupSelect pub = new PopupSelect("getPublishers");
                if (pub.ShowDialog() == DialogResult.OK)
                {
                    lblPublisher.Text = pub.res1;
                }
            }

        }

        private void lblLang_Click(object sender, EventArgs e)
        {
            PopupSelect lang = new PopupSelect("getLangs");
            if (lang.ShowDialog() == DialogResult.OK)
            {
                lblLang.Text = lang.res1;
            }
        }

        private void cbtnDeactivate_Click(object sender, EventArgs e)
        {
            PopupSelect deactivate = new PopupSelect("deactivateBook", lblISBN.Text);
            deactivate.ShowDialog();
        }

        private async void cbtnAddBook_Click(object sender, EventArgs e)
        {
            List<Dictionary<string, string>> resp = (List<Dictionary<string, string>>)await ApiComm.SendPost(new Dictionary<string, string> { { "type", "addToInventory" }, { "ISBN_id", original["ISBN_id"] } });
            //MessageBox.Show($"A hozzáadott könyv kódja: {resp.First()["book_id"]}");
            using (CustomMessageBoxForm msgBox = new CustomMessageBoxForm($"A hozzáadott könyv kódja: {resp.First()["book_id"]}", "Könyvkód", MessageBoxButtons.OK, MessageBoxIcon.Error))
            {
                msgBox.ShowDialog();
            }
        }

        private void cbtnBack_Click(object sender, EventArgs e)
        {
            LoginForm.main.OpenChildForm(LoginForm.main.allBooksPage);
        }

        private void cbtnAddPicture_Click(object sender, EventArgs e)
        {
            if (ofdPic.ShowDialog() == DialogResult.OK)
            {
                lblPicName.Text = ofdPic.FileName;
                picBase64 = "data:image/png;charset=utf-8;base64," + Convert.ToBase64String(File.ReadAllBytes(ofdPic.FileName));
            }
        }

        private void BookDetailedPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Save();
        }

        private async void Save()
        {
            if (ctbDescription.Texts.Length > 0 && ctbTitle.Texts.Length > 0)
            {
                if (checkChanges())
                {
                    using (CustomMessageBoxForm msgBox = new CustomMessageBoxForm("Menteni szeretné a változtatásokat?", "Változatás", MessageBoxButtons.YesNo))
                    {
                        DialogResult res = msgBox.ShowDialog();

                        if (res == DialogResult.Yes)
                        {
                            Dictionary<string, string> data = new Dictionary<string, string>();
                            data["type"] = "updateBook";
                            data["id"] = original["ISBN_id"];
                            data["title"] = ctbTitle.Texts;
                            data["release_date"] = cdtpReleaseDate.Value.ToString("yyyy-MM-dd");
                            data["lang"] = lblLang.Text;
                            data["publisher"] = lblPublisher.Text;
                            data["authors"] = String.Join(",", authors.Select(x => x.Text));
                            data["genres"] = String.Join(",", categories.Select(x => x.Text));
                            data["description"] = ctbDescription.Texts;
                            data["picture_base64"] = picBase64;
                            try
                            {
                                await ApiComm.SendPost(data);
                            }
                            catch (Exception ex) when (ex is UriFormatException)
                            {
                                using (CustomMessageBoxForm err = new CustomMessageBoxForm("Túl nagy méretű kép és/vagy túl nagy méretű leírás", "Frissítés/hozzáadás hiba"))
                                {
                                    err.ShowDialog();
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                //MessageBox.Show("Ne hagyjon egy mezőt sem üresen");
                using (CustomMessageBoxForm msgBox = new CustomMessageBoxForm("Ne hagyjon egy mezőt sem üresen.", "Hiányzó adatok", MessageBoxButtons.OK, MessageBoxIcon.Error))
                {
                    msgBox.ShowDialog();
                }
            }

        }

        private bool checkChanges()
        {
            bool changed = false;
            if (ctbTitle.Texts != original["title"] || cdtpReleaseDate.Value != DateTime.Parse(original["release_date"]) || lblLang.Text != original["lang"] || lblPublisher.Text != original["name"] || String.Join(",", authors.Select(x => x.Text).OrderBy(x => x)) != original["authors"] || String.Join(",", categories.Select(x => x.Text)) != original["genres"] || ctbDescription.Texts != original["description"] || original["picture_base64"] != picBase64)
            {
                changed = true;
            }
            return changed;
        }


        private void ctbISBN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= 48 && e.KeyChar <= 57 || e.KeyChar == (char)Keys.Back || ModifierKeys.HasFlag(Keys.Control)))
            {
                e.Handled = true;
            }
        }

        private List<Label> categories = new List<Label>();
        public BookDetailedPage(string mode)
        {
            if (mode == "add")
            {
                addMode = true;
            }
            else
            {
                isbn = mode;
            }
            InitializeComponent();
			this.Padding = new Padding((int)BorderWidth);
			FormDragger.MakeDraggable(this);
            this.BorderColor = Color.FromArgb(10, 123, 106);
            this.BorderWidth = 8;
		}

        protected override void OnShown(EventArgs e)
        {
            ThemeManager.ApplyTheme(this);
            base.OnShown(e);
        }


        [Category("Border")]
        [Browsable(true)]
        public float BorderWidth { get; set; } = 8.0f;
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


        private void BookDetailedPage_Load(object sender, EventArgs e)
        {
            if (addMode)
            {
                pManage.Visible = false;
                ctbISBN.Visible = true;
                cbtnBack.Text = "Hozzáad";
                cbtnAddPicture.Text = "Kép hozzáadása";
                cbtnBack.Click -= cbtnBack_Click;
                cbtnBack.Click += cbtnAdd_Click;
                this.FormClosing -= BookDetailedPage_FormClosing;
            }
            else
            {
                LoadData();
            }

        }

        private async void cbtnAdd_Click(object sender, EventArgs e)
        {
            if ((cdtpReleaseDate.Value < DateTime.Parse("2007.01.01.") && ctbISBN.Texts.Length == 11) || (cdtpReleaseDate.Value >= DateTime.Parse("2007.01.01.") && ctbISBN.Texts.Length == 13) || (int.TryParse(ctbISBN.Texts, out int buff)))
            {
                if (lblLang.Text != "Nyelv" && lblPublisher.Text != "Kiadó" && authors.Count > 0 && categories.Count > 0 && ctbTitle.Texts.Length > 0 && ctbDescription.Texts.Length > 0 && lblPicName.Text.Length > 0)
                {
                    Dictionary<string, string> data = new Dictionary<string, string>();
                    data["type"] = "addBookType";
                    data["isbn"] = ctbISBN.Texts;
                    data["title"] = ctbTitle.Texts;
                    data["release_date"] = cdtpReleaseDate.Value.ToString("yyyy-MM-dd");
                    data["lang"] = lblLang.Text;
                    data["publisher"] = lblPublisher.Text;
                    data["allAuthors"] = String.Join(",", authors.Select(x => x.Text));
                    data["allGenres"] = String.Join(",", categories.Select(x => x.Text));
                    data["descript"] = ctbDescription.Texts;
                    data["picture"] = picBase64;
                    
                    try
                    {
                        List<Dictionary<string, string>> resp = (List<Dictionary<string, string>>)await ApiComm.SendPost(data);

                        if (resp.First()["state"] != "Already exists")
                        {
                            using (CustomMessageBoxForm msgBox = new CustomMessageBoxForm("Szeretne egyből ennek a könyvnek a részletes oldalára kerülni.", "Sikeres hozzáadás!", MessageBoxButtons.YesNo))
                            {
                                DialogResult res = msgBox.ShowDialog();

                                List<Dictionary<string, string>> resp2 = (List<Dictionary<string, string>>)await ApiComm.SendPost(new Dictionary<string, string> { { "type", "addToInventory" }, { "ISBN_id", resp.First()["state"] } });
                                //MessageBox.Show($"A hozzáadott könyv kódja: {resp2.First()["book_id"]}");
                                if (res == DialogResult.Yes)
                                {
                                    using (CustomMessageBoxForm msgBoxK = new CustomMessageBoxForm($"A hozzáadott könyv kódja: {resp2.First()["book_id"]}", "Könyvkód", MessageBoxButtons.OK))
                                    {
                                        msgBoxK.ShowDialog();
                                    }

                                    LoginForm.main.OpenChildForm(new BookDetailedPage(ctbISBN.Texts));
                                }
                                using (CustomMessageBoxForm msgBoxK = new CustomMessageBoxForm($"A hozzáadott könyv kódja: {resp2.First()["book_id"]}", "Könyvkód", MessageBoxButtons.OK))
                                {
                                    msgBoxK.ShowDialog();
                                }

                            }
                            this.Close();
                        }
                        else
                        {
                            //MessageBox.Show("Ilyen könyv típus már fent van az adatbázisban");
                            using (CustomMessageBoxForm msgBox = new CustomMessageBoxForm("Ilyen könyv típus már fent van az adatbázisban.", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error))
                            {
                                msgBox.ShowDialog();
                            }
                        }
                    }
                    catch (Exception ex) when(ex is UriFormatException)
                    {
                        using (CustomMessageBoxForm err = new CustomMessageBoxForm("Túl nagy méretű kép és/vagy túl nagy méretű leírás", "Frissítés/hozzáadás hiba"))
                        {
                            err.ShowDialog();
                        }
                        

                    }
                    
                }
                else
                {
                    //MessageBox.Show("Ne hagyjon egy mezőt sem üresen");
                    using (CustomMessageBoxForm msgBox = new CustomMessageBoxForm("Ne hagyjon egy mezőt sem üresen.", "Hiányzó adatok", MessageBoxButtons.OK, MessageBoxIcon.Error))
                    {
                        msgBox.ShowDialog();
                    }
                }
            }
            else
            {
                //MessageBox.Show("Nem megfelelő hosszú vagy formátumú az ISBN kód");
                using (CustomMessageBoxForm msgBox = new CustomMessageBoxForm("Nem megfelelő hosszú vagy formátumú az ISBN kód.", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error))
                {
                    msgBox.ShowDialog();
                }
            }
        }

        private async void LoadData() {
            List<Dictionary<string, string>> resp = (List<Dictionary<string, string>>)await ApiComm.SendPost(new Dictionary<string, string> { { "type", "getBookDetailed" }, { "ISBN", isbn } });
            original = resp.First();
            lblISBN.Text = isbn;
            ctbTitle.Texts = original["title"];
            cdtpReleaseDate.Value = DateTime.Parse(original["release_date"]);
            lblPublisher.Text = original["name"];
            ctbDescription.Texts = original["description"];
            picBase64 = original["picture_base64"];
            lblLang.Text = original["lang"];
            resp = (List<Dictionary<string, string>>)await ApiComm.SendPost(new Dictionary<string, string> { { "type", "getAuthors" }, { "ISBN_id", original["ISBN_id"] }, { "inverse", "0" } });
            authorNextLocationX = 0;
            authorNextLocationY = 0;
            for (int i = 0; i < resp.Count; i++) {
                Label lbl = new Label();
                int num;
                if (authors.Count == 0)
                {
                    num = 0;
                }
                else
                {
                    num = int.Parse(authors.OrderBy(x => x.Name).Last().Name.Replace("lblAuthor", "")) + 1;
                }
                lbl.Name = "lblAuthor" + num;

                lbl.AutoSize = true;
                lbl.Text = resp[i]["author"];
                if (authorNextLocationX + lbl.Size.Width + distBtwCardsX > pAuthors.Size.Width)
                {
                    authorNextLocationX = 0;
                    authorNextLocationY += lbl.Size.Height + distBtwCardsY;
                }
                lbl.Location = new Point(authorNextLocationX, authorNextLocationY);
                authorNextLocationX += lbl.Size.Width + distBtwCardsX;
                pAuthors.Controls.Add(lbl);
                authors.Add(lbl);
            }
            resp = (List<Dictionary<string, string>>)await ApiComm.SendPost(new Dictionary<string, string> { { "type", "getCategories" }, { "ISBN_id", original["ISBN_id"] }, { "inverse", "0" } });
            categoryNextLocationX = 0;
            categoryNextLocationY = 0;
            for (int i = 0; i < resp.Count; i++)
            {
                Label lbl = new Label();
                int num;
                if (categories.Count == 0)
                {
                    num = 0;
                }
                else
                {
                    num = int.Parse(categories.OrderBy(x => x.Name).Last().Name.Replace("lblCategory", "")) + 1;
                }
                lbl.Name = "lblCategory" + num;
                lbl.AutoSize = true;
                lbl.Text = resp[i]["genre"];
                if (categoryNextLocationX + lbl.Size.Width + distBtwCardsX > pCategories.Size.Width)
                {
                    categoryNextLocationX = 0;
                    categoryNextLocationY += lbl.Size.Height + distBtwCardsY;
                }
                lbl.Location = new Point(categoryNextLocationX, categoryNextLocationY);
                categoryNextLocationX += lbl.Size.Width + distBtwCardsX;
                pCategories.Controls.Add(lbl);
                categories.Add(lbl);
            }
        }
    }
}
