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
    public partial class AdminAddUser : Form {
        public AdminAddUser () {
            InitializeComponent();
        }

        private void AUBtnAddUser_Click ( object sender , EventArgs e ) {
            if ( AUTxtUserEmail.Text != string.Empty && AUTxtUserName.Text != string.Empty &&
                AUTxtUserAdno.Text != string.Empty && AUTxtUserPassword.Text != string.Empty ) {
                bool isDone = new UserBL().AddUserBL( AUTxtUserName.Text , int.Parse( AUTxtUserAdno.Text ) , AUTxtUserEmail.Text , AUTxtUserPassword.Text );
                if ( isDone ) {
                    if ( AUErrorEmptyNotification.Visible )
                        AUErrorEmptyNotification.Visible = false;
                    else if ( AUErrorPasswordNotify.Visible )
                        AUErrorPasswordNotify.Visible = false;
                    AUSuccessNotify.Visible = true;

                } else
                    AUErrorPasswordNotify.Visible = true; // FIXME: Could be any either false due to small length or failed in adding data to database.
            } else {
                if ( AUSuccessNotify.Visible )
                    AUSuccessNotify.Visible = false;
                else if ( AUErrorPasswordNotify.Visible )
                    AUErrorPasswordNotify.Visible = false;
                AUErrorEmptyNotification.Visible = true;
            }
        }

        private void ABtnClearField_Click ( object sender , EventArgs e ) {
            AUTxtUserEmail.Text = "";
            AUTxtUserName.Text = "";
            AUTxtUserAdno.Text = "";
            AUTxtUserPassword.Text = "";
        }

        private void AUBtnGoBack_Click ( object sender , EventArgs e ) {
            this.Hide();
        }
    }
}
