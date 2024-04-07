using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ASM_2_DDD
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int AuthorId { get; set; }
        public string PublicationDate { get; set; }
        public int CategoryId { get; set; }


        public Book(int id, string name, int authorId, string publicationDate, int categoryId)
        {
            Id = id;
            Name = name;
            AuthorId = authorId;
            PublicationDate = publicationDate;
            CategoryId = categoryId;
            
        }

        public Book() { }
    }
}
