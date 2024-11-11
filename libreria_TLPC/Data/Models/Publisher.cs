using System.Collections.Generic;

namespace libreria_TLPC.Data.Models
{
    public class Publisher
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //Propiedades de navegacion(En esta parte es donde mapeamos)
        public List<Book> Books { get; set; }
        public List<Book_Author> Book_Authors { get; set; }
    }
}
