using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class LibraryManage
    {
        public static void Main()
        {
            Author book = new Author("The Great Gatsby", 1925, "F. Scott Fitzgerald", "American novelist and short story writer."); 
            book.DisplayInfo();
        }
    }
    public class Book
    {
        public string Title {  get; set; }
        public int PublicationYear { get; set; }

        public Book(string title, int publicationYear)
        {
            Title = title;
            PublicationYear = publicationYear;
        }
        public virtual void DisplayInfo() {
            Console.WriteLine("Title: {0}, PublicationYear: {1}", Title, PublicationYear);
        }
    }

    public class Author : Book { 
        public string Name { get; set; }
        public string Bio { get; set; }
        public Author(string title, int publicationYear, string name, string bio) : base(title, publicationYear) {
            Name = name;
            Bio = bio;
        }
        public override void DisplayInfo(){
            Console.WriteLine("Title: {0}, Publication Year: {1}, Name: {2}, Bio: {3}", Title, PublicationYear, Name, Bio);
        }
    }
}
