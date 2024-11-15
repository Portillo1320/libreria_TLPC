using libreria_TLPC.Data.Models;
using libreria_TLPC.Data.ViewModels;
using System;
using libreria_TLPC.Data.ViewModels;

namespace libreria_TLPC.Data.Services
{
    public class AuthorsService
    {
        private AppDbContext _context;
        public AuthorsService(AppDbContext context)
        {
            _context = context;
        }

        //Metodo que nos permite agregar un nuevo Author en la BD

        public void AddAuthor(AuthorVM author)
        {
            var _author = new Author()
            {
                FullName = author.FullName
            };
            _context.Authors.Add(_author);
            _context.SaveChanges();
        }
    }
}
