using libreria_TLPC.Data.Models;
using libreria_TLPC.Data.ViewModels;
using System;
using libreria_TLPC.Data.ViewModels;

namespace libreria_TLPC.Data.Services
{
    public class PublishersService
    {
        private AppDbContext _context;
        public PublishersService(AppDbContext context)
        {
            _context = context;
        }

        //Metodo que nos permite agregar una nueva Editora en la BD

        public void AddPublisher(PublisherVM publisher)
        {
            var _publisher = new Publisher()
            {
                Name = publisher.Name
            };
            _context.Publishers.Add(_publisher);
            _context.SaveChanges();
        }
    }
}
