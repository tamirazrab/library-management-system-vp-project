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
    public partial class AdminUpdateBook : Form {

        public int BookID;

        // todo: Validate if any field gets empty if it is then display error notification.


        public AdminUpdateBook () {
            InitializeComponent();
            getUserData();
        }

        private void getUserData () {
            ADatagridUpdateBook.DataSource = new BookBL().GetAllBooksBL();
        }

        private void AUBtnUpdateBook_Click ( object sender , EventArgs e ) {
            if ( BookID > 0 ) {
                // * if any column is selected only than
                if ( new BookBL().UpdateBookBL( BookID , AUTxtBookName.Text , AUTxtBookAuthorName.Text , AUTxtBookISBN.Text , double.Parse( AUTxtBookPrice.Text ) , int.Parse( AUTxtBookCopies.Text ) ) ) {
                    // * hiding any error notifications if shown prior to success notification 
                    // todo: Error notification is not disappearing debug for later.
                    if ( AUErrorEmptyNotification.Visible )
                        AUErrorEmptyNotification.Visible = false;
                    // -else if(AUErrorPasswordNotify.Visible) AUErrorPasswordNotify.Visible = false;

                    AUSuccessNotify.Visible = true;

                    // * Refreshing table 
                    getUserData();
                    ClearFields();
                }

            } else {
                // todo: display error notification here
                if ( AUSuccessNotify.Visible )
                    AUSuccessNotify.Visible = false;
                AUErrorEmptyNotification.Visible = true;
            }


        }

        private void ClearFields () {
            AUTxtBookName.Text = "";
            AUTxtBookAuthorName.Text = "";

            AUTxtBookISBN.Text = "";
            AUTxtBookPrice.Text = "";
            AUTxtBookCopies.Text = "";
        }

        private void ADatagridUpdateUser_CellClick ( object sender , DataGridViewCellEventArgs e ) {
            BookID = Convert.ToInt32( ADatagridUpdateBook.SelectedRows [ Constants.FirstRow ].Cells [ Constants.BookID ].Value );
            AUTxtBookName.Text = ADatagridUpdateBook.SelectedRows [ Constants.FirstRow ].Cells [ Constants.BookName ].Value.ToString();
            AUTxtBookAuthorName.Text = ADatagridUpdateBook.SelectedRows [ Constants.FirstRow ].Cells [ Constants.BookAuthor ].Value.ToString();
            AUTxtBookISBN.Text = ADatagridUpdateBook.SelectedRows [ Constants.FirstRow ].Cells [ Constants.BookISBN ].Value.ToString();
            AUTxtBookPrice.Text = ADatagridUpdateBook.SelectedRows [ Constants.FirstRow ].Cells [ Constants.BookPrice ].Value.ToString();
            AUTxtBookCopies.Text = ADatagridUpdateBook.SelectedRows [ Constants.FirstRow ].Cells [ Constants.BookCopies ].Value.ToString();




        }

        private void ADatagridUpdateBook_CellContentClick ( object sender , DataGridViewCellEventArgs e ) {

        }

        private void AUBtnGoBack_Click ( object sender , EventArgs e ) {
            this.Hide();
        }
    }
}
