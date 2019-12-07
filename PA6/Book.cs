using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA6
{
    class Book
    {
        public string title { get; set; }
        public string cwid { get; set; }
        public string genre { get; set; }
        public int copies { get; set; }
        public string author { get; set; }
        public string isbn { get; set; }
        public int length { get; set; }
        public string cover { get; set; }
        public string _id { get; set; }

        public Book(string title, string cwid, string genre, int copies, string author, string isbn, int length, string cover, string id)
        {
            this.title = title;
            this.cwid = cwid;
            this.genre = genre;
            this.copies = copies;
            this.author = author;
            this.isbn = isbn;
            this.length = length;
            this.cover = cover;
            _id = id;
        }
        public Book()
        {

        }
        public override string ToString()
        {
            return this.title;
        }

    }
}
