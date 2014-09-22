using Library.Domain;

namespace Library.Business
{
    public interface ILibraryService
    {
        void CreateBook(BookSubmitModel bookSubmitModel);
    }
}