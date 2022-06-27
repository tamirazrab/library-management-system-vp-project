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
using LibraryMSWF.DAL;

namespace LibraryMSWF {
    public partial class UserBorrowBook : Form {
        public int BookID { get; set; }

        public string BookName { get; set; }
        public string DurationPeriod { get; set; }


        public UserBorrowBook () {
            InitializeComponent();
            getBookData();
        }

        private void getBookData () {
            // todo: if had free time, get only those books which aren't borrowed by other users and if borrowed then reduce the copies of it.
            UDatagridBorrowSection.DataSource = new BookBL().GetAllBooksBL();
        }

        private void UDatagridBorrowSection_CellClick ( object sender , DataGridViewCellEventArgs e ) {
            var firstRow = UDatagridBorrowSection.SelectedRows [ Constants.FirstRow ];
            BookID = Convert.ToInt32( firstRow.Cells[Constants.BookID].Value);
            BookName = firstRow.Cells[Constants.BookName].Value.ToString();
            
        }

        // * duration period box
        private void materialComboBox1_SelectedIndexChanged ( object sender , EventArgs e ) {
            // * update duration period every-time to grab new item
            DurationPeriod = UTxtDurationPeriod.SelectedItem.ToString();
        }


        private void UBtnBorrowBook_Click ( object sender , EventArgs e ) {
            if (BookID > 0)
            {

            if (UTxtBorrowerName.Text != string.Empty && UTxtDurationNumber.Text != string.Empty &&
                DurationPeriod != string.Empty)
            {
                DurationPeriod = UTxtDurationNumber.Text + " " + DurationPeriod;
                if (new BorrowedBooks().AddBorrowedBook(BookName, UTxtBorrowerName.Text, DurationPeriod))
                {
                    // todo: add check of any other notification pop ups and close them before displaying new notification
                    // * had trouble making it work when debugged properly it will be added.
                    USuccessNotify.Visible = true;
                }
                
            }
            else
            {
                UErrorEmptyNotification.Visible = true;
            }
            }
            else
            {
                UErrorNotifySelectBook.Visible = true;
            }
        }

        private void AUBtnGoBack_Click ( object sender , EventArgs e ) {
            this.Hide();
        }
    }
}
