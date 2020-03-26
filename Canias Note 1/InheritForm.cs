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
    public partial class InheritForm : Form
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

        #region Definitions

        FormStatusLayer FSL = new FormStatusLayer();

        #endregion

        public InheritForm()
        {
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, 20, 20));
            InitializeComponent();
        }

        private void PicClose_Click(object sender, EventArgs e)
        {
            FSL.FormClose(this);
        }
    }
}
