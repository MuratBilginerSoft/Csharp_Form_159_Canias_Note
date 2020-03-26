using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using GistwayZenon;

namespace Canias_Note_1
{
    public partial class MainForm : Form
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

        int X1, X2, X3, X4, X5, X6, Y1, Y2, Y3, Y4, Y5, Y6;

        int Saat = 0;

       

        #endregion

        #region Definitions

        FormStatusLayer FSL = new FormStatusLayer();
        ObjectColor OC = new ObjectColor();
        ObjectSize OS = new ObjectSize();
        ObjectLocation OL = new ObjectLocation();
        DataAccessLayer DAL = new DataAccessLayer();
        ObjectText OT = new ObjectText();
        FormInPanelOpen FIPO = new FormInPanelOpen();

        #endregion

        #region Methods

        #endregion

        private void MainForm_Shown(object sender, EventArgs e)
        {
            TimerSaat.Start();
            X1 = PicClose.Size.Width;
            Y1 = PicClose.Size.Height;

            X2 = PicMinus.Size.Width;
            Y2 = PicMinus.Size.Height;


            X4 = PicClose.Location.X;
            Y4 = PicClose.Location.Y;

            X5 = PicMinus.Location.X;
            Y5 = PicMinus.Location.Y;
        }

        private void PanelTransaction_Click(object sender, EventArgs e)
        {
            TransactionForm TransactionFormX = new TransactionForm();
            FIPO.FormInPanelOpenX(PanelBody, TransactionFormX);
        }

        private void PanelClass_Click(object sender, EventArgs e)
        {
            ClassForm ClassFormX = new ClassForm();
            FIPO.FormInPanelOpenX(PanelBody, ClassFormX);
        }

        private void PanelDialog_Click(object sender, EventArgs e)
        {
            DialogForm DialogFormX = new DialogForm();
            FIPO.FormInPanelOpenX(PanelBody, DialogFormX);
        }

        private void PanelTable_Click(object sender, EventArgs e)
        {
            TableForm TableFormX = new TableForm();
            FIPO.FormInPanelOpenX(PanelBody, TableFormX);
        }

        private void PanelCollaber_Click(object sender, EventArgs e)
        {
            CollaberForm CollaberFormX = new CollaberForm();
            FIPO.FormInPanelOpenX(PanelBody, CollaberFormX);
        }

        private void PanelGeneral_Click(object sender, EventArgs e)
        {
            GeneralForm GeneralFormX = new GeneralForm();
            FIPO.FormInPanelOpenX(PanelBody, GeneralFormX);
        }

        private void PanelSettings_Click(object sender, EventArgs e)
        {
            SettingsForm SettingsFormX = new SettingsForm();
            FIPO.FormInPanelOpenX(PanelBody, SettingsFormX);
        }

        private void PanelHelp_Click(object sender, EventArgs e)
        {
            HelpForm HelpFormX = new HelpForm();
            FIPO.FormInPanelOpenX(PanelBody, HelpFormX);
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

        private void TimerSaat_Tick(object sender, EventArgs e)
        {
            LblSaat.Text = DateTime.Now.ToLongTimeString();
        }

        private void LblSaat_Click(object sender, EventArgs e)
        {
            Saat++;

            if (Saat == 1)
            {
                OC.ObjectXChangeForeColor(LblSaat, Color.Yellow);
            }

            else if (Saat == 2)
            {
                OC.ObjectXChangeForeColor(LblSaat, Color.SeaGreen);
            }

            else if (Saat == 3)
            {
                OC.ObjectXChangeForeColor(LblSaat, Color.DeepSkyBlue);
            }

            else if (Saat == 4)
            {
                OC.ObjectXChangeForeColor(LblSaat, Color.Pink);
            }

            else if (Saat == 5)
            {
                OC.ObjectXChangeForeColor(LblSaat, Color.Lavender);
            }

            else
            {
                OC.ObjectXChangeForeColor(LblSaat, Color.White);
                Saat = 0;
            }
        }

        public MainForm()
        {
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, 25, 25));
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            PicProfil.Image = Image.FromFile(LoginForm.Picture);
            LblUserName.Text = LoginForm.Names + " " + LoginForm.LastName;

            if (LoginForm.Authority1 == "0")
            {
                LblUserName.Text += " (Manager)";
            }

            else
            {
                LblUserName.Text += " (User)";
            }
        }

        private void PanelHome_Click(object sender, EventArgs e)
        {
            HomeForm HomeFormX = new HomeForm();
            FIPO.FormInPanelOpenX(PanelBody, HomeFormX);
        }

        private void PicClose_Click(object sender, EventArgs e)
        {
            FSL.FormClose(this);
        }

        private void PicMinus_Click(object sender, EventArgs e)
        {
            FSL.FormMinimize(this);
        }
    }
}
