using LibraryMSWF.DAL;

namespace LibraryMSWF.BL {

    //CHECK THE ADMIN LOGIN CREDENTIALS =>BL
    public class AdminBL : UserBL {
        // -private const int InvalidInvitationCode = 3;
        // #Note May add admin ranks if had time so higher admins can edit, add, update or demote admins.

        public int ValidateAdmin ( string email , string password ) {
            if ( CheckUserDetails( email ) )
                return Constants.InvalidUserEmail;
            if ( CheckUserDetails( password ) )
                return Constants.InvalidUserPassword;
            // - if(CheckUserDetails(invitationCode)) return InvalidInvitationCode;
            return Constants.UserDetailsVerified; // * in this case it's admin
        }

        public int AdminLoginBL ( string email , string password ) {
            // * returns AdminID if matched against any record.
            return new AdminDAL().AdminLoginDAL( email , password );
        }

        public bool AddAdminBL ( string email , string password , string InvitedBy ) {
            if ( ValidateAdmin( email , password ) != Constants.UserDetailsVerified )
                return false;

            bool isDataAddedToDatabase = new AdminDAL().AddAdminDataDAL( email , password , InvitedBy );
            return isDataAddedToDatabase;
        }
    }
}