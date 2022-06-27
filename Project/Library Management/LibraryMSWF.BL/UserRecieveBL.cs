using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using LibraryMSWF.DAL;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMSWF.BL {
    public class UserRecieveBL {
        //ADD THE RECIEVED BOOK INTO RECIEVED TABLE =>BL
        public bool AddRecieveBL ( string bookName , string authorName , string userNameWhomReceivedBy, string DateRequested ) {
            return new UserRecieveDAL().AddRecieveDAL( bookName , authorName , userNameWhomReceivedBy, DateRequested );
        }
        //RETURN THE COMPLETE RECIEVED BOOKS FROM RECIEVED TABLE  =>BL
        public DataTable GetAllRecieveDAL () {
            return new UserRecieveDAL().GetAllRecieveDAL();
        }
        //RETURN THE PERTICULAR USER RECIEVED BOOKS FROM RECIEVED TABLE  =>BL
        public DataSet GetAllRecieveUserBL ( int userId ) {
            return new UserRecieveDAL().GetAllRecieveUserDAL( userId );
        }
        //DELETE THE RECIEVED BOOK FROM RECIEVED TABLE =>BL
        public bool DeleteRecieveBL ( int receivedID ) {
            return new UserRecieveDAL().DeleteRecieveDAL( receivedID );
        }

    }
}
