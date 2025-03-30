using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Desktop
{
	internal class ThemeManager
	{

        private const string ThemeFilePath = "theme.config";

        public static string CurrentTheme { get; private set; }

        [DllImport("uxtheme.dll", CharSet = CharSet.Unicode)]
        private static extern int GetCurrentThemeName(StringBuilder themeFileName, int maxNameChars,
                                                      StringBuilder colorBuffer, int maxColorChars,
                                                      StringBuilder sizeBuffer, int maxSizeChars);

        public static void Initialize()
        {
            string savedTheme = LoadSavedTheme();

			if (!string.IsNullOrEmpty(savedTheme))
            {
                CurrentTheme = savedTheme;
            }
			else
            {
                CurrentTheme = GetSystemTheme();
            }

			ApplyThemeToAllForms();
        }

        public static void SetTheme(string theme)
        {
            if (theme != "Light" && theme != "Dark")
                throw new ArgumentException("Helytelen téma.");

            CurrentTheme = theme;
            SaveTheme(theme);
            ApplyThemeToAllForms();
        }

        private static string LoadSavedTheme()
        {
            if (File.Exists(ThemeFilePath))
            {
                return File.ReadAllText(ThemeFilePath).Trim();
            }
            return null;
        }

        private static void SaveTheme(string theme)
        {
            File.WriteAllText(ThemeFilePath, theme);
        }

		private static string GetSystemTheme()
		{
			const string registryPath = @"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Themes\Personalize";
			const string appsThemeKey = "AppsUseLightTheme";
				int appsThemeValue = (int)Registry.GetValue(registryPath, appsThemeKey, -1);


			if (appsThemeValue == 0)
			{
				return "Dark";
			}
			else if (appsThemeValue == 1)
			{
				return "Light";
			}
			else
			{
				return "Dark";
			}
		}

		public static void ApplyThemeToAllForms()
        {
            foreach (Form form in Application.OpenForms)
            {
                ApplyTheme(form);
            }

            //Application.AddMessageFilter(new MessageFilter());
        }

        /*private class MessageFilter : IMessageFilter
        {
            public bool PreFilterMessage(ref Message m)
            {
                if (m.Msg == 0x200) // WM_MOUSEMOVE
                {
                    if (m.HWnd != IntPtr.Zero && !Control.FromHandle(m.HWnd).IsDisposed)
                    {
                        Form form = Control.FromHandle(m.HWnd) as Form;
                        if (form != null && !form.IsDisposed && !form.IsHandleCreated)
                        {
                            ThemeManager.ApplyTheme(form);
                        }
                    }
                }
                return false;
            }
        }*/

        public static void ApplyTheme(Control control)
		{
            string imagePath = Path.Combine(Application.StartupPath + "\\icons\\");

            var buttonIcons = new Dictionary<string, Image>
			{
				{ "button_HomePage", CurrentTheme == "Light" ? Image.FromFile(imagePath + "home-line_black.png") : Image.FromFile(imagePath + "home-line_white.png") },

                { "button_Books", CurrentTheme == "Light" ? Image.FromFile(imagePath + "book-line_black.png") : Image.FromFile(imagePath + "book-line_white.png") },

                { "button_Users", CurrentTheme == "Light" ? Image.FromFile(imagePath + "group-line_black.png") : Image.FromFile(imagePath + "group-line_white.png") },

                { "button3", CurrentTheme == "Light" ? Image.FromFile(imagePath + "bookmark-line_black.png") : Image.FromFile(imagePath + "bookmark-line_white.png") },

                { "button4", CurrentTheme == "Light" ? Image.FromFile(imagePath + "bookmark-line_black.png") : Image.FromFile(imagePath + "bookmark-line_white.png") },

                { "button_Publishers", CurrentTheme == "Light" ? Image.FromFile(imagePath + "publisher-line_black.png") : Image.FromFile(imagePath + "publisher-line_white.png") },

                { "button_CloseLoginForm", CurrentTheme == "Light" ? Image.FromFile(imagePath + "close-line_black.png") : Image.FromFile(imagePath + "close-line_white.png") },

                { "button_Borrowings", CurrentTheme == "Light" ? Image.FromFile(imagePath + "book-open-line_black.png") : Image.FromFile(imagePath + "book-open-line_white.png") },

                { "button_Bookings", CurrentTheme == "Light" ? Image.FromFile(imagePath + "calendar-line_black.png") : Image.FromFile(imagePath + "calendar-line_white.png") },

                { "button_Reservations", CurrentTheme == "Light" ? Image.FromFile(imagePath + "reserved-line_black.png") : Image.FromFile(imagePath + "reserved-line_white.png") },


                { "pbNewBookings", CurrentTheme == "Light" ? Image.FromFile(imagePath + "red_excl_c.png") : Image.FromFile(imagePath + "red_excl_c.png") }
            };

			if (control is Form form)
			{
				if (form.Name == "MainForm")
				{
					form.BackColor = CurrentTheme == "Light" ? Color.FromArgb(220, 220, 220) : Color.FromArgb(25, 25, 39);
					form.ForeColor = CurrentTheme == "Light" ? Color.Black : Color.White;
				}
				else
				{
					form.BackColor = CurrentTheme == "Light" ? Color.FromArgb(245, 245, 245) : Color.FromArgb(51, 51, 68);
					form.ForeColor = CurrentTheme == "Light" ? Color.Black : Color.White;
				}
			}
			else if (control is Panel panel)
			{
				if (panel.Name == "panel_Menu" || panel.Name == "panel_Container" || panel.Name == "panel_Links" || panel.Name == "panel_Theme" || panel.Name == "panel_User" || panel.Name == "tableLayoutPanel_Main")
				{
                    
                    panel.BackColor = CurrentTheme == "Light" ? Color.FromArgb(220, 220, 220) : Color.FromArgb(25, 25, 39);
                }
				else if(panel.Name == "panel_BooksSubMenu")
				{
					
					panel.BackColor = CurrentTheme == "Light" ? Color.FromArgb(245, 245, 245) : Color.FromArgb(34, 34, 48);
				}
				else
				{
                    panel.BackColor = CurrentTheme == "Light" ? Color.FromArgb(245, 245, 245) : Color.FromArgb(51, 51, 68);
                }

			}
			else if (control is CustomButton button)
			{


                if (button.Name == "cbtnLogout")
                {
                    button.BackColor = Color.Brown;
                    button.ForeColor = Color.White;
                }


                else
                {
                    button.BackColor = CurrentTheme == "Light" ? Color.FromArgb(143, 143, 143) : Color.FromArgb(36, 72, 85);
					button.ForeColor = Color.White;


					if (buttonIcons.TryGetValue(button.Name, out var icon))
					{
                        if (button.Name == "button_CloseLoginForm")
                        {
                            button.BackColor = CurrentTheme == "Light" ? Color.FromArgb(245, 245, 245) : Color.FromArgb(51, 51, 68);
                            button.Image = icon;
                        }
                        button.Image = icon;
					}
                }

            }
            else if (control is System.Windows.Forms.Button Nbutton)
            {
				if (Nbutton.Tag as string == "menuButtons")
				{
					Nbutton.BackColor = CurrentTheme == "Light" ? Color.FromArgb(220, 220, 220) : Color.FromArgb(25, 25, 39);
					Nbutton.ForeColor = CurrentTheme == "Light" ? Color.Black : Color.White;

				}
			}
			else if (control is Label label)
			{
				label.ForeColor = CurrentTheme == "Light" ? Color.Black : Color.FromArgb(245, 245, 245);
            }
			else if (control is CheckBox toggleButton)
			{
				if (toggleButton.Name == "toggleButton_ThemeChanger")
				{
					toggleButton.Checked = CurrentTheme == "Light";
				}
			}
			else if (control is PictureBox pictureBox)
			{
				if (pictureBox.Name == "pictureBox_UserPic")
				{
					pictureBox.Image = CurrentTheme == "Light" ? Image.FromFile(imagePath + "user-line_black.png") : Image.FromFile(imagePath + "user-line_white.png");

                }
            }
            else if (control is CustomDataGridView dataGrid)
            {
                dataGrid.BackgroundColor = CurrentTheme == "Light" ? Color.FromArgb(200, 200, 200) : Color.FromArgb(35, 35, 55);
                dataGrid.GridColor = CurrentTheme == "Light" ? Color.FromArgb(200, 200, 200) : Color.FromArgb(71, 71, 88);

                dataGrid.ColumnHeadersDefaultCellStyle.BackColor = CurrentTheme == "Light" ? Color.FromArgb(200, 200, 200) : Color.FromArgb(35, 35, 55);
                dataGrid.ColumnHeadersDefaultCellStyle.ForeColor = CurrentTheme == "Light" ? Color.Black : Color.White;

                dataGrid.RowHeadersDefaultCellStyle.BackColor = CurrentTheme == "Light" ? Color.FromArgb(200, 200, 200) : Color.FromArgb(35, 35, 55);

                dataGrid.DefaultCellStyle.BackColor = CurrentTheme == "Light" ? Color.FromArgb(245, 245, 245) : Color.FromArgb(51, 51, 68);
                dataGrid.DefaultCellStyle.ForeColor = CurrentTheme == "Light" ? Color.Black : Color.White;

                dataGrid.AlternatingRowsDefaultCellStyle.BackColor = CurrentTheme == "Light" ? Color.FromArgb(220, 220, 220) : Color.FromArgb(71, 71, 88);
            }

			else if (control is CustomDateTimePicker dateTP)
			{
				dateTP.SkinColor = CurrentTheme == "Light" ? Color.FromArgb(245, 245, 245) : Color.FromArgb(71, 71, 88);
				dateTP.TextColor = CurrentTheme == "Light" ? Color.Black : Color.White;
				dateTP.BorderColor = CurrentTheme == "Light" ? Color.FromArgb(143, 143, 143) : Color.FromArgb(36, 72, 85);
			}

			else if (control is CustomTextbox CtextBox)
            {
                CtextBox.BackColor = CurrentTheme == "Light" ? Color.FromArgb(245, 245, 245) : Color.FromArgb(71, 71, 88);
                CtextBox.ForeColor = CurrentTheme == "Light" ? Color.Black : Color.White;
                CtextBox.BorderColor = CurrentTheme == "Light" ? Color.FromArgb(143, 143, 143) : Color.FromArgb(36, 72, 85);
                CtextBox.BorderFocusColor = CurrentTheme == "Light" ? Color.FromArgb(168, 218, 220) : Color.FromArgb(168, 218, 220);
                CtextBox.PlaceholderColor = Color.DarkGray;

			}




            foreach (Control childControl in control.Controls)
			{
				ApplyTheme(childControl);
			}
		}
	}
}