using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMSWF.DAL {
    public class UserDAL {
        private readonly SqlConnection _con = new SqlConnection( @"Data Source =LAPTOP-4NN2AN7C\SQLEXPRESS;Initial Catalog=LibraryManagement;Integrated Security=True" );

        //RETURN COMPLETE USERS FROM USER TABLE =>DAL
        public DataTable GetAllUsersDAL () {
            _con.Open();
            SqlCommand cmd = new SqlCommand( "SELECT * FROM Users" , _con );
            // * Data reader is better choice for rendering process, as data doesn't need to be hold in memory just fetch as soon new data pops up.
            SqlDataReader sdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load( sdr );
            _con.Close();
            return dt;
        }


        //ADD USER INTO USER TABLE =>DAL
        public bool AddUserDAL ( string userName , int userAdNo , string userEmail , string userPass ) {
            _con.Open();
            // TODO: for later may need to adjust insert query - say tweak a bit
            var cmd = new SqlCommand( "Insert into Users values (@name, @adno, @email, @pass)" , _con );
            cmd.Parameters.AddWithValue( "@name" , userName );
            cmd.Parameters.AddWithValue( "@adno" , userAdNo );
            cmd.Parameters.AddWithValue( "@email" , userEmail );
            cmd.Parameters.AddWithValue( "@pass" , userPass );
            var rowAffected = cmd.ExecuteNonQuery();
            _con.Close();
            return rowAffected > 0;
        }
        //UPDATE THE USER FROM USER TABLE =>DAL
        public bool UpdateUserDAL ( int userId , string userName , int userAdNo , string userEmail , string userPass ) {
            _con.Open();
            var cmd = new SqlCommand(
                "Update Users SET Name = @name, AdmissionNumber = @adno, Email = @email,Password = @pass WHERE UserID = @id" , _con );
            cmd.Parameters.AddWithValue( "@name" , userName );
            cmd.Parameters.AddWithValue( "@adno" , userAdNo );
            cmd.Parameters.AddWithValue( "@email" , userEmail );
            cmd.Parameters.AddWithValue( "@pass" , userPass );
            cmd.Parameters.AddWithValue( "@id" , userId );


            var rowAffected = cmd.ExecuteNonQuery();
            _con.Close();
            return rowAffected > 0;
        }
        //DELETE THE USER FROM USER TABLE =>DAL
        public bool DeleteUserDAL ( int userId ) {
            _con.Open();

            var cmd = new SqlCommand( "Delete FROM Users WHERE UserID =  @id" , _con );
            cmd.Parameters.AddWithValue( "@id" , userId );
            var rowAffected = cmd.ExecuteNonQuery();
            _con.Close();
            return rowAffected > 0;
        }
        //RETURN USER NAME =>DAL
        // todo: If had any more interest then, getting userID once user log in and storing it on static variable then that user name could be
        // todo: accessed easily. It will eliminate need for user putting his/her name on borrow and request section.
        // * For now moving with manual approach user entering his/her name itself. 
        // public string TakeUserNameDAL ( int userId ) {
        //     _con.Open();
        //     // todo: Get better way to extract user name from table
        //     var cmd = new SqlCommand( "SELECT Name FROM Users WHERE UserID = @userId" , _con );
        //     cmd.Parameters.AddWithValue( "@userId" , userId );
        //     // var userName = ( string ) cmd.ExecuteScalar();
        //     string userName = null;
        //     // todo: test it later may not work as expected.
        //     SqlDataReader sReader = cmd.ExecuteReader();
        //     while ( sReader.Read() ) {
        //         // #NoteToSelf: Possibly only one row is extracted from query as it's against one record.
        //         userName = sReader [ "Name" ].ToString();
        //     }
        //     _con.Close();
        //     return userName;
        // }
        //CHECK THE USER LOGIN CREDENTIALS RETURN USER ID =>DAL
        public int UserLoginDAL ( string userEmail , string userPass ) {
            _con.Open();
            // FIXME: Need to test and may need to remove exception.
            // todo: no need to pass userID it's not getting used anywhere a simple true or false might be enough to indicate whether data successfully entered into table or not.
            // FIXME: will fix it later.

            var cmd = new SqlCommand( "SELECT * FROM Users WHERE Email = @email AND Password = @pass" , _con );
            cmd.Parameters.AddWithValue( "@email" , userEmail );
            cmd.Parameters.AddWithValue( "@pass" , userPass );

            var userID = 0;

            SqlDataReader sReader = cmd.ExecuteReader();
            while ( sReader.Read() ) {
                // #NoteToSelf: Possibly only one row is extracted from query as it's against one record.
                userID = Convert.ToInt32( sReader [ "UserID" ].ToString() );
            }

            // tag:#MayNeed: To look into  
            // var userId = (int)cmd.ExecuteScalar();
            _con.Close();
            return userID;

        }
    }
}
