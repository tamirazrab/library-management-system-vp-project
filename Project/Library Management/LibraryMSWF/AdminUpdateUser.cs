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
    public partial class AdminUpdateUser : Form {
        public AdminUpdateUser () {
            InitializeComponent();
            getUserData();
        }

        public int userID;

        private void getUserData () {
            ADatagridUpdateUser.DataSource = new UserBL().GetAllUsersBL();
        }

        private void ABtnClearField_Click ( object sender , EventArgs e ) {
            ClearFields();
        }

        private void ADatagridUpdateUser_CellContentClick ( object sender , DataGridViewCellEventArgs e ) {

        }

        private void AdminUpdateUser_Load ( object sender , EventArgs e ) {

        }

        private void AUBtnUpdateUser_Click ( object sender , EventArgs e ) {
            // * in this case guaranteed that all fields would be fill because user has to select at least one row
            // todo: add selected row check is row selected
            if ( userID > 0 ) {
                // * if any column is selected only than
                if ( new UserBL().UpdateUserBL( userID , AUTxtUserName.Text , int.Parse( AUTxtUserAdno.Text ) ,
                    AUTxtUserEmail.Text , AUTxtUserPassword.Text ) ) {
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
            AUTxtUserName.Text = "";
            AUTxtUserAdno.Text = "";

            AUTxtUserEmail.Text = "";
            AUTxtUserPassword.Text = "";
        }

        private void ADatagridUpdateUser_CellClick ( object sender , DataGridViewCellEventArgs e ) {
            userID = Convert.ToInt32( ADatagridUpdateUser.SelectedRows [ Constants.FirstRow ].Cells [ Constants.UserID ].Value );
            AUTxtUserName.Text = ADatagridUpdateUser.SelectedRows [ Constants.FirstRow ].Cells [ Constants.UserName ].Value.ToString();
            AUTxtUserAdno.Text = ADatagridUpdateUser.SelectedRows [ Constants.FirstRow ].Cells [ Constants.UserAdmissionNumber ].Value.ToString();
            AUTxtUserEmail.Text = ADatagridUpdateUser.SelectedRows [ Constants.FirstRow ].Cells [ Constants.UserEmail ].Value.ToString();
            AUTxtUserPassword.Text = ADatagridUpdateUser.SelectedRows [ Constants.FirstRow ].Cells [ Constants.UserPassword ].Value.ToString();


        }

        private void AUBtnGoBack_Click ( object sender , EventArgs e ) {
            this.Hide();
        }
    }
}
