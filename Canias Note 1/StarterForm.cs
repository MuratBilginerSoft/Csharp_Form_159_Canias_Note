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

namespace Canias_Note_1
{
    public partial class StarterForm : Form
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

        int Index1 = 0; // Nokta Animasyonu Index Sayacı
        int Index2 = 0; // Formun Açık Kalma Sürecini Belirleyen Sayaç
        int Index3 = 0; // Form Artan Sayaç
        #endregion

        #region Definitions

        Random r = new Random();

        #endregion

        public StarterForm()
        {
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, 520, 325, 20, 20));

            InitializeComponent();
        }

        private void StarterForm_Load(object sender, EventArgs e)
        {
            Index2 = r.Next(17, 45);
            TimerSayaç.Start();
        }

        private void TimerSayaç_Tick(object sender, EventArgs e)
        {
            if (Index3<Index2)
            {
                Index3++;

                #region Point Animation

                Index1++;

                if (Index1 < 6)
                {
                    switch (Index1)
                    {
                        case 1: { LblNokta1.Visible = true; break; }

                        case 2: { LblNokta2.Visible = true; break; }

                        case 3: { LblNokta3.Visible = true; break; }

                        case 4: { LblNokta4.Visible = true; break; }

                        case 5: { LblNokta5.Visible = true; break; }

                    }

                }

                else if (Index1 < 17)
                {
                    TimerSayaç.Interval = 150;

                    LblNokta5.Location = new Point(LblNokta5.Location.X + 30, 275);
                    LblNokta4.Location = new Point(LblNokta4.Location.X + 30, 275);
                    LblNokta3.Location = new Point(LblNokta3.Location.X + 30, 275);
                    LblNokta2.Location = new Point(LblNokta2.Location.X + 30, 275);
                    LblNokta1.Location = new Point(LblNokta1.Location.X + 30, 275);
                }

                else if (Index1 < 22)
                {
                    TimerSayaç.Interval = 250;

                    switch (Index1)
                    {
                        case 17: { LblNokta1.Visible = false; break; }

                        case 18: { LblNokta2.Visible = false; break; }

                        case 19: { LblNokta3.Visible = false; break; }

                        case 20: { LblNokta4.Visible = false; break; }

                        case 21:

                            {
                                LblNokta5.Visible = false;

                                Index1 = 0;

                                LblNokta1.Location = new Point(10, 275);
                                LblNokta2.Location = new Point(45, 275);
                                LblNokta3.Location = new Point(80, 275);
                                LblNokta4.Location = new Point(115, 275);
                                LblNokta5.Location = new Point(140, 275);

                                break;
                            }
                    }
                }

                #endregion
            }

            else
            {
                this.Close();
            }
       
        }

        
    }
}
