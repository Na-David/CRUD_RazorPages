using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Crud.Practice.Data;
using Crud.Practice.Models;

namespace Crud.Practice.Pages.Posts
{
    public class IndexModel : PageModel
    {
        private readonly Crud.Practice.Data.ApplicationDbContext _context;

        public IndexModel(Crud.Practice.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Post> Post { get;set; }

        public async Task OnGetAsync()
        {
            Post = await _context.Post
                .Include(p => p.Blog).ToListAsync();
        }
    }
}
