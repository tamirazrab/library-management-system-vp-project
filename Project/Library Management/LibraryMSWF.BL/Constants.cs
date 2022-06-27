namespace LibraryMSWF.BL {
    public class Constants {
        public static int FirstRow { get; } = 0;
        public static int UserID { get; } = 0;
        public static int UserName { get; } = 1;
        public static int UserAdmissionNumber { get; } = 2;
        public static int UserEmail { get; } = 3;
        public static int UserPassword { get; } = 4;
        public static int BookID { get; } = 0;

        public static int BookName { get; } = 1;

        public static int BookAuthor { get; } = 2;
        public static int BookDate { get; } = 3;


        public static int BookISBN { get; } = 3;

        public static int BookPrice { get; } = 4;
        public static int RequestedBookAuthorName { get; } = 2;
        public static int RequestedBooksUserName { get; } = 4;



        public static int BookCopies { get; } = 5;
        public static int InvalidUserName { get; } = 0;
        public static int InvalidUserEmail { get; } = 1;
        public static int InvalidUserPassword { get; } = 2;
        public static int InvalidUserAdmissionNumber { get; } = 3;
        public static int UserDetailsVerified { get; } = 4;
        public static int RequestID { get; } = 0;
        public static int RequestBookDate { get; } = 3;
        public static int RequestBookBy { get; } = 4;


        public static int ReceivedID { get; } = 0;

    }
}