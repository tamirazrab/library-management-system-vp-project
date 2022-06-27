using System;
using System.Data.SqlClient;

namespace LibraryMSWF.DAL {

    public class AdminDAL {

        private readonly SqlConnection _con =
            new SqlConnection(
                @"Data Source =LAPTOP-4NN2AN7C\SQLEXPRESS;Initial Catalog=LibraryManagement;Integrated Security=True" );

        //CHECK THE ADMIN LOGIN CREDENTIALS =>DAL
        public bool AddAdminDataDAL ( string email , string password , string invitedBy ) {
            _con.Open();

            var cmd = new SqlCommand( "INSERT into Admins VALUES(@email, @pwd, @invitedBy)" , _con );
            cmd.Parameters.AddWithValue( "@email" , email );
            cmd.Parameters.AddWithValue( "@pwd" , password );
            cmd.Parameters.AddWithValue( "@invitedBy" , invitedBy );

            var rowAffected = cmd.ExecuteNonQuery();
            _con.Close();
            return rowAffected > 0;
        }

        public int AdminLoginDAL ( string email , string password ) {
            _con.Open();
            // FIXME: Need to test and may need to remove exception.
            var cmd = new SqlCommand( "SELECT * FROM Admins WHERE Email = @email AND Password = @pass" , _con );
            cmd.Parameters.AddWithValue( "@email" , email );
            cmd.Parameters.AddWithValue( "@pass" , password );

            var adminID = 0;

            SqlDataReader sReader = cmd.ExecuteReader();
            while ( sReader.Read() ) {
                // #NoteToSelf: Possibly only one row is extracted from query as it's against one record.
                adminID = Convert.ToInt32( sReader [ "AdminID" ].ToString() );
            }

            // tag:#MayNeed: To look into
            // var userId = (int)cmd.ExecuteScalar();
            _con.Close();
            return adminID;
        }
    }
}