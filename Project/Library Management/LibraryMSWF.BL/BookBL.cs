using System;
using System.Collections.Generic;
using System.Linq;
using LibraryMSWF.DAL;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMSWF.BL {
    public class BookBL {

         
         const int InvalidBookPrice = 0;
         const int InvalidBookCopies = 1;
         const int BookDetailsVerified = 2;


        //VALIDATION METHOD FOR VALIDATE BOOK DETAILS
        public int ValidateBook (  double bookPrice , int bookCopies ) {

           if(bookPrice <= 0) return InvalidBookPrice;
           if(bookCopies <= 0) return InvalidBookCopies;

           return BookDetailsVerified;

        }
        //RETURN THE COMPLETE BOOKS FROM BOOK TABLE =>BL
        public DataTable GetAllBooksBL () {
            return new BookDAL().GetAllBooksDAL();
             
        }
        /*public bool AddBookBL(string bookName, string bookAuthor, string bookISBN, double bookPrice, int bookCopies)
        {
            BookDAL bookDAL = new BookDAL();
            bool isDone = bookDAL.AddBookDAL(bookName, bookAuthor, bookISBN, bookPrice, bookCopies);
            return isDone;
        }*/
        //ADD BOOK INTO BOOK TABLE => BL
        public bool AddBookBL ( string bookName , string bookAuthor , string bookISBN , double bookPrice , int bookCopies ) {
            if ( ValidateBook(  bookPrice , bookCopies ) != BookDetailsVerified ) 
                return false; 

                
            bool isDataAddedToDatabase = new BookDAL().AddBookDAL( bookName , bookAuthor , bookISBN , bookPrice , bookCopies );
            return isDataAddedToDatabase;

        }
        //UPDATE THE BOOK FROM BOOK TABLE =>BL
        /* public string UpdateBookBL(int bookId, string bookName, string bookAuthor, string bookISBN, double bookPrice, int bookCopies)
         {
             string isBookValid = validateBook(bookName, bookAuthor, bookISBN, bookPrice, bookCopies);
             if (isBookValid == "true")
             {
                 BookDAL bookDAL = new BookDAL();
                 bool isDone = bookDAL.UpdateBookDAL(bookId, bookName, bookAuthor, bookISBN, bookPrice, bookCopies);
                 if (isDone != true)
                 {
                     return "Server error, ";
                 }
                 else
                 {
                     return "true";
                 }
             }
             else
             {
                 return isBookValid;
             }
         }*/
        public bool UpdateBookBL ( int bookId , string bookName , string bookAuthor , string bookISBN , double bookPrice , int bookCopies ) {
            
             return new BookDAL().UpdateBookDal( bookId , bookName , bookAuthor , bookISBN , bookPrice , bookCopies );
        }
        //DELETE THE BOOK FROM BOOK TABLE =>BL
        public bool DeleteBookBL ( int bookId ) {
            var bookDAL = new BookDAL();
            var isDone = bookDAL.DeleteBookDAL( bookId );
            return isDone;
        }
        //INCREMENT THE BOOK COPIES OF A BOOK BY 1 =>BL
        public bool IncBookCopyBL ( int bookId ) {
            var bookDAL = new BookDAL();
            var isDone = bookDAL.IncBookCopyDAL( bookId );
            return isDone;
        }

    }
}
