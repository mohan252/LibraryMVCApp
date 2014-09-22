using Library.Domain;
using NUnit.Framework;
using Library.Service;

namespace LibraryAppEmpty.Tests
{
    [TestFixture]
    public class LibraryServiceTests
    {
         [Test]
         public void CreateBook_Maps_All_Properties_ToEntity_Object()
         {
             var library = new Library.Service.Library();
             BookSubmitModel bookSubmitModel = new BookSubmitModel() { Title = "book title" };
             
             library.CreateBook(bookSubmitModel);


         }
    }
}