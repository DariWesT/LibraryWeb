
namespace LibraryWeb.Models
{
    public class Book
        {
    public int Id { get; set; } //Primary key
        public string? Isbn { get; set; }
        public string? Name { get; set; }
        public string? Author { get; set; }
        public string? Price { get; set; }
        
        //CRUD  Creat REad Update Delete

    }
}
