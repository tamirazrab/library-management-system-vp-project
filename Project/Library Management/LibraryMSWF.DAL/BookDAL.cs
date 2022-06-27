using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMSWF.DAL {
    public class BookDAL {
        // #TODO: Refactor variable and function name
        readonly SqlConnection _con =
            new SqlConnection(
                @"Data Source =LAPTOP-4NN2AN7C\SQLEXPRESS;Initial Catalog=LibraryManagement;Integrated Security=True" );

        //RETURN THE COMPLETE BOOKS FROM BOOK TABLE =>DAL
        public DataTable GetAllBooksDAL () {
                _con.Open();
                SqlCommand cmd = new SqlCommand( "SELECT * FROM Books" , _con );
                // * Data reader is better choice for rendering process, as data doesn't need to be hold in memory just fetch as soon new data pops up.
                SqlDataReader sdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load( sdr );
                _con.Close();
                return dt;
        }

        //ADD BOOK INTO BOOK TABLE => DAL
        public bool AddBookDAL ( string bookName , string bookAuthor , string bookIsbn , double bookPrice , int bookCopies ) {
            var cmd = new SqlCommand( "Insert into Books VALUES(@name, @author,@isbn,@price,@copy)" , _con );
            cmd.Parameters.AddWithValue( "@name" , bookName );
            cmd.Parameters.AddWithValue( "@author" , bookAuthor );
            cmd.Parameters.AddWithValue( "@isbn" , bookIsbn );
            cmd.Parameters.AddWithValue( "@price" , bookPrice );
            cmd.Parameters.AddWithValue( "@copy" , bookCopies );
            _con.Open();
            var rowAffected = cmd.ExecuteNonQuery();
            _con.Close();

            return rowAffected > 0;

        }

        //UPDATE THE BOOK FROM BOOK TABLE =>DAL
        public bool UpdateBookDal ( int bookId , string bookName , string bookAuthor , string bookIsbn , double bookPrice ,
            int bookCopies ) {
            _con.Open();
            var cmd = new SqlCommand(
                "Update Books SET Name = @name, Author = @author, ISBN = @isbn,Price = @price,Copies = @copy WHERE BookID = @id" , _con );
            cmd.Parameters.AddWithValue( "@id" , bookId );
            cmd.Parameters.AddWithValue( "@name" , bookName );
            cmd.Parameters.AddWithValue( "@author" , bookAuthor );
            cmd.Parameters.AddWithValue( "@isbn" , bookIsbn );
            cmd.Parameters.AddWithValue( "@price" , bookPrice );
            cmd.Parameters.AddWithValue( "@copy" , bookCopies );
            var rowAffected = cmd.ExecuteNonQuery();
            _con.Close();
            return rowAffected > 0;
        }

        //DELETE THE BOOK FROM BOOK TABLE =>DAL
        public bool DeleteBookDAL ( int bookId ) {
            _con.Open();
            var cmd = new SqlCommand( "DELETE FROM Books WHERE BookID = @id" , _con );
            cmd.Parameters.AddWithValue( "@id" , bookId );
            var rowAffected = cmd.ExecuteNonQuery();
            _con.Close();
            return rowAffected > 0;

        }

        //INCREMENT THE BOOK COPIES OF A BOOK BY 1 =>DAL
        public bool IncBookCopyDAL ( int bookId ) {
            _con.Open();
            var cmd = new SqlCommand( "UPDATE Books SET Copies = Copies + 1 WHERE BookID = @id" , _con );
            cmd.Parameters.Add( new SqlParameter( "@id" , bookId ) );
            var rowAffected = cmd.ExecuteNonQuery();
            _con.Close();
            return rowAffected > 0;

        }

        public bool increaseBookCopies ( int id ) {
            _con.Open();
            int currentCopies = 0;
            var cmd = new SqlCommand( "SELECT Copies FROM Books WHERE BookID = @id" , _con );
            cmd.Parameters.AddWithValue( "@id" , id );
            var dr = cmd.ExecuteReader();
            if ( dr.Read() ) // Read() returns TRUE if there are records to read, or FALSE if there is nothing
            {
                currentCopies = Convert.ToInt32( dr [ "Copies" ] );
                currentCopies++;
            }

            cmd = new SqlCommand( "Update Books SET Copies = @copy" , _con );
            // FIXME: Alternative solution would be test above if doesn't work replace.
            // cmd = new SqlCommand( "Update Books SET Copies = @copy" , _con );
            cmd.Parameters.AddWithValue( "@copy" , currentCopies );
            var rowAffected = cmd.ExecuteNonQuery();
            _con.Close();
            return rowAffected > 0;
        }
    }
}
