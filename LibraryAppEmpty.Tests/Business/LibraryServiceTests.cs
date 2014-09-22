using System.Data.Entity;
using Library.Business;
using Library.Data.Models;
using Library.Domain;
using NSubstitute;
using NUnit.Framework;

namespace LibraryApp.Tests.Business
{
    [TestFixture]
    public class LibraryServiceTests
    {
         [Test]
         public void CreateBook_Maps_All_Properties_ToEntity_Object()
         {
             var libraryDbContext = Substitute.For<ILibraryDbContext>();
             libraryDbContext.Books = Substitute.For<IDbSet<Book>>();
             var library = new LibraryService(libraryDbContext);

             string expectedTitle = "book title";
             BookSubmitModel bookSubmitModel = new BookSubmitModel() { Title = expectedTitle };
             
             library.CreateBook(bookSubmitModel);

             libraryDbContext.Books.Received().Add(Arg.Is<Book>(b => b.Title == expectedTitle));
         }
    }
}