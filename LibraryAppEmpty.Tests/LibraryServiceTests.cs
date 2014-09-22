using Library.Domain;
using NUnit.Framework;
using Library.Business;

namespace LibraryAppEmpty.Tests
{
    [TestFixture]
    public class LibraryServiceTests
    {
         [Test]
         public void CreateBook_Maps_All_Properties_ToEntity_Object()
         {
             var library = new LibraryService();
             BookSubmitModel bookSubmitModel = new BookSubmitModel() { Title = "book title" };
             
             library.CreateBook(bookSubmitModel);


         }
    }
}