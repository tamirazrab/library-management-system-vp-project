using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMSWF.DAL {
    public class BorrowedBooks {
        private readonly SqlConnection _con = new SqlConnection( @"Data Source =LAPTOP-4NN2AN7C\SQLEXPRESS;Initial Catalog=LibraryManagement;Integrated Security=True" );

        public DataTable GetBorrowedTableData () {
            _con.Open();
            SqlCommand cmd = new SqlCommand( "SELECT * FROM BorrowedBooks" , _con );
            // * Data reader is better choice for rendering process, as data doesn't need to be hold in memory just fetch as soon new data pops up.
            SqlDataReader sdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load( sdr );
            _con.Close();
            return dt;
        }


        public bool AddBorrowedBook ( string bookName , string borrowerName , string duration ) {
            _con.Open();
            // TODO: for later may need to adjust insert query - say tweak a bit
            var cmd = new SqlCommand( "Insert into BorrowedBooks values (@bookName, @borrowerName, @duration)" , _con );
            cmd.Parameters.AddWithValue( "@bookName" , bookName );
            cmd.Parameters.AddWithValue( "@borrowerName" , borrowerName );
            cmd.Parameters.AddWithValue( "@duration" , duration );
            var rowAffected = cmd.ExecuteNonQuery();
            _con.Close();
            return rowAffected > 0;
        }
        
        // todo: for later - user should be able to return borrowed books, increase book copies in main book table and delete from borrowed books table.
        
        
       
    }
}
