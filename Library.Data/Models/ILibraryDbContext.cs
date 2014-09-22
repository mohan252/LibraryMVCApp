using System;
using System.Data.Entity;

namespace Library.Data.Models
{
    public interface ILibraryDbContext : IDisposable
    {
        int SaveChanges();
        IDbSet<Book> Books { get; set; }
    }

    public class LibraryDbContext : DbContext, ILibraryDbContext
    {
        public LibraryDbContext()
            : base("name=LibraryEntities")
        {
            Configuration.LazyLoadingEnabled = true;
        }

        public IDbSet<Book> Books { get; set; }
    }
}