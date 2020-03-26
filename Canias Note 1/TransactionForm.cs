using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Canias_Note_1
{
    public partial class TransactionForm : Canias_Note_1.InheritForm
    {
        #region Parameters

        public static string TransactionName, StartDialog, Modul, CreatedBy, ChangedBy;

        public static int Modi = 0;

        private void PicSearch_Click(object sender, EventArgs e)
        {
            GridTransactionInfo.DataSource = DAL.TransactionInfo(GridTransactionInfo).DataSource;
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            string TransactionName = TextTransactionName1.Text;
            string Açıklama = RichAciklama.Text;
            int Sebep = 0;

            if (RadioDurum.Checked==true)
            {
                Sebep = 1;
            }

            else
            {
                Sebep = 0;
            }

            DateTime Date = DateTime.Now;

            string GirişYap = LoginForm.PersonelNo;

            DAL.Transaction2Add(TransactionName, Açıklama, Sebep, Date, GirişYap);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string TransactionName = TextTransactionName2.Text;
            string GirişYap = LoginForm.PersonelNo;

            DAL.Transaction2Select(TransactionName, GirişYap, GridTransaction);
        }


        #endregion

        #region Methods

        public void OnSearch()
        {
            int j = 0;

            foreach (char item in TextTransactionName.Text)
            {
                if (item == '%')
                {
                    TransactionName = TextTransactionName.Text;
                    j++;
                    break;
                }
            }

            if (j == 0)
            {
                if (TextTransactionName.Text == "") TransactionName = "%";

                else TransactionName = "%" + TextTransactionName.Text + "%";

            }

            j = 0;

            foreach (char item in TextStartDialog.Text)
            {
                if (item == '%')
                {
                    StartDialog = TextStartDialog.Text;
                    j++;
                    break;
                }
            }

            if (j == 0)
            {
                if (TextStartDialog.Text == "") StartDialog = "%";

                else StartDialog = "%" + TextStartDialog.Text + "%";

            }

            j = 0;

            foreach (char item in TextModul.Text)
            {
                if (item == '%')
                {
                    Modul = TextModul.Text;
                    j++;
                    break;
                }
            }

            if (j == 0)
            {
                if (TextModul.Text == "") Modul = "%";

                else Modul = "%" + TextModul.Text + "%";

            }

            j = 0;

            foreach (char item in TextCreatedBy.Text)
            {
                if (item == '%')
                {
                    CreatedBy = TextCreatedBy.Text;
                    j++;
                    break;
                }
            }

            if (j == 0)
            {
                if (TextCreatedBy.Text == "") CreatedBy = "%";

                else CreatedBy = "%" + TextCreatedBy.Text + "%";

            }

            j = 0;

            foreach (char item in TextChangedBy.Text)
            {
                if (item == '%')
                {
                    ChangedBy = TextChangedBy.Text;
                    j++;
                    break;
                }
            }

            if (j == 0)
            {
                if (TextChangedBy.Text == "") ChangedBy = "%";

                else ChangedBy = "%" + TextChangedBy.Text + "%";

            }

            GridTransactionInfo.DataSource = DAL.TransactionInfo2(TransactionName, StartDialog, Modul, CreatedBy, ChangedBy, GridTransactionInfo).DataSource;

        }

        #endregion

        #region Definition

        DataAccessLayer DAL = new DataAccessLayer();


        #endregion

        public TransactionForm()
        {
            InitializeComponent();
        }

        private void TextTransactionName_TextChanged(object sender, EventArgs e)
        {
            OnSearch();
        }
    }
}
