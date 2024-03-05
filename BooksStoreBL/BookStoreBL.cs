using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BooksStoreDAL;
using Entities;

namespace BooksStoreBL
{
    public class BookStoreBL
    {
        List<BookDetails> ListOfBooks;
        FileConnection fileConnection;
        public BookStoreBL()
        {
            fileConnection = new FileConnection();
            ListOfBooks = fileConnection.ReadAllBooks();
        }

        public IEnumerable<BookDetails> GetAllBooks()
        {
            return ListOfBooks;
        }
        public IEnumerable<BookDetails> HighCostBooks()
        {
            var highCost = ListOfBooks.Where(l => l.Price > 30).OrderBy(l=>l.Id);
            return highCost;
        }
        public IEnumerable<BookDetails> CostOfComics() 
        {
            var costComics = ListOfBooks.Where(l => l.IsComics);
            return costComics;
        }
        public IEnumerable<BookDetails> NameBookForGirl()
        {
            var costComics = ListOfBooks.Where(l => (l.MinAge>=5 && l.MinAge<10) || (l.MaxAge>5&&l.MaxAge<=10));
            return costComics;
        }
    }
}
