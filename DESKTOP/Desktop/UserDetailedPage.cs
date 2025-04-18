﻿using System;
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
	public partial class UserDetailedPage : Form
	{
		private string user_id;
		private Dictionary<string, string> user_data;
        public UserDetailedPage(string userId)
		{
			InitializeComponent();
			user_id = userId;
		}

        private async void UserDetailedPage_Load(object sender, EventArgs e)
        {
			List<Dictionary<string, string>> temp = (List<Dictionary<string, string>>)await ApiComm.SendPost(new Dictionary<string, string> { {"type", "getUserDetailed" }, {"id", user_id} });
			user_data = temp.First();
			lblName.Text = user_data["surname"] + " " + user_data["first_name"];
			lblUname.Text = user_data["username"];
			if (user_data["active"] == "1")
			{
                lblState.Text = "active";
			}
			else
			{
                
				Deactivated();
            }
			
			lblTagsag.Text = user_data["membership_end_date"];
			ctbSurname.Texts = user_data["surname"];
			ctbFirstname.Texts = user_data["first_name"];
			cdtpBirthDate.Value = DateTime.Parse(user_data["birth_date"]);
			ctbEmail.Texts = user_data["email"];
			ctbPhone.Texts = user_data["phone_number"];
			ctbBirthplace.Texts = user_data["birth_place"];
			ctbAddress.Texts = user_data["address"];
			ctbMmn.Texts = user_data["mother_maiden_name"];

		}

		private void cbtnBack_Click(object sender, EventArgs e)
		{
			LoginForm.main.OpenChildForm(LoginForm.main.usersPage);
			
        }
		private async void Save()
		{
            if (checkChanges())
            {
                //DialogResult res = MessageBox.Show("Menteni szeretné a változtatásokat?", "Változatás", MessageBoxButtons.YesNo);

				using (CustomMessageBoxForm msgBox = new CustomMessageBoxForm("Menteni szeretné a változtatásokat?", "Változatás", MessageBoxButtons.YesNo))
				{
					DialogResult res = msgBox.ShowDialog();

					if (res == DialogResult.Yes)
					{
						Dictionary<string, string> data = new Dictionary<string, string>();
						data["type"] = "updateUser";
						data["id"] = user_id;
						data["firstname"] = ctbFirstname.Texts;
						data["surname"] = ctbSurname.Texts;
						data["birthplace"] = ctbBirthplace.Texts;
						data["birthdate"] = cdtpBirthDate.Value.ToString("yyyy-MM-dd");
						data["address"] = ctbAddress.Texts;
						data["email"] = ctbEmail.Texts;
						data["phone"] = ctbPhone.Texts;
						data["mmn"] = ctbMmn.Texts;
						await ApiComm.SendPost(data);

					}
				}


                

            }
        }
		private bool checkChanges() {
			bool changed = false;
			if (ctbSurname.Texts != user_data["surname"] || ctbFirstname.Texts != user_data["first_name"] || cdtpBirthDate.Value != DateTime.Parse(user_data["birth_date"]) || ctbEmail.Texts != user_data["email"] || ctbPhone.Texts != user_data["phone_number"] || ctbBirthplace.Texts != user_data["birth_place"] || ctbAddress.Texts != user_data["address"] || ctbMmn.Texts != user_data["mother_maiden_name"])
			{
				changed = true;
			}
			return changed;
		}

        private async void ctbExtendMembership_Click(object sender, EventArgs e)
        {
			/*if (MessageBox.Show($"Biztosan meg szeretné hosszabbítani a tagságot 1 évvel?\r\n Ár: {LoginForm.main.system_settings["membership_fee"]} Ft", "Tagság hosszabbítása", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				List<Dictionary<string, string>> res = (List<Dictionary<string, string>>)await ApiComm.SendPost(new Dictionary<string, string> { { "type", "renewMembership" }, { "id", user_id } });
				lblTagsag.Text = res.First()["membership_end_date"];
			}*/

			using (CustomMessageBoxForm msgBox = new CustomMessageBoxForm($"Biztosan meg szeretné hosszabbítani a tagságot 1 évvel?\r\n Ár: {LoginForm.main.system_settings["membership_fee"]} Ft", "Tagság hosszabbítása", MessageBoxButtons.YesNo))
			{
				if (msgBox.ShowDialog() == DialogResult.Yes)
				{
					List<Dictionary<string, string>> res = (List<Dictionary<string, string>>)await ApiComm.SendPost(new Dictionary<string, string> { { "type", "renewMembership" }, { "id", user_id } });
					lblTagsag.Text = res.First()["membership_end_date"];
				}
			}
		}

        private async void btnDeactivateUser_Click(object sender, EventArgs e)
        {
            /*if(MessageBox.Show($"Biztosan véglegesen deaktiválni szeretné ezt a felhasználót?", "Felhasználó deaktiválása", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

			}*/

			using (CustomMessageBoxForm msgBox = new CustomMessageBoxForm($"Biztosan véglegesen deaktiválni szeretné ezt a felhasználót?", "Felhasználó deaktiválása", MessageBoxButtons.YesNo))
			{
				if (msgBox.ShowDialog() == DialogResult.Yes)
				{
					List<Dictionary<string, string>> res = (List<Dictionary<string, string>>)await ApiComm.SendPost(new Dictionary<string, string> { { "type", "deactivateUser" }, { "id", user_id } });
					//deactivate user sets membershipdate back by 1 day and runs auto delete so it deletes them 
					List<Dictionary<string, string>> reservationResult = (List<Dictionary<string, string>>)await ApiComm.SendPost(new Dictionary<string, string>() { { "type", "deleteExpiredReservations" } });
					string reservationChanges = reservationResult.First()["output"];
					List<Dictionary<string, string>> bookingResult = (List<Dictionary<string, string>>)await ApiComm.SendPost(new Dictionary<string, string>() { { "type", "deleteExpiredBookings" } });
					string outputChanges = bookingResult.First()["output"];
					if (outputChanges.Length > 0 || reservationChanges.Length > 0)
					{
						//write it out changes once it is implemented
					}
					Deactivated();
				}
			}
		}

		private void Deactivated()
		{
            lblState.Text = "inactive";
            ctbBirthplace.IsReadOnly = true;
			ctbAddress.IsReadOnly = true;
			ctbEmail.IsReadOnly = true;
			ctbPhone.IsReadOnly = true;
			ctbMmn.IsReadOnly = true;
			ctbFirstname.IsReadOnly = true;
			ctbSurname.IsReadOnly = true;
			cdtpBirthDate.Enabled = false;
		}

        private void cbtnBorrow_Click(object sender, EventArgs e)
        {
			PopupSelect pop = new PopupSelect("bookOrReserve", user_id);
			pop.ShowDialog();
        }

        private void UserDetailedPage_FormClosing(object sender, FormClosingEventArgs e)
        {
			Save();
        }
    }
}
