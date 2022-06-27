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
    public partial class AdminMainMenu : Form {

        public int BookID;
        public int UserID;
        public static string BookName;
        public static string DateRequested;
        public static int requestID;
        public static string UserName;
        private string requestedBookAuthorName;

        public static int receivedID;


        // todo: Validate if any field gets empty if it is then display error notification.


        public AdminMainMenu () {
            InitializeComponent();
            getBookData();
            getUserData();
            getRequestData();
            getAcceptedData();
        }


        private void getAcceptedData () {
            ADatagridAcceptedSection.DataSource = new UserRecieveBL().GetAllRecieveDAL();
        }

        private void getUserData () {
            ADatagridUserSection.DataSource = new UserBL().GetAllUsersBL();
        }


        private void getBookData () {
            ADatagridBookSection.DataSource = new BookBL().GetAllBooksBL();
        }

        private void getRequestData () {
            AUDatagridRequestSection.DataSource = new UserRequestBL().GetAllRequestBL();
        }

        private void ABBtnAdd_Click ( object sender , EventArgs e ) {
            // * book section add
            new AdminAddBook().Show();

        }

        private void ADatagridBookSection_CellClick ( object sender , DataGridViewCellEventArgs e ) {
            // requestID = Convert.ToInt32(
            // ADatagridBookSection.SelectedRows [ Constants.FirstRow ].Cells [ Constants.RequestID ].Value );
            BookID = Convert.ToInt32( ADatagridBookSection.SelectedRows [ Constants.FirstRow ].Cells [ Constants.BookID ].Value );

        }

        private void ABBtnBookSectionDelete_Click ( object sender , EventArgs e ) {
            // * proceeding only if any row which to be deleted has been selected.
            if ( BookID > 0 ) {
                if ( new BookBL().DeleteBookBL( BookID ) ) {
                    // todo: display success notification
                    // FIXME: AUBookSectionErrorNotify.Visible is false although it was showing why?

                    if ( AUBookSectionErrorNotify.Visible )
                        AUBookSectionErrorNotify.Visible = false;
                    AUBookSectionSuccessNotify.Visible = true;
                    getBookData(); // updating table

                    // * Resetting BookID so the deleted BookID don't get passed every-time - by that it bypasses the BookID > 0 condition
                    BookID = 0;

                }
            } else {
                // todo: display error notification to select some rows to delete record
                if ( AUUserSectionSuccessNotify.Visible )
                    AUUserSectionSuccessNotify.Visible = false;
                AUBookSectionErrorNotify.Visible = true;
            }
        }

        private void ABBtnBookSectionUpdate_Click ( object sender , EventArgs e ) {
            //* book section update
            // popping up update screen
            new AdminUpdateBook().Show();
            // keeping main window alive
        }

        private void ADatagridUserSection_CellClick ( object sender , DataGridViewCellEventArgs e ) {
            UserID = Convert.ToInt32(
                ADatagridUserSection.SelectedRows [ Constants.FirstRow ].Cells [ Constants.UserID ].Value );

        }

        private void AUBtnUserSectionDelete_Click ( object sender , EventArgs e ) {
            if ( UserID > 0 ) {
                if ( new UserBL().DeleteUserBL( UserID ) ) {
                    // todo: display success notification
                    // FIXME: AUUserSectionErrorEmptyNotification.Visible is false although it was showing why?
                    if ( AUUserSectionErrorEmptyNotification.Visible )
                        AUUserSectionErrorEmptyNotification.Visible = false;
                    AUUserSectionSuccessNotify.Visible = true;
                    getUserData();

                    // * Resetting userID so the deleted userID don't get passed every-time - by that it bypasses the UserID > 0 condition
                    UserID = 0;
                }
            } else {
                // todo: display error notification to select some rows to delete record
                if ( AUUserSectionSuccessNotify.Visible )
                    AUUserSectionSuccessNotify.Visible = false;
                AUUserSectionErrorEmptyNotification.Visible = true;
            }
        }

        private void AUBtnUserSectionUpdate_Click ( object sender , EventArgs e ) {
            new AdminUpdateUser().Show();

        }

        private void AUBtnUserSectionAdd_Click ( object sender , EventArgs e ) {
            new AdminAddUser().Show();
        }

        private void AUBtnUserSectionRefresh_Click ( object sender , EventArgs e ) {
            getUserData();

        }

        private void AUBtnBookSectionRefresh_Click ( object sender , EventArgs e ) {
            getBookData();
        }

        private void ARBtnAcceptRequest_Click ( object sender , EventArgs e ) {
            if ( requestID > 0 ) {

                // -FIXME: Remove userID from all request - receiver BL / DL
                // * If request is added to received and request is deleted successfully then
                if ( new UserRecieveBL().AddRecieveBL( BookName , requestedBookAuthorName , UserName , DateRequested ) &&
                    new UserRequestBL().DeleteRequestBL( requestID ) ) {
                    // todo: display success notification
                    if ( AURequestSectionErrorEmptyNotification.Visible )
                        AURequestSectionErrorEmptyNotification.Visible = false;
                    if ( AURequestSectionSuccessNotifyRejectedRequest.Visible )
                        AURequestSectionSuccessNotifyRejectedRequest.Visible = false;
                    AURequestSectionSuccessNotifyAcceptedRequest.Visible = true;
                    getRequestData();
                }
            } else {
                // todo: display error notification to select some rows to delete record
                if ( AURequestSectionSuccessNotifyAcceptedRequest.Visible )
                    AURequestSectionSuccessNotifyAcceptedRequest.Visible = false;
                if ( AURequestSectionSuccessNotifyRejectedRequest.Visible )
                    AURequestSectionSuccessNotifyRejectedRequest.Visible = false;
                AURequestSectionErrorEmptyNotification.Visible = true;
            }
        }

        private void AUDatagridRequestSection_CellClick ( object sender , DataGridViewCellEventArgs e ) {
            var firstSelectedRow = AUDatagridRequestSection.SelectedRows [ Constants.FirstRow ];
            requestID = Convert.ToInt32( firstSelectedRow.Cells [ Constants.RequestID ].Value );
            BookName = firstSelectedRow.Cells [ Constants.BookName ].Value.ToString();
            requestedBookAuthorName = firstSelectedRow.Cells [ Constants.RequestedBookAuthorName ].Value.ToString();
            DateRequested = firstSelectedRow.Cells [ Constants.BookDate ].Value.ToString();
            UserName = firstSelectedRow.Cells [ Constants.RequestedBooksUserName ].Value.ToString();

        }

        private void AUBtnRequestSectionRefresh_Click ( object sender , EventArgs e ) {
            getRequestData();
        }

        private void ARBtnRejectRequest_Click ( object sender , EventArgs e ) {
            if ( requestID > 0 ) {
                // -FIXME: Remove userID from all request - receiver BL / DL

                if (/* new BookBL().IncBookCopyBL( BookID ) && */
                    new UserRequestBL().DeleteRequestBL( requestID ) ) {
                    // todo: display success notification
                    if ( AURequestSectionErrorEmptyNotification.Visible )
                        AURequestSectionErrorEmptyNotification.Visible = false;
                    if ( AURequestSectionSuccessNotifyAcceptedRequest.Visible )
                        AURequestSectionSuccessNotifyAcceptedRequest.Visible = false;
                    AURequestSectionSuccessNotifyRejectedRequest.Visible = true;
                    getRequestData();
                }
            } else {
                // todo: display error notification to select some rows to delete record
                if ( AURequestSectionSuccessNotifyAcceptedRequest.Visible )
                    AURequestSectionSuccessNotifyAcceptedRequest.Visible = false;
                if ( AURequestSectionSuccessNotifyRejectedRequest.Visible )
                    AURequestSectionSuccessNotifyRejectedRequest.Visible = false;
                AURequestSectionErrorEmptyNotification.Visible = true;
            }
        }

        private void bigLabel5_Click ( object sender , EventArgs e ) {

        }

        private void ABtnAcceptedSectionRefresh_Click ( object sender , EventArgs e ) {
            getAcceptedData();
        }

        private void ADatagridAcceptedSection_CellClick ( object sender , DataGridViewCellEventArgs e ) {
            receivedID = Convert.ToInt32( ADatagridAcceptedSection.SelectedRows [ Constants.FirstRow ].Cells [ Constants.ReceivedID ].Value );
        }

        private void ABtnAcceptedSectionDelete_Click ( object sender , EventArgs e ) {
            if ( receivedID > 0 ) {
                if ( new UserRecieveBL().DeleteRecieveBL( receivedID ) ) {
                    ASuccessDeletedRequestNotify.Visible = true;
                    // * refreshing table
                    getAcceptedData();
                }
            } // todo: handle if any notification is present prior to new notification hide it.
            else {
                AErrorDeletedRequestNotify.Visible = true;
            }
        }

        private void ABtnLogout_Click ( object sender , EventArgs e ) {
            new AdminLogin().Show();
            this.Hide();
        }
    }
}
