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
    public partial class AdminSignUp : Form {
        public AdminSignUp () {
            InitializeComponent();
        }

        private void ABtnSignUp_Click ( object sender , EventArgs e ) {
            //  Only proceeding after complete input
            if ( ATxtUserEmail.Text != string.Empty && ATxtUserPassword.Text != string.Empty &&
                ATxtInvitedBy.Text != string.Empty ) {
                bool isDone = new AdminBL().AddAdminBL( ATxtUserEmail.Text , ATxtUserPassword.Text , ATxtInvitedBy.Text );
                if ( isDone ) {
                    ASuccessNotify.Visible = true;
                    // UserHomescreen userHomescreen = new UserHomescreen();
                    // userHomescreen.Show();
                    // tbUserEmail.Clear();
                    // tbUserPass.Clear();
                } else {
                    // FIXME: If data didn't got to databse, fix the error message or suggested completely removing it.
                    // sErrorInvalidDetailsNotify.Visible = true;
                    // tbUserEmail.Clear();
                    // tbUserPass.Clear();
                }

            } else if ( ATxtUserPassword.Text.Length <= 6 ) {

                AErrorPasswordNotify.Visible = true;

            } else
                // note: If any field remaining display error notification.
                AErrorEmptyNotification.Visible = true;
        }

        private void ABtnSignIn_Click ( object sender , EventArgs e ) {
            new AdminLogin().Show();
            this.Hide();
        }
    }
}
