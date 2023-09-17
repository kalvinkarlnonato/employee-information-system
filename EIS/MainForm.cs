using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EIS.Forms;
using FontAwesome.Sharp;
using Library;


namespace EIS
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            ChangeToRoudedProfile();
            LoadDefaultProfilePicture();
            leftBorderButton = new Panel();
            leftBorderButton.Size = new Size(7, 43);
            this.Controls.Add(leftBorderButton);
        }
        #region UI Style
        //Fields
        private IconButton currentButton;
        private Panel leftBorderButton;
        private Form currentChildForm;
        //Structure
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(53, 216, 59);
            public static Color color2 = Color.FromArgb(50, 202, 210);
            public static Color color3 = Color.FromArgb(192, 64, 0);
            public static Color color4 = Color.FromArgb(249, 88, 155);
        }
        //Methods
        private void ActivateButton(object senderButton, Color color)
        {
            if (senderButton != null)
            {
                DisableButton();
                //Button
                currentButton = (IconButton)senderButton;
                currentButton.BackColor = Color.FromArgb(37, 36, 81);
                currentButton.ForeColor = color;
                currentButton.TextAlign = ContentAlignment.MiddleCenter;
                currentButton.IconColor = color;
                currentButton.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentButton.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderButton.BackColor = color;
                leftBorderButton.Location = new Point(0, currentButton.Location.Y);
                leftBorderButton.Visible = true;
                leftBorderButton.BringToFront();
                //Icon current child form
                currentChildIcon.IconChar = currentButton.IconChar;
                currentChildIcon.IconColor = color;
            }
        }
        //Function
        private void DisableButton()
        {
            if (currentButton != null)
            {
                currentButton.BackColor = Color.Transparent;
                currentButton.ForeColor = Color.Black;
                if (GlobalConfiguration.IsDark) currentButton.ForeColor = Color.White;
                currentButton.TextAlign = ContentAlignment.MiddleLeft;
                currentButton.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentButton.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        private void ChangeToRoudedProfile()
        {
            GraphicsPath obj = new GraphicsPath(); ;
            obj.AddEllipse(0, 0, ProfilePicture.Width, ProfilePicture.Height);
            Region rg = new Region(obj);
            ProfilePicture.Region = rg;
        }
        private void LoadDefaultProfilePicture()
        {
            string imageFile = Path.Combine(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location), "EIS.picture");
            if (File.Exists(imageFile))
            {
                using (Bitmap bmp = new Bitmap(imageFile))
                {
                    MemoryStream m = new MemoryStream();
                    bmp.Save(m, ImageFormat.Jpeg);
                    ProfilePicture.Image = Image.FromStream(m);
                }
            }
        }
        private void LoadSizeResolution()
        {
            if (Properties.Settings.Default.Size.Width == 0) Properties.Settings.Default.Upgrade();
            if (Properties.Settings.Default.Size.Width == 0 || Properties.Settings.Default.Size.Height == 0)
            {
                this.Size = new Size(1374, 749);
                this.WindowState = FormWindowState.Normal;
                this.Location = new Point(100, 70);
            }
            else
            {
                if (this.WindowState == FormWindowState.Minimized)
                {
                    this.WindowState = FormWindowState.Normal;
                }
                this.WindowState = Properties.Settings.Default.State;
                this.Location = Properties.Settings.Default.Location;
                this.Size = Properties.Settings.Default.Size;
                ToogleDarkMode(Properties.Settings.Default.IsDark);
            }
        }
        private void SaveSizeRosolution()
        {
            Properties.Settings.Default.State = this.WindowState;
            if (this.WindowState == FormWindowState.Normal)
            {
                Properties.Settings.Default.Location = this.Location;
                Properties.Settings.Default.Size = this.Size;
            }
            else
            {
                Properties.Settings.Default.Location = this.RestoreBounds.Location;
                Properties.Settings.Default.Size = this.RestoreBounds.Size;
            }
            Properties.Settings.Default.IsDark = GlobalConfiguration.IsDark;
            Properties.Settings.Default.Save();
        }
        private void ToogleDarkMode(Boolean isDark)
        {
            GlobalConfiguration.IsDark = isDark;
            GlobalConfiguration.UseImmersiveDarkMode(Handle, isDark);
            if (isDark)
            {
                this.BackColor = Color.FromArgb(31, 31, 31);
                //this.BackColor = Color.Black;
                this.ToogleDarkModeButton.IconChar = FontAwesome.Sharp.IconChar.ToggleOn;
                this.ToogleDarkModeButton.IconColor = Color.White;
                this.ToogleDarkModeButton.ForeColor = Color.White;
                this.TitleLabel.ForeColor = Color.White;
                this.HomeButton.ForeColor = Color.White;
                this.ManageButton.ForeColor = Color.White;
                this.ReportsButton.ForeColor = Color.White;
                this.LibraryButton.ForeColor = Color.White;
                this.LogoutButton.ForeColor = Color.White;
                this.DateTimeStatusLabel.ForeColor = Color.White;
                this.DateTimeStatus.ForeColor = Color.White;
            }
            else
            {
                this.BackColor = Color.White;
                this.ToogleDarkModeButton.IconChar = FontAwesome.Sharp.IconChar.ToggleOff;
                this.ToogleDarkModeButton.IconColor = Color.Black;
                this.ToogleDarkModeButton.ForeColor = Color.Black;
                this.TitleLabel.ForeColor = Color.Black;
                this.HomeButton.ForeColor = Color.Black;
                this.ManageButton.ForeColor = Color.Black;
                this.ReportsButton.ForeColor = Color.Black;
                this.LibraryButton.ForeColor = Color.Black;
                this.LogoutButton.ForeColor = Color.Black;
                this.DateTimeStatusLabel.ForeColor = Color.Black;
                this.DateTimeStatus.ForeColor = Color.Black;
            }
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                this.WindowState = FormWindowState.Normal;
            }
            this.Refresh();
        }
        private void ToogleDarkModeButton_Click(object sender, EventArgs e)
        {
            ToogleDarkMode(!GlobalConfiguration.IsDark);
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveSizeRosolution();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadSizeResolution();
        }
        #endregion
        private static Bitmap ResizeImage(Bitmap imgToResize, Size destinationSize)
        {
            var originalWidth = imgToResize.Width;
            var originalHeight = imgToResize.Height;
            //how many units are there to make the original length
            var hRatio = (float)originalHeight / destinationSize.Height;
            var wRatio = (float)originalWidth / destinationSize.Width;
            //get the shorter side
            var ratio = Math.Min(hRatio, wRatio);
            var hScale = Convert.ToInt32(destinationSize.Height * ratio);
            var wScale = Convert.ToInt32(destinationSize.Width * ratio);
            //start cropping from the center
            var startX = (originalWidth - wScale) / 2;
            var startY = (originalHeight - hScale) / 2;
            //crop the image from the specified location and size
            var sourceRectangle = new Rectangle(startX, startY, wScale, hScale);
            //the future size of the image
            var bitmap = new Bitmap(destinationSize.Width, destinationSize.Height);
            //fill-in the whole bitmap
            var destinationRectangle = new Rectangle(0, 0, bitmap.Width, bitmap.Height);
            //generate the new image
            using (var g = Graphics.FromImage(bitmap))
            {
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                g.DrawImage(imgToResize, destinationRectangle, sourceRectangle, GraphicsUnit.Pixel);
            }
            return bitmap;
        }
        private void ProfilePicture_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "JPG files(.*jpg)|*.jpg|PNG files(.*png)|*.png|All Files(*.*)|*.*";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    string imageLocation = dialog.FileName;
                    Image img = Image.FromFile(imageLocation);
                    Bitmap b = new Bitmap(img);
                    using (Bitmap bmp = ResizeImage(b, new Size(76, 76)))
                    {
                        MemoryStream m = new MemoryStream();
                        bmp.Save(m, ImageFormat.Jpeg);
                        ProfilePicture.Image = Image.FromStream(m);
                    }
                    using (Bitmap bmp = (Bitmap)ProfilePicture.Image.Clone())
                    {
                        bmp.Save("./EIS.picture",bmp.RawFormat);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured while uploading an image:\n"+ex,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }
        private void TimeTimer_Tick(object sender, EventArgs e)
        {
            DateTimeStatus.Text = DateTime.Now.ToString();
        }
        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            MainPanel.Controls.Add(childForm);
            MainPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.BackColor = Color.White;
            if(GlobalConfiguration.IsDark) childForm.BackColor = Color.FromArgb(31, 31, 31);
            childForm.Show();
            TitleLabel.Text = childForm.Text;
        }
        private void HomeButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new HomeForm());
        }

        private void ManageButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new ManageEmployeesForm());
        }

        private void ReportsButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            OpenChildForm(new ReportsForm());
        }

        private void LibraryButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            OpenChildForm(new LibraryForm());
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This functionality will be added soon. Please contact the administrator for more queries.","Maintenance",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
