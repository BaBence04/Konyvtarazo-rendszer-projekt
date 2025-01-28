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
	public partial class BookLendingPage : Form
	{
        static string book_id, user_id;
        public BookLendingPage(string id, bool isBook_id)
		{
			InitializeComponent();
		}
		//when it is a booking
		public BookLendingPage(string userID, string bookID) { 
			InitializeComponent();
		}
        

    }
}
