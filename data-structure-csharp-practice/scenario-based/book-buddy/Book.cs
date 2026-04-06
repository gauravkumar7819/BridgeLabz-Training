using System;
namespace book_buddy
{
    class Book
    {
        string bookName;
        string autherName;

        public string BookName
        {
            get
            {
              return bookName;  
            }
            set
            {
                bookName=value;
            }
        }
        public string AutherName
        {
            get
            {
                return autherName;
            }
            set
            {
                autherName=value;
            }
        }
        public override string ToString()
        {
            return "Name:"+" "+bookName+" Auther:"+autherName;
        }

    }
}