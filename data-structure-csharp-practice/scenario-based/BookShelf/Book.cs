using System;
namespace BookShelf{
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }

        public Book(string title, string author)
        {
            Title = title;
            Author = author;
        }

        public override string ToString()
        {
            return $"{Title} by {Author}";
        }

        // Optional: For HashSet to avoid duplicates
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType()) return false;
            Book other = (Book)obj;
            return Title.Equals(other.Title, StringComparison.OrdinalIgnoreCase) 
                   && Author.Equals(other.Author, StringComparison.OrdinalIgnoreCase);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Title.ToLower(), Author.ToLower());
        }
    }
}