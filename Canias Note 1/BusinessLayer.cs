using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GistwayZenon;
using System.Drawing;

namespace Canias_Note_1
{
    public class BusinessLayer
    {

        public void FormOpen(Form FormC, Form FormO)
        {
            FormC.Hide();
            FormO.ShowDialog();
            FormC.Show();
        }

        public void GetScript(string GS1, string GS2, string GS3, RichTextBox RTB1, RichTextBox RTB2, RichTextBox RTB3)
        {
            GS1 = RTB1.Text;
            GS2 = RTB2.Text;
            GS3 = RTB3.Text;
        }

        public void RichClear(RichTextBox RTB1, RichTextBox RTB2, RichTextBox RTB3)
        {
            RTB1.Clear();
            RTB2.Clear();
            RTB3.Clear();
        }

        public void GetFullNames(string Script1, string Script2, string Script3, string Script4, string Script5, string Script6)
        {
            Variables.GFNIAS602 = Script1.Split(';');
            Variables.GFNALP602 = Script2.Split(';');
            Variables.GFNIAS604 = Script3.Split(';');
            Variables.GFNLIAS602 = Script4.Split(';');
            Variables.GFNLALP602 = Script5.Split(';');
            Variables.GFNLIAS604 = Script6.Split(';');
        }

        public void CheckControl(CheckBox CHK2)
        {
            CHK2.Visible = true;
        }

        public void CheckControl2(CheckBox CHK2)
        {
            CHK2.Visible = false;
        }

        public void ButtonColor1(PictureBox Pic)
        {
            Pic.BackColor = Color.DarkGray;
        }

        public void ButtonColor2(PictureBox Pic)
        {
            Pic.BackColor = Color.Transparent;
        }

    }
}
