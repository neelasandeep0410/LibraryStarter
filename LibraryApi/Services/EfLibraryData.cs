using AutoMapper;
using AutoMapper.QueryableExtensions;
using LibraryApi.Domain;
using LibraryApi.Models.Books;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryApi.Services
{
    public class EfLibraryData : IQueryForBooks
    {
        private readonly LibraryDataContext _context;
        private readonly IMapper _mapper;
        private readonly MapperConfiguration _mapperConfig;

        public EfLibraryData(LibraryDataContext libraryDataContext, IMapper mapper, MapperConfiguration mapperConfiguration)
        {
            this._context = libraryDataContext;
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            this._mapperConfig = mapperConfiguration ?? throw new ArgumentNullException(nameof(mapperConfiguration));
        }

        public async Task<GetBooksResponse> GetAllBooks()
        {
            var response = new GetBooksResponse();

            var books = await _context.BooksInInventory()
                .ProjectTo<GetBooksResponseItem>(_mapperConfig)
                .ToListAsync();

            response.Data = books;
            return response;
        }

        public async Task<GetBookDetailsResponse> GetBookById(int bookId)
        {
            var book = await _context.BooksInInventory()
                 .Where(b => b.Id == bookId)
                 .ProjectTo<GetBookDetailsResponse>(_mapperConfig)
                 .SingleOrDefaultAsync();

            return book;
        }
    }
}