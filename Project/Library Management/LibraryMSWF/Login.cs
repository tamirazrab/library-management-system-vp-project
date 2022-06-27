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
    public partial class Login : Form {
        System.Windows.Forms.Timer myTimer = new System.Windows.Forms.Timer();

        public Login () {
            InitializeComponent();
            myTimer.Tick += myTimer_Tick;

        }

        private void LBtnSignIn_Click ( object sender , EventArgs e ) {
            if ( LTxtUserEmail.Text != String.Empty && LTxtUserPassword.Text != String.Empty ) {

                int userID = new UserBL().UserLoginBL( LTxtUserEmail.Text , LTxtUserPassword.Text );
                // * If userID is anything other than 0, it means user exist.
                if ( userID != 0 ) {
                    // * If there is any error notification present before and not closed it over-lapses success notification.
                    // * Hiding it.
                    if ( LErrorInvalidDetailsNotify.Visible )
                        LErrorInvalidDetailsNotify.Visible = false;
                    LSuccessNotify.Visible = true;

                    myTimer.Interval = 3000;
                    myTimer.Start();
                } else {
                    LErrorInvalidDetailsNotify.Visible = true;
                    // tbUserEmail.Clear();
                    // tbUserPass.Clear();
                }
            } else {
                UErrorNotifyEmptyFields.Visible = true;
            }
        }

        private void LBtnSignUp_Click ( object sender , EventArgs e ) {
            new SignUp().Show();
            this.Hide();
        }

        private void themeForm1_Click ( object sender , EventArgs e ) {

        }

        private void hopePictureBox1_Click ( object sender , EventArgs e ) {
            new Home().Show();
            this.Hide();
        }

        private void myTimer_Tick ( object sender , System.EventArgs e ) {
            new UserMainMenu().Show();
            this.Hide();

            //Stop the timer - if required
            myTimer.Stop();
        }

        private void LBtnAdminArea_Click ( object sender , EventArgs e ) {
            new AdminLogin().Show();
            this.Hide();
        }
    }
}
