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
using Microsoft.VisualBasic.Logging;

namespace LibraryMSWF {
    public partial class SignUp : Form {
        public SignUp () {
            InitializeComponent();
        }

        private void bigLabel1_Click ( object sender , EventArgs e ) {

        }

        private void materialLabel1_Click ( object sender , EventArgs e ) {

        }

        private void themeForm1_Click ( object sender , EventArgs e ) {

        }

        private void dungeonRichTextBox1_TextChanged ( object sender , EventArgs e ) {

        }

        private void sBtnSignUp_Click ( object sender , EventArgs e ) {
            //  Only proceeding after complete input
            if ( sTxtUserEmail.Text != string.Empty && sTxtUserPassword.Text != string.Empty &&
                sTxtUserName.Text != string.Empty && sTxtUserAdno.Text != string.Empty ) {
                if ( sTxtUserPassword.Text.Length <= 6 ) {

                    sErrorPasswordNotify.Visible = true;
                    

                }
                else if ( new UserBL().AddUserBL( sTxtUserName.Text , int.Parse( sTxtUserAdno.Text ) , sTxtUserEmail.Text , sTxtUserPassword.Text ) ) {
                    sSuccessNotify.Visible = true;
                    // UserHomescreen userHomescreen = new UserHomescreen();
                    // userHomescreen.Show();
                    // tbUserEmail.Clear();
                    // tbUserPass.Clear();
                } else {
                    // FIXME: If data didn't got to databse, fix the error message or suggested completely removing it.
                    sErrorInvalidDetailsNotify.Visible = true;
                    // tbUserEmail.Clear();
                    // tbUserPass.Clear();
                }

            } else
                // note: If any field remaining display error notification.
                sErrorEmptyNotification.Visible = true;
           
        }

        private void sBtnSignIn_Click ( object sender , EventArgs e ) {
            new Login().Show();
            this.Hide();
        }
    }
}
