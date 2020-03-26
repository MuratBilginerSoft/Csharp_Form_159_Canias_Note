using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Canias_Note_1
{
    public partial class CollaberForm : Canias_Note_1.InheritForm
    {
        #region Definitions

        BusinessLayer BL = new BusinessLayer();

        #endregion

        #region Values

        string Script1, Script2, Script3, Script4, Script5, Script6; // Kullanıcıdan alınan Scriptleri aldığımız değişkenler.

        int Page = 0;

        int index1 = 0, index2 = 0, index3 = 0;

        int Status = 0;

        public string[] GFNIAS602 = new string[100]; // GFN: Get Full Names
        public string[] GFNALP602 = new string[100];
        public string[] GFNIAS604 = new string[100];

        string[] GNIAS602 = new string[100];  // GN: Get Names
        string[] GNALP602 = new string[100];
        string[] GNIAS604 = new string[100];

        string[] CIAS602 = new string[100];   // C: Compare
        string[] CALP602 = new string[100];
        string[] CIAS604 = new string[100];

        string[] LNEIAS602 = new string[100]; // 
        string[] LNEALP602 = new string[100];
        string[] LNEIAS604 = new string[100];

        string[] CNEIAS602 = new string[100]; // CNE: Column Name Edit
        string[] CNEALP602 = new string[100];
        string[] CNEIAS604 = new string[100];

        string[] GLNIAS602 = new string[100]; // 
        string[] GLNALP602 = new string[100];
        string[] GLNIAS604 = new string[100];

        string[] LIAS602 = new string[100];
        string[] LALP602 = new string[100];
        string[] LIAS604 = new string[100];

        #endregion

        #region Methods

        #endregion

        public CollaberForm()
        {
            InitializeComponent();
        }

        private void CollaberForm_Load(object sender, EventArgs e)
        {

            #region Status Belirleme

            this.BackColor = Color.Teal;
            BL.CheckControl(NumberCheck);
            LblExplanation.Text = "Get Column Full Names";

            #endregion
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            /* BL.GetScript(Script1, Script2, Script3, RichIAS602, RichALP602, RichIAS604); */

            #region Get Value

            Script1 = RichIAS602.Text;
            Script2 = RichALP602.Text;
            Script3 = RichIAS604.Text;

            Script4 = RichIAS602L.Text;
            Script5 = RichALP602L.Text;
            Script6 = RichIAS604L.Text;

            #endregion

            #region Get Full Names

            if (Status == 1 || Status == 6)
            {
                index1 = 0;

                BL.RichClear(RichIAS602S, RichALP602S, RichIAS604S);

                BL.GetFullNames(Script1, Script2, Script3, Script4, Script5, Script6);

                #region Get Column Full Names

                if (Status == 1)
                {
                    foreach (string item in Variables.GFNIAS602)
                    {
                        if (NumberCheck.Checked == true)
                        {
                            index1++;
                            RichIAS602S.Text += index1 + " " + item + "\n";
                        }

                        else
                        {
                            RichIAS602S.Text += item + "\n";
                        }
                    }

                    index1 = 0;

                    foreach (string item in Variables.GFNALP602)
                    {
                        if (NumberCheck.Checked == true)
                        {
                            index1++;
                            RichALP602S.Text += index1 + " " + item + "\n";
                        }

                        else
                        {
                            RichALP602S.Text += item + "\n";
                        }
                    }

                    index1 = 0;

                    foreach (string item in Variables.GFNIAS604)
                    {
                        if (NumberCheck.Checked == true)
                        {
                            index1++;
                            RichIAS604S.Text += index1 + " " + item + "\n";
                        }

                        else
                        {
                            RichIAS604S.Text += item + "\n";
                        }
                    }
                }

                #endregion

                #region Get Label Full Names

                else if (Status == 6)
                {
                    foreach (string item in Variables.GFNLIAS602)
                    {
                        if (NumberCheck.Checked == true)
                        {
                            index1++;
                            RichIAS602S.Text += index1 + " " + item + "\n";
                        }

                        else
                        {
                            RichIAS602S.Text += item + "\n";
                        }
                    }

                    index1 = 0;

                    foreach (string item in Variables.GFNLALP602)
                    {
                        if (NumberCheck.Checked == true)
                        {
                            index1++;
                            RichALP602S.Text += index1 + " " + item + "\n";
                        }

                        else
                        {
                            RichALP602S.Text += item + "\n";
                        }
                    }

                    index1 = 0;

                    foreach (string item in Variables.GFNLIAS604)
                    {
                        if (NumberCheck.Checked == true)
                        {
                            index1++;
                            RichIAS604S.Text += index1 + " " + item + "\n";
                        }

                        else
                        {
                            RichIAS604S.Text += item + "\n";
                        }
                    }
                }

                #endregion

            }

            #endregion

            #region Get Names

            else if (Status == 2 || Status == 7)
            {
                index1 = 0;

                BL.RichClear(RichIAS602S, RichALP602S, RichIAS604S);

                BL.GetFullNames(Script1, Script2, Script3, Script4, Script5, Script6);

                #region Get Column Name

                if (Status == 2)
                {
                    for (int i = 0; i < Variables.GFNIAS602.Length; i++)
                    {
                        index1++;

                        GNIAS602 = Variables.GFNIAS602[i].Split(',');
                        RichIAS602S.Text += index1 + " " + GNIAS602[0] + "\n";

                    }

                    index1 = 0;

                    for (int i = 0; i < Variables.GFNALP602.Length; i++)
                    {
                        index1++;
                        GNALP602 = Variables.GFNALP602[i].Split(',');
                        RichALP602S.Text += index1 + " " + GNALP602[0] + "\n";

                    }

                    index1 = 0;

                    for (int i = 0; i < Variables.GFNIAS604.Length; i++)
                    {
                        index1++;
                        GNIAS604 = Variables.GFNIAS604[i].Split(',');
                        RichIAS604S.Text += index1 + " " + GNIAS604[0] + "\n";
                    }
                }

                #endregion

                #region Get Label Names

                else if (Status == 7)
                {
                    for (int i = 0; i < Variables.GFNLIAS602.Length; i++)
                    {
                        index1++;

                        GLNIAS602 = Variables.GFNLIAS602[i].Split(',');
                        RichIAS602S.Text += index1 + " " + GLNIAS602[0] + "\n";

                    }

                    index1 = 0;

                    for (int i = 0; i < Variables.GFNLALP602.Length; i++)
                    {
                        index1++;
                        GLNALP602 = Variables.GFNLALP602[i].Split(',');
                        RichALP602S.Text += index1 + " " + GLNALP602[0] + "\n";

                    }

                    index1 = 0;

                    for (int i = 0; i < Variables.GFNLIAS604.Length; i++)
                    {
                        index1++;
                        GLNIAS604 = Variables.GFNLIAS604[i].Split(',');
                        RichIAS604S.Text += index1 + " " + GLNIAS604[0] + "\n";
                    }
                }

                #endregion

            }

            #endregion

            #region Compare
            else if (Status == 5)
            {
                index1 = 0;

                BL.RichClear(RichIAS602S, RichALP602S, RichIAS604S);

                BL.GetFullNames(Script1, Script2, Script3, Script4, Script5, Script6);

                Array.Resize(ref CIAS602, Variables.GFNIAS602.Length);
                Array.Resize(ref CALP602, Variables.GFNALP602.Length);
                Array.Resize(ref CIAS604, Variables.GFNIAS604.Length);

                for (int i = 0; i < Variables.GFNIAS602.Length; i++)
                {
                    GNIAS602 = Variables.GFNIAS602[i].Split(',');
                    CIAS602[i] = GNIAS602[0];
                }

                for (int i = 0; i < Variables.GFNALP602.Length; i++)
                {
                    GNALP602 = Variables.GFNALP602[i].Split(',');
                    CALP602[i] = GNALP602[0];
                }

                for (int i = 0; i < Variables.GFNIAS604.Length; i++)
                {
                    GNIAS604 = Variables.GFNIAS604[i].Split(',');
                    CIAS604[i] = GNIAS604[0];
                }




                RichALP602S.Text = "ALP 602 İLE IAS 602 ARASINDAKİ FARKLAR \n";

                foreach (string item in CALP602)
                {
                    index2 = 0;

                    for (int i = 0; i < CIAS602.Length; i++)
                    {
                        if (item == CIAS602[i].Trim())
                        {
                            index2++;
                            break;
                        }
                    }

                    if (index2 == 0)
                    {
                        RichALP602S.Text += item + "\n";
                    }
                }

                RichALP602S.Text += " \nIAS 604 İLE IAS 602 ARASINDAKİ FARKLAR \n";

                foreach (string item in CIAS604)
                {
                    index2 = 0;

                    for (int i = 0; i < CIAS602.Length; i++)
                    {
                        if (item == CIAS602[i].Trim())
                        {
                            index2++;
                            break;
                        }
                    }

                    if (index2 == 0)
                    {
                        RichALP602S.Text += item + "\n";
                    }
                }


                RichIAS604S.Text = "IAS 604 İLE ALP 602 ARASINDAKİ FARKLAR \n";

                foreach (string item in CIAS604)
                {
                    index2 = 0;

                    for (int i = 0; i < CALP602.Length; i++)
                    {
                        if (item == CALP602[i].Trim())
                        {
                            index2++;
                            break;
                        }
                    }

                    if (index2 == 0)
                    {
                        RichIAS604S.Text += item + "\n";
                    }
                }

                RichIAS604S.Text += "\nALP 602 İLE IAS 604 ARASINDAKİ FARKLAR \n";

                foreach (string item in CALP602)
                {
                    index2 = 0;

                    for (int i = 0; i < CIAS604.Length; i++)
                    {
                        if (item == CIAS604[i].Trim())
                        {
                            index2++;
                            break;
                        }
                    }

                    if (index2 == 0)
                    {
                        RichIAS604S.Text += item + "\n";
                    }
                }
            }

            else if (Status == 8)
            {


            }

            #endregion

            #region Column Name Edit

            else if (Status == 3)
            {
                BL.RichClear(RichIAS602S, RichALP602S, RichIAS604S);

                BL.GetFullNames(Script1, Script2, Script3, Script4, Script5, Script6);

                Array.Resize(ref CIAS602, Variables.GFNIAS602.Length);
                Array.Resize(ref CALP602, Variables.GFNALP602.Length);
                Array.Resize(ref CIAS604, Variables.GFNIAS604.Length);

                for (int i = 0; i < Variables.GFNIAS602.Length; i++)
                {
                    GNIAS602 = Variables.GFNIAS602[i].Split(',');
                    CIAS602[i] = GNIAS602[0];
                }

                for (int i = 0; i < Variables.GFNALP602.Length; i++)
                {
                    GNALP602 = Variables.GFNALP602[i].Split(',');
                    CALP602[i] = GNALP602[0];
                }

                for (int i = 0; i < Variables.GFNIAS604.Length; i++)
                {
                    GNIAS604 = Variables.GFNIAS604[i].Split(',');
                    CIAS604[i] = GNIAS604[0];
                }

                index3 = 0;

                foreach (string item in CALP602)
                {
                    index2 = 0;

                    for (int i = 0; i < CIAS604.Length; i++)
                    {
                        if (item == CIAS604[i].Trim())
                        {
                            index2++;
                            break;
                        }
                    }

                    Array.Resize(ref CNEIAS604, index3 + 1);

                    if (index2 == 0)
                    {
                        CNEIAS604[index3] = item;
                        index3++;
                    }
                }
                Array.Resize(ref CNEIAS604, index3);

                foreach (string item2 in CNEIAS604)
                {
                    for (int i = 0; i < Variables.GFNALP602.Length; i++)
                    {
                        if (item2 == Variables.GFNALP602[i].Substring(0, item2.Length))
                        {
                            Script3 += ";" + Variables.GFNALP602[i];
                            break;
                        }
                    }

                }

                RichScript.Clear();
                RichScript.Text = Script3;

                TabControl2.SelectedIndex = 1;
            }

            #endregion

            #region Label Info Edit

            else if (Status == 4)
            {
                index3 = 0;
                index1 = 0;

                BL.RichClear(RichIAS602S, RichALP602S, RichIAS604S);

                BL.GetFullNames(Script1, Script2, Script3, Script4, Script5, Script6);

                Array.Resize(ref CIAS602, Variables.GFNIAS602.Length);
                Array.Resize(ref CALP602, Variables.GFNALP602.Length);
                Array.Resize(ref CIAS604, Variables.GFNIAS604.Length);

                for (int i = 0; i < Variables.GFNIAS602.Length; i++)
                {
                    GNIAS602 = Variables.GFNIAS602[i].Split(',');
                    CIAS602[i] = GNIAS602[0];
                }

                for (int i = 0; i < Variables.GFNALP602.Length; i++)
                {
                    GNALP602 = Variables.GFNALP602[i].Split(',');
                    CALP602[i] = GNALP602[0];
                }

                for (int i = 0; i < Variables.GFNIAS604.Length; i++)
                {
                    GNIAS604 = Variables.GFNIAS604[i].Split(',');
                    CIAS604[i] = GNIAS604[0];
                }

                foreach (string item in CALP602)
                {
                    index2 = 0;

                    for (int i = 0; i < CIAS604.Length; i++)
                    {
                        if (item == CIAS604[i].Trim())
                        {
                            index2++;
                            break;
                        }
                    }

                    if (index2 == 0)
                    {
                        LIAS602[index3] = index3.ToString();
                        Script6 += ";" + Variables.GFNLALP602[int.Parse(LIAS602[index3])];
                    }

                    index3++;
                }

                RichScript.Clear();
                RichScript.Text = Script6;
                TabControl2.SelectedIndex = 1;
            }

            #endregion

            LblStatus.Text = "İşlem Tamamlandı";
        }

        private void CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Status = 1;
            LblExplanation.Text = "Get Column Full Names";
            this.BackColor = Color.Teal;
            BL.CheckControl(NumberCheck);
            TabControl2.SelectedIndex = 0;
        }

        private void LabelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Status = 6;
            LblExplanation.Text = "Get Label Full Names";
            this.BackColor = Color.Purple;
            BL.CheckControl(NumberCheck);
            TabControl2.SelectedIndex = 0;
        }

        private void ColumnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Status = 2;
            LblExplanation.Text = "Get Column Names";
            this.BackColor = Color.Orange;
            BL.CheckControl(NumberCheck);
            TabControl2.SelectedIndex = 0;
        }

        private void LabelToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Status = 7;
            LblExplanation.Text = "Get Label Names";
            this.BackColor = Color.Navy;
            BL.CheckControl(NumberCheck);
            TabControl2.SelectedIndex = 0;
        }

        private void ColumnInfoEditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Status = 3;
            LblExplanation.Text = "Column Info Edit";
            this.BackColor = Color.Green;
            BL.CheckControl(NumberCheck);
            TabControl2.SelectedIndex = 0;
        }

        private void PicGetScript4_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(RichScript.Text);
                LblStatus.Text = "Kopyalandı";
            }
            catch (Exception)
            {
                LblStatus.Text = "Kopyalanacak Alan Boş";
            }
        }

        private void LabelInfoEditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Status = 4;
            LblExplanation.Text = "Label Info Edit";
            this.BackColor = Color.Gray;
            BL.CheckControl(NumberCheck);
            TabControl2.SelectedIndex = 0;
        }

        private void CompareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Status = 5;
            LblExplanation.Text = "Column Name Compare";
            this.BackColor = Color.DarkCyan;
            BL.CheckControl2(NumberCheck);
            TabControl2.SelectedIndex = 0;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            #region Script RichTextleri temizle.

            if (Page == 0) RichIAS602.Clear();

            else if (Page == 1) RichALP602.Clear();

            else if (Page == 2) RichIAS604.Clear();

            else if (Page == 3) RichIAS602L.Clear();

            else if (Page == 4) RichALP602L.Clear();

            else if (Page == 5) RichIAS604L.Clear();

            #endregion
        }

        private void BtnPaste_Click(object sender, EventArgs e)
        {
            #region Richlere Yapıştırma İşlemi

            if (Page == 0) RichIAS602.Text += Clipboard.GetText();

            else if (Page == 1) RichALP602.Text += Clipboard.GetText();

            else if (Page == 2) RichIAS604.Text += Clipboard.GetText();

            else if (Page == 3) RichIAS602L.Text += Clipboard.GetText();

            else if (Page == 4) RichALP602L.Text += Clipboard.GetText();

            else if (Page == 5) RichIAS604L.Text += Clipboard.GetText();

            #endregion
        }

        private void PicIAS604P_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(RichIAS604S.Text);
                LblStatus.Text = "Kopyalandı";
            }
            catch (Exception)
            {
                LblStatus.Text = "Kopyalanacak Alan Boş";
            }
        }

        private void PicALP602P_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(RichALP602S.Text);
                LblStatus.Text = "Kopyalandı";
            }
            catch (Exception)
            {
                LblStatus.Text = "Kopyalanacak Alan Boş";
            }
        }

        private void PicIAS602P_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(RichIAS602S.Text);
                LblStatus.Text = "Kopyalandı";
            }
            catch (Exception)
            {
                LblStatus.Text = "Kopyalanacak Alan Boş";
            }
        }

       
    }
}
