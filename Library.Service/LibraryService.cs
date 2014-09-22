using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Data.Models;
using Library.Domain;

namespace Library.Business
{
    public class LibraryService
    {
        private readonly ILibraryDbContext _libraryDbContext;

        public LibraryService(ILibraryDbContext libraryDbContext)
        {
            _libraryDbContext = libraryDbContext;            
        }

        public void CreateBook(BookSubmitModel bookSubmitModel)
        {
            _libraryDbContext.Books.Add(new Book() {Title = bookSubmitModel.Title});
            _libraryDbContext.SaveChanges();
        }
    }
}
