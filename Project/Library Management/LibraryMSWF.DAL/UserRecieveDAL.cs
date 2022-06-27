using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMSWF.DAL {
    public class UserRecieveDAL {
        private readonly SqlConnection _con = new SqlConnection( @"Data Source =LAPTOP-4NN2AN7C\SQLEXPRESS;Initial Catalog=LibraryManagement;Integrated Security=True" );

        //ADD THE RECIEVED BOOK INTO RECIEVED TABLE =>DAL
        public bool AddRecieveDAL (  string bookName , string authorName , string userNameWhomReceivedBy, string DateRequested ) {
            _con.Open();

            var cmd = new SqlCommand( "INSERT INTO ReceivedBooks values(@bName, @author, @date, @uName)" , _con );
            cmd.Parameters.AddWithValue( "@bName" , bookName );
            cmd.Parameters.AddWithValue( "@author" , authorName);
            cmd.Parameters.AddWithValue( "@date" , DateRequested );
            cmd.Parameters.AddWithValue( "@uName" , userNameWhomReceivedBy );
            var rowAffected = cmd.ExecuteNonQuery();
            _con.Close();
            return rowAffected > 0;
        }
        //RETURN THE COMPLETE RECIEVED BOOKS FROM RECIEVED TABLE  =>DAL
        public DataTable GetAllRecieveDAL () {
            _con.Open();
            SqlCommand cmd = new SqlCommand( "SELECT * FROM ReceivedBooks" , _con );
            // * Data reader is better choice for rendering process, as data doesn't need to be hold in memory just fetch as soon new data pops up.
            SqlDataReader sdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load( sdr );
            _con.Close();
            return dt;
        }
        //RETURN THE PERTICULAR USER RECIEVED BOOKS FROM RECIEVED TABLE  =>DAL
        public DataSet GetAllRecieveUserDAL ( int userId ) {
            var da = new SqlDataAdapter( "SELECT BookID, BookName, Date FROM ReceivedBooks WHERE UserID = '" + userId + "'" , _con );
            var ds = new DataSet( "UserRecieved" );
            da.Fill( ds );
            return ds;
        }
        //DELETE THE RECIEVED BOOK FROM RECIEVED TABLE =>DAL
        public bool DeleteRecieveDAL ( int receivedID ) {
            _con.Open();
            // * DELETE TOP 1 is incorrect sql query
            var cmd = new SqlCommand( "DELETE TOP(1) FROM ReceivedBooks WHERE ReceivedID = @receivedId" , _con );
            cmd.Parameters.AddWithValue( "@receivedId" , receivedID );
            var rowAffected = cmd.ExecuteNonQuery();
            _con.Close();


            return rowAffected > 0;
        }
    }
}
