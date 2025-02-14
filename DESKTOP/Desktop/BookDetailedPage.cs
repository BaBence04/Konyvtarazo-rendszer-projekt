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
    public partial class BookDetailedPage : Form
    {
        private string isbn;
        private Dictionary<string, string> original;
        private int distBtwCardsX = 1, distBtwCardsY = 1, authorNextLocationX, authorNextLocationY, categoryNextLocationX, categoryNextLocationY;
        private List<Label> authors = new List<Label>();

        private void cbtnDeleteAuthor_Click(object sender, EventArgs e)
        {
            if (!lblAuthorDeleteMode.Visible)
            {
                lblAuthorDeleteMode.Visible = true;
            }
            else
            {
                lblAuthorDeleteMode.Visible = false;
            }
        }
        private void cbtnDeleteCategory_Click(object sender, EventArgs e)
        {
            if (!lblCategoryDeleteMode.Visible)
            {
                lblCategoryDeleteMode.Visible = true;
            }
            else
            {
                lblCategoryDeleteMode.Visible = false;
            }
        }

        private void cbtnAddAuthor_Click(object sender, EventArgs e)
        {
            PopupSelect pop = new PopupSelect("getAuthors", String.Join(";", authors.Select(x=>x.Text).ToArray()));
            if (pop.ShowDialog() == DialogResult.OK)
            {
                Label lbl = new Label();
                lbl.Name = "lblAuthor" + pop.id;
                lbl.AutoSize = true;
                lbl.Text = pop.res1;
                if (authorNextLocationX + lbl.Size.Width + distBtwCardsX > pAuthors.Size.Width)
                {
                    authorNextLocationX = 0;
                    authorNextLocationY += lbl.Size.Height + distBtwCardsY;
                }
                lbl.Location = new Point(authorNextLocationX, authorNextLocationY);
                authorNextLocationX += lbl.Size.Width + distBtwCardsX;
                lbl.Click += lbl_Click;
                pAuthors.Controls.Add(lbl);
                authors.Add(lbl);
            }
        }
        private void cbtnAddCategory_Click(object sender, EventArgs e)
        {
            PopupSelect pop = new PopupSelect("getCategories", String.Join(";", categories.Select(x => x.Text).ToArray()));
            if (pop.ShowDialog() == DialogResult.OK)
            {
                Label lbl = new Label();
                lbl.Name = "lblCategory" + pop.id;
                lbl.AutoSize = true;
                lbl.Text = pop.res1;
                if (categoryNextLocationX + lbl.Size.Width + distBtwCardsX > pCategories.Size.Width)
                {
                    categoryNextLocationX = 0;
                    categoryNextLocationY += lbl.Size.Height + distBtwCardsY;
                }
                lbl.Location = new Point(categoryNextLocationX, categoryNextLocationY);
                categoryNextLocationX += lbl.Size.Width + distBtwCardsX;
                lbl.Click += lbl_Click;
                pCategories.Controls.Add(lbl);
                categories.Add(lbl);
            }
        }

        private void lblPublisher_Click(object sender, EventArgs e)
        {
            PopupSelect pub = new PopupSelect("getPublishers");
            if (pub.ShowDialog() == DialogResult.OK)
            {
                lblPublisher.Text = pub.res1;
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

        private List<Label> categories  = new List<Label>();
        public BookDetailedPage(string ISBN)
        {
            isbn = ISBN;
            InitializeComponent();
        }

        private void BookDetailedPage_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private async void LoadData() { 
            List<Dictionary<string, string>> resp = (List<Dictionary<string, string>>)await ApiComm.SendPost(new Dictionary<string, string> { { "type", "getBookDetailed" }, { "ISBN", isbn } });
            original = resp.First();
            lblISBN.Text = isbn;
            ctbTitle.Texts = original["title"];
            dtpReleaseDate.Value = DateTime.Parse(original["release_date"]);
            lblPublisher.Text = original["name"];
            lblLang.Text = original["lang"];
            resp = (List<Dictionary<string, string>>)await ApiComm.SendPost(new Dictionary<string, string> { { "type", "getAuthors" }, { "ISBN_id", original["ISBN_id"] }, {"inverse", "0" } });
            authorNextLocationX = 0;
            authorNextLocationY = 0;
            for (int i = 0; i < resp.Count; i++) {
                Label lbl = new Label();
                lbl.Name = "lblAuthor" + resp[i]["author_id"];
                lbl.AutoSize = true;
                lbl.Text = resp[i]["author"];
                if (authorNextLocationX+lbl.Size.Width+distBtwCardsX>pAuthors.Size.Width)
                {
                    authorNextLocationX = 0;
                    authorNextLocationY += lbl.Size.Height + distBtwCardsY;
                }
                lbl.Location = new Point(authorNextLocationX, authorNextLocationY);
                authorNextLocationX += lbl.Size.Width + distBtwCardsX;
                lbl.Click += lbl_Click; 
                pAuthors.Controls.Add(lbl);
                authors.Add(lbl);
            }
            resp = (List<Dictionary<string, string>>)await ApiComm.SendPost(new Dictionary<string, string> { { "type", "getCategories" }, { "ISBN_id", original["ISBN_id"] }, { "inverse", "0" } });
            categoryNextLocationX = 0;
            categoryNextLocationY = 0;
            for (int i = 0; i < resp.Count; i++)
            {
                Label lbl = new Label();
                lbl.Name = "lblCategory" + resp[i]["genre_id"];
                lbl.AutoSize = true;
                lbl.Text = resp[i]["genre"];
                if (categoryNextLocationX + lbl.Size.Width + distBtwCardsX > pCategories.Size.Width)
                {
                    categoryNextLocationX = 0;
                    categoryNextLocationY += lbl.Size.Height + distBtwCardsY;
                }
                lbl.Location = new Point(categoryNextLocationX, categoryNextLocationY);
                categoryNextLocationX += lbl.Size.Width + distBtwCardsX;
                lbl.Click += lbl_Click;
                pCategories.Controls.Add(lbl);
                categories.Add(lbl);
            }
        }

        private void lbl_Click(object sender, EventArgs e)
        {
            if ((sender as Label).Name.Contains("Author") && lblAuthorDeleteMode.Visible)
            {
                authors.Remove(sender as Label);
                pAuthors.Controls.Clear();
                authorNextLocationX = 0;
                authorNextLocationY = 0;
                foreach (var item in authors)
                {
                    if (authorNextLocationX + item.Size.Width + distBtwCardsX > pAuthors.Size.Width)
                    {
                        authorNextLocationX = 0;
                        authorNextLocationY += item.Size.Height + distBtwCardsY;
                    }
                    item.Location = new Point(authorNextLocationX, authorNextLocationY);
                    authorNextLocationX += item.Size.Width + distBtwCardsX;
                    pAuthors.Controls.Add (item);
                }
            }
            else if((sender as Label).Name.Contains("Category") && lblCategoryDeleteMode.Visible)
            {
                categories.Remove(sender as Label);
                pCategories.Controls.Clear();
                categoryNextLocationX = 0;
                categoryNextLocationY = 0;
                foreach (var item in categories)
                {
                    if (categoryNextLocationX + item.Size.Width + distBtwCardsX > pCategories.Size.Width)
                    {
                        categoryNextLocationX = 0;
                        categoryNextLocationY += item.Size.Height + distBtwCardsY;
                    }
                    item.Location = new Point(categoryNextLocationX, categoryNextLocationY);
                    categoryNextLocationX += item.Size.Width + distBtwCardsX;
                    pCategories.Controls.Add(item);
                }
            }
        }
    }
}
