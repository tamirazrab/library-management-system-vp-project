using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryMSWF.BL;

namespace LibraryMSWF {
    public partial class AdminLogin : Form {

        System.Windows.Forms.Timer myTimer = new System.Windows.Forms.Timer();
        public AdminLogin () {
            InitializeComponent();
            myTimer.Tick += myTimer_Tick;
        }
        // todo: Check for empty fields and display error notification.
        private void LBtnSignIn_Click ( object sender , EventArgs e ) {
            if ( ATxtUserEmail.Text != String.Empty && ATxtUserPassword.Text != String.Empty ) {

                int userID = new AdminBL().AdminLoginBL( ATxtUserEmail.Text , ATxtUserPassword.Text );
                // * If userID is anything other than 0, it means user exist.
                if ( userID != 0 ) {
                    // * If there is any error notification present before and not closed it over-lapses success notification.
                    // * Hiding it.
                    if ( AErrorInvalidDetailsNotify.Visible )
                        AErrorInvalidDetailsNotify.Visible = false;
                    ASuccessNotify.Visible = true;

                    myTimer.Interval = 3000;
                    myTimer.Start();


                } else {
                    AErrorInvalidDetailsNotify.Visible = true;
                    // tbUserEmail.Clear();
                    // tbUserPass.Clear();
                }
            }
        }

        private void ABtnSignUp_Click ( object sender , EventArgs e ) {
            new AdminSignUp().Show();
            this.Hide();
        }

        private void hopePictureBox1_Click ( object sender , EventArgs e ) {
            new Home().Show();
            this.Hide();
        }

        private void myTimer_Tick ( object sender , System.EventArgs e ) {
            new AdminMainMenu().Show();
            this.Hide();

            //Stop the timer - if required
            myTimer.Stop();
        }
    }
}
