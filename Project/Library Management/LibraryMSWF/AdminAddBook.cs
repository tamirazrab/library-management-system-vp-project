using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryMSWF.BL;

namespace LibraryMSWF {
    public partial class AdminAddBook : Form {
        public AdminAddBook () {
            InitializeComponent();
        }

        private void AUBtnAddBook_Click ( object sender , EventArgs e ) {
            if (AUTxtBookName.Text != string.Empty && AUTxtBookAuthorName.Text != string.Empty &&
                AUTxtBookISBN.Text != string.Empty && AUTxtBookPrice.Text != string.Empty &&
                AUTxtBookCopies.Text != string.Empty)
            {
                bool isDone = new BookBL().AddBookBL(AUTxtBookName.Text, AUTxtBookAuthorName.Text, AUTxtBookISBN.Text, double.Parse(AUTxtBookPrice.Text), int.Parse(AUTxtBookCopies.Text));

                if(isDone)
                    if(AUErrorEmptyNotification.Visible)
                        AUErrorEmptyNotification.Visible = false;
                    AUSuccessNotify.Visible = true;
                // else
                // todo: If somehow data is not stored in database handle it here
            } else 
                AUErrorEmptyNotification.Visible = true;
        }

        private void ABtnClearField_Click ( object sender , EventArgs e )
        {
            // * Clear function not available 
            ClearFields();
        }

        private void ClearFields()
        {
            AUTxtBookName.Text = "";
            AUTxtBookAuthorName.Text = "";
            AUTxtBookISBN.Text = "";
            AUTxtBookPrice.Text = "";
            AUTxtBookCopies.Text = "";
        }

        private void AUBtnGoBack_Click ( object sender , EventArgs e ) {
            this.Hide();
        }
    }
}
