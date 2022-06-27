using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMSWF.DAL {
    public class UserRequestDAL {
        readonly SqlConnection _con =
            new SqlConnection(
                @"Data Source =LAPTOP-4NN2AN7C\SQLEXPRESS;Initial Catalog=LibraryManagement;Integrated Security=True" );
        //ADD THE BOOK REQUEST INTO REQUEST TABLE =>DAL
        public bool AddRequestDAL (  string bookName , string authorName , string userName ) {
            _con.Open();

            var cmd = new SqlCommand( "INSERT INTO RequestedBooks values(@bName, @author,@date, @uName)" , _con );
            cmd.Parameters.AddWithValue( "@bName" , bookName );
            cmd.Parameters.AddWithValue( "@author" , authorName );
            // - todo: get rid of quick fix, and properly pass current data in proper format
            cmd.Parameters.AddWithValue( "@date" , DateTime.Now.Date.ToString( "dd-MM-yyyy" ) );
            cmd.Parameters.AddWithValue( "@uName" , userName );



            var rowAffected = cmd.ExecuteNonQuery();
            _con.Close();
            return rowAffected > 0;
        }
        //RETURN THE PERTICULAR USER REQUESTED BOOKS FROM REQUEST TABLE  =>DAL
        public DataTable GetAllRequestUserDAL ( int userId ) {
            _con.Open();
            SqlCommand cmd = new SqlCommand( "SELECT BookID, BookName, Date from RequestedBooks WHERE UserID = @userID" , _con );
            cmd.Parameters.AddWithValue( "@userID" , userId );
            SqlDataReader sdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load( sdr );
            _con.Close();
            return dt;
        }
        //RETURN THE COMPLETE REQUESTED BOOKS FROM REQUEST TABLE  =>DAL
        public DataTable GetAllRequestDAL () {
            _con.Open();
            SqlCommand cmd = new SqlCommand( "SELECT * FROM RequestedBooks" , _con );
            // * Data reader is better choice for rendering process, as data doesn't need to be hold in memory just fetch as soon new data pops up.
            SqlDataReader sdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load( sdr );
            _con.Close();
            return dt;
        }
        //DELETE THE BOOK REQUEST FROM REQUEST TABLE =>DAL
        public bool DeleteRequestDAL ( int requestID ) {
            _con.Open();
            // * UserID is necessary in case different users requested same book, deleting only with bookID would delete all the requests associated with it.
            // * Later comment: Changing the approach deleting request on request's ID's so if same book is requested twice it won't be affected.
            // * storing userID as static and then passing around doesn't look good approach won't be implementing until some better approach is seen.
            // * DELETE TOP 1 will produce error it is not valid query brackets are essential.
            var cmd = new SqlCommand( "DELETE TOP(1) FROM RequestedBooks  WHERE RequestID = @requestId" , _con );
            cmd.Parameters.AddWithValue( "@requestId" , requestID );
            //-cmd.Parameters.AddWithValue( "@uId" , userId );
            var rowAffected = cmd.ExecuteNonQuery();
            _con.Close();
            return ( rowAffected > 0 );
        }
    }
}
