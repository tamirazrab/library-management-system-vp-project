using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryMSWF {
    public partial class Home : Form {
        public Home () {
            InitializeComponent();
        }

        private void HBtnLogin_Click ( object sender , EventArgs e ) {
            new SignUp().Show();
            this.Hide();
        }

        private void HBtnSignUp_Click ( object sender , EventArgs e ) {
           
            new Login().Show();
            this.Hide();
        }

       

        private void foreverButtonSticky1_Click ( object sender , EventArgs e ) {
            Application.Exit();
        }

        private void HBtnAdminArea_Click_1 ( object sender , EventArgs e ) {
            new AdminLogin().Show();
            this.Hide();
        }

        private void themeForm1_Click ( object sender , EventArgs e ) {

        }
    }
}
