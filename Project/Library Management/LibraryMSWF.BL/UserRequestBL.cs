using System;
using LibraryMSWF.DAL;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMSWF.BL {
    public class UserRequestBL {
        public bool AddRequestBL (  string bookName, string authorName, string userNameWhoRequestedBook ) {
            // FIXME: Will make it work to get user name first have to figure out to get userID once user logs in.
            // var userName = new UserDAL().TakeUserNameDAL( userId );
            return new UserRequestDAL().AddRequestDAL(  bookName , authorName , userNameWhoRequestedBook );
        }

        public DataTable GetAllRequestBL () {
            return new UserRequestDAL().GetAllRequestDAL();
        }
        public bool DeleteRequestBL ( int requestID ) {
            return new UserRequestDAL().DeleteRequestDAL( requestID );
        }
    }
}
