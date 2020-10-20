using LibraryApi.Models.Books;
using System.Threading.Tasks;

namespace LibraryApi.Services
{
    public interface IDoBookCommands
    {
        Task<GetBookDetailsResponse> AddBook(PostBookCreate bookToAdd);
        Task RemoveBook(int bookId);
        Task<bool> UpdateTitle(int bookId, string title);
    }
}
