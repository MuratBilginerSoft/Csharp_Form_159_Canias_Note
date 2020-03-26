using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Canias_Note_1
{
    public class DataAccessLayer
    {
        #region Database Tanımlama

        CANIASNOTEXENDataContext CNDB = new CANIASNOTEXENDataContext();

        #endregion

        #region Select Process

        public string LoginData(string X1, string X2, ref string X3)
        {
            CNDB.SP_LoginData(X1, X2, ref X3).ToString();
            return X3;
        }


        public void AdminInfo(string X1, string X2, ref string X3, ref string X4, ref string X5, ref string X6, ref string X7)
        {
            CNDB.SP_UserPicture(X1, X2, ref X3, ref X4, ref X5, ref X6, ref X7);
        }

        public DataGridView TransactionInfo2(string X1, string X2, string X3, string X4, string X5, DataGridView DGV)
        {
            DGV.DataSource = CNDB.SP_TransactionInfo2(X1, X2, X3, X4, X5);
            return DGV;
        }

        public DataGridView TransactionInfo(DataGridView DGV)
        {
            DGV.DataSource = CNDB.SP_TransactionInfo();
            return DGV;

        }

        public void Transaction2Add(string X1, string X2, int X3, DateTime X4, string X5)
        {
            CNDB.SP_Transaction2Add(X1, X2, X3, X4, X5);
        }

        public void Transaction2Select(string X1, string X2, DataGridView DGV)
        {
            DGV.DataSource = CNDB.SP_Transaction2Select(X1, X2);

        }
        #endregion



    }
}
