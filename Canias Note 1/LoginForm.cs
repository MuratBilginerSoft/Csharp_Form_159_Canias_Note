using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GistwayZenon;
using System.Runtime.InteropServices;

namespace Canias_Note_1
{
    public partial class LoginForm : Form
    {

        #region DLL Import

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        #region For Oval Shape Form

        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        #endregion

        #endregion

        #region Parameters

        int Result = 0;

        int X1, X2, X3, X4, X5, X6, Y1, Y2, Y3, Y4, Y5, Y6 ;

        string UserName, Password;

        string P1;

        static public string PersonelNo, Names, LastName, Authority1, Picture;

        #endregion

        #region Definitions

        FormStatusLayer FSL = new FormStatusLayer();
        ObjectColor OC = new ObjectColor();
        ObjectSize OS = new ObjectSize();
        ObjectLocation OL = new ObjectLocation();

        DataAccessLayer DAL = new DataAccessLayer();
        ObjectText OT = new ObjectText();

        #endregion

        #region Methods 

        #endregion

        public LoginForm()
        {
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, 25, 25));
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            TimerSaat.Start();
        }

        private void TimerSaat_Tick(object sender, EventArgs e)
        {
            LblSaat.Text = DateTime.Now.ToLongTimeString();
            LblTarih.Text = DateTime.Now.ToLongDateString();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            UserName = TextUserName.Text;
            Password = TextPassword.Text;

            Result = 0;

            Result = int.Parse(DAL.LoginData(UserName, Password, ref P1));

            DAL.AdminInfo(UserName, Password, ref PersonelNo, ref Names, ref LastName, ref Authority1, ref Picture);

            if (Result > 0)
            {
                TimerSaat.Stop();

                MainForm MainForm = new MainForm();

                FSL.FormShowAndHide(this, MainForm);
            }

            else
            {
                OC.ObjectXChangeColor(PnlFooter, Color.DeepSkyBlue);
                OT.ObjectTextChangedX(LblStatus, "Kullanıcı Adınız veya Şifreniz Yanlıştır");
            }

        }

        private void LoginForm_Shown(object sender, EventArgs e)
        {


            X1 = PicClose.Size.Width;
            Y1 = PicClose.Size.Height;

            X2 = PicMinus.Size.Width;
            Y2 = PicMinus.Size.Height;


            X4 = PicClose.Location.X;
            Y4 = PicClose.Location.Y;

            X5 = PicMinus.Location.X;
            Y5 = PicMinus.Location.Y;
        }

        private void PicClose_Click(object sender, EventArgs e)
        {
            FSL.FormClose(this);
        }

        private void PicMinus_Click(object sender, EventArgs e)
        {


            
            FSL.FormMinimize(this);
            
           
        }

        private void PicEye_MouseHover(object sender, EventArgs e)
        {
            TextPassword.PasswordChar = '\0';
            OC.ObjectXChangeColor((PictureBox)sender, Color.Yellow);
        }

        private void PicEye_MouseLeave(object sender, EventArgs e)
        {
            TextPassword.PasswordChar = '*';
            OC.ObjectXNormalChange((PictureBox)sender, Color.White);
        }

        private void PicClose_MouseHover(object sender, EventArgs e)
        {
            
            OS.ObjectChangeSizeX((PictureBox)sender, X1 + 2, Y1 + 2);
            OL.ObjectChangeLocationX((PictureBox)sender, X4 - 2, Y4 + 2);
        }

        private void PicClose_MouseLeave(object sender, EventArgs e)
        {
            OS.ObjectNormalSizeX((PictureBox)sender, X1, Y1);
            OL.ObjactNormalLocationX((PictureBox)sender, X4, Y4);
        }

        private void PicMinus_MouseHover(object sender, EventArgs e)
        {
            OS.ObjectChangeSizeX((PictureBox)sender, X2 + 2, Y2 + 2);
            OL.ObjectChangeLocationX((PictureBox)sender, X5 - 2, Y5 + 2);
        }

        private void PicMinus_MouseLeave(object sender, EventArgs e)
        {
            OS.ObjectNormalSizeX((PictureBox)sender, X2, Y2);
            OL.ObjactNormalLocationX((PictureBox)sender, X5, Y5);
        }

        private void TextUserName_TextChanged(object sender, EventArgs e)
        {
            OC.ObjectXChangeColor(PnlFooter, Color.Transparent);
            OT.ObjectTextChangedX(LblStatus, "Status");
        }
    }
}
