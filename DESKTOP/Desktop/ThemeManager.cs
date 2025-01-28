using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            StringBuilder themeName = new StringBuilder(260);
            StringBuilder color = new StringBuilder(260);
            StringBuilder size = new StringBuilder(260);

            GetCurrentThemeName(themeName, themeName.Capacity, color, color.Capacity, size, size.Capacity);

            return color.ToString().IndexOf("dark", StringComparison.OrdinalIgnoreCase) >= 0 ? "Dark" : "Light";

        }

        public static void ApplyThemeToAllForms()
        {
            foreach (Form form in Application.OpenForms)
            {
                ApplyTheme(form);
            }
        }

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

                { "button_CloseLoginForm", CurrentTheme == "Light" ? Image.FromFile(imagePath + "close-line_black.png") : Image.FromFile(imagePath + "close-line_white.png") }
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
			else if (control is Button button)
			{
                if (button.Tag as string == "DropdownMenu")
                {
                    button.BackColor = CurrentTheme == "Light" ? Color.FromArgb(235, 235, 235) : Color.FromArgb(34, 34, 48);
                    button.ForeColor = CurrentTheme == "Light" ? Color.Black : Color.White;
                }

                else
                {
                    button.BackColor = CurrentTheme == "Light" ? Color.FromArgb(220, 220, 220) : Color.FromArgb(25, 25, 39);
                    button.ForeColor = CurrentTheme == "Light" ? Color.Black : Color.White;


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
			else if (control is Label label)
			{
				label.ForeColor = CurrentTheme == "Light" ? Color.Black : Color.FromArgb(245, 245, 245);
            }
            else if (control is CheckBox toggleButton)
            {
                if (toggleButton.Name == "toggleButton_ThemeChanger")
                {
                    toggleButton.Checked = CurrentTheme == "Light" ? true : false;
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
                dataGrid.BackgroundColor = CurrentTheme == "Light" ? Color.FromArgb(245, 245, 245) : Color.FromArgb(51, 51, 68);
				dataGrid.CellBackColor = CurrentTheme == "Light" ? Color.FromArgb(245, 245, 245) : Color.FromArgb(51, 51, 68);
				dataGrid.AlternatingRowBackColor = CurrentTheme == "Light" ? Color.FromArgb(220, 220, 220) : Color.FromArgb(71, 71, 88);
            }



            // Gyermek vezérlők rekurzív kezelése
            foreach (Control childControl in control.Controls)
			{
				ApplyTheme(childControl);
			}
		}
	}
}