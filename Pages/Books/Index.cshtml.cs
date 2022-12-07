using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LibraryWeb.Data;
using LibraryWeb.Models;

namespace LibraryWeb.Pages.Books
{
    public class IndexModel : PageModel
    {
        private readonly LibraryWeb.Data.LibraryWebContext _context;

        public IndexModel(LibraryWeb.Data.LibraryWebContext context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Book != null)
            {
                Book = await _context.Book.ToListAsync();
            }
        }
    }
}
