using my_books.Data.Models;
using my_books.Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace my_books.Data.Services
{
    public class AuthorsService
    {
        private AppDBContext _context;
        public AuthorsService(AppDBContext context)
        {
            _context = context;
        }

        public void AddAuthor(AuthorVM book)
        {
            var _author = new Author()
            {
                FullName=book.FullName

            };
            _context.Authors.Add(_author);
            _context.SaveChanges();
        }

    }
}
