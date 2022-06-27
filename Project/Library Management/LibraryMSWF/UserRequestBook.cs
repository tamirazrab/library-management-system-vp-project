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
    public partial class UserRequestBook : Form {
        public UserRequestBook () {
            InitializeComponent();
        }

        private void URBtnRequestBook_Click ( object sender , EventArgs e ) {
            if ( UTxtRequestSectionBookName.Text != string.Empty && UTxtRequestSectionAuthorName.Text != string.Empty &&
                UTxtRequestSectionUserName.Text != string.Empty ) {
                if ( new UserRequestBL().AddRequestBL( UTxtRequestSectionBookName.Text , UTxtRequestSectionAuthorName.Text ,
                    UTxtRequestSectionUserName.Text ) ) {
                    // todo: hide any other notification prior to success one.
                    URSSuccessNotify.Visible = true;
                    clearFields();

                }
            } else {
                // todo: hide any other notification prior to error one.
                URSErrorNotifySelectBook.Visible = true;
            }
        }

        private void UBtnClearField_Click ( object sender , EventArgs e ) {
            clearFields();
        }

        private void clearFields () {
            UTxtRequestSectionBookName.Text = "";
            UTxtRequestSectionAuthorName.Text = "";
            UTxtRequestSectionUserName.Text = "";
        }

        private void AUBtnGoBack_Click ( object sender , EventArgs e ) {
            this.Hide();
        }
    }
}
