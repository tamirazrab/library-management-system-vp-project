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
    public partial class UserMainMenu : Form {
        private int requestID;

        public UserMainMenu () {
            InitializeComponent();
            getBookData();
            GetBorrowedBookData();
            getRequestedBooksData();

        }

        private void getRequestedBooksData () {
            UDatagridRequestSection.DataSource = new UserRequestBL().GetAllRequestBL();
        }

        private void getBookData () {
            UDatagridViewSection.DataSource = new BookBL().GetAllBooksBL();
        }

        private void GetBorrowedBookData () {
            UDatagridBorrowSectionDisplayBorrowedBooks.DataSource = new BorrowedBooks().GetBorrowedTableData();
        }

        private void ABtnLogout_Click ( object sender , EventArgs e ) {
            new Login().Show();
            this.Hide();
        }

        private void UBBtnRequestBook_Click ( object sender , EventArgs e ) {
            new UserBorrowBook().Show();
        }

        private void AUBtnBookSectionRefresh_Click ( object sender , EventArgs e ) {
            GetBorrowedBookData();
        }

        private void URBtnRequestBook_Click ( object sender , EventArgs e ) {
            new UserRequestBook().Show();
        }

        private void UDatagridRequestSection_CellClick ( object sender , DataGridViewCellEventArgs e ) {
            var firstRow = UDatagridRequestSection.SelectedRows [ Constants.FirstRow ];
            requestID = Convert.ToInt32( firstRow.Cells [ Constants.RequestID ].Value );
        }

        private void AUBtnBookSectionRefresh_Click_1 ( object sender , EventArgs e ) {
            getRequestedBooksData();
        }
    }
}
