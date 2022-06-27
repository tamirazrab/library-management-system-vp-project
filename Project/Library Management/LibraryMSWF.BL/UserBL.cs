using System;
using System.Collections.Generic;
using LibraryMSWF.DAL;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;



namespace LibraryMSWF.BL {




    public class UserBL {


        public bool CheckUserDetails ( string userDetail ) {
            // userDetail could be email password or name, doesn't really matter.
            // FIXME: If already checking for string.empty in main then why checking again here?

            return userDetail.Equals( String.Empty ) || userDetail.Length < 5;
            // FIXME: pretty stupid condition may need tight fix later : || userDetail.Length > 15;
        }
        public int ValidateUser ( string name , int admissionNumber , string email , string password ) {

            // TODO: Add more descriptive error messages.

            if ( CheckUserDetails( name ) )
                return Constants.InvalidUserName;
            else if ( CheckUserDetails( email ) )
                return Constants.InvalidUserEmail;
            else if ( CheckUserDetails( password ) )
                return Constants.InvalidUserPassword;
            else if ( admissionNumber <= 0 )
                return Constants.InvalidUserAdmissionNumber;
            else
                return Constants.UserDetailsVerified;
        }

        //RETURN COMPLETE USERS FROM USER TABLE =>BL
        public DataTable GetAllUsersBL () {
            return new UserDAL().GetAllUsersDAL();
        }

        public bool AddUserBL ( string name , int admissionNumber , string email , string password ) {
            if ( ValidateUser( name , admissionNumber , email , password ) != Constants.UserDetailsVerified )
                return false;

            bool isDataAddedToDatabase = new UserDAL().AddUserDAL( name , admissionNumber , email , password );
            return isDataAddedToDatabase;

        }
        //UPDATE THE USER FROM USER TABLE =>BL
        public bool UpdateUserBL ( int userId , string userName , int userAdNo , string userEmail , string userPass ) {
            // * true if data is found and updated successfully.
            return new UserDAL().UpdateUserDAL( userId , userName , userAdNo , userEmail , userPass );
        }
        //DELETE THE USER FROM USER TABLE =>BL
        public bool DeleteUserBL ( int userId ) {
            // * returns true or false depending upon whether data found and deleted.
            return new UserDAL().DeleteUserDAL( userId );
        }
        //CHECK THE USER LOGIN CREDENTIALS RETURN USER ID =>BL
        public int UserLoginBL ( string userEmail , string userPass ) {
            // * Returns UserID if the record is found against email and password
            return new UserDAL().UserLoginDAL( userEmail , userPass );

        }
    }
}
