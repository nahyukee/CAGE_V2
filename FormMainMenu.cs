using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace WorkoutApp
{
    public partial class FormMainMenu : Form
    {
        #region Rounded edges
        //Rounded edges
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );
        #endregion

        #region Fields
        //Fields
        private IconButton currentBtn;
        private readonly Panel leftBorderBtn;
        private Form currentChildForm;
        #endregion

        #region Constructor
        //Constructor
        public FormMainMenu()
        {

            InitializeComponent();
            //Rounded edges 2 lines
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            leftBorderBtn = new Panel
            {
                Size = new Size(7, 60)
            };
            panelMenu.Controls.Add(leftBorderBtn);
            //Form place empty strong and activate double buffer to reduce flickering
            //removes the top form box
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            //Sets maximum size limits for taskbar
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
                        
        }
        #endregion

        #region Structs
        //Structs
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(158, 230, 169);
            public static Color color2 = Color.FromArgb(183, 241, 66);
            public static Color color3 = Color.FromArgb(255, 71, 71);
            
        }
        #endregion

        #region Button Animation
        
        private void ActivateButton(object senderBtn, Color color) //highlights active button
        {
            if (senderBtn != null)
            {
                DisableButton();
                //keeping button same, changing background and text color, align text to center
                currentBtn = (IconButton)senderBtn;
                //Changing color while clicking
                currentBtn.BackColor = Color.FromArgb(35, 35, 43);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                //left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //Icon Current Child Form
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;
            }
        }
        
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(35, 35, 43);
                currentBtn.ForeColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.White;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        #endregion

        #region Opens Child form
        //only one form at a time, if you want to open multiple forms then delete this
        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm !=null)
            {
                currentChildForm.Close();
            }
            else
            {
                //donothing
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitleChildForm.Text = childForm.Text;
            
        }
        #endregion

        #region Btn Clicks
        private void BtnUserinfo_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new FormUserInfo());
        }

      

        private void BtnWorkouts_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new FormWorkouts());
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            currentChildForm.Close();
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.White;
            lblTitleChildForm.Text = "Home";
        }

        #endregion

        #region Drag form
        //Drag Form (using System.Runtime.InteropServices;)
        //import services library which allows us to use the native libraries of the operating system)
        //allows you to move the form

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        
        private void PanelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            //invokes the Dll methods
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        #region Minimize button
        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        #endregion

        

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        
        private void Main_Load(object sender, EventArgs e)
        {
            

        }





        #region Maximize button not utilized
        /*#region Maximize button
        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }
        #endregion
        */
        #endregion
    }

}
