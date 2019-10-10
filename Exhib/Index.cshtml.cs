using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Jurasssic_World.Data;

namespace Jurasssic_World.Pages.Exhib
{
    public class IndexModel : PageModel
    {
        private readonly Jurasssic_World.Data.ApplicationDbContext _context;

        public IndexModel(Jurasssic_World.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Exhibits> Exhibits { get;set; }

        public async Task OnGetAsync()
        {
            Exhibits = await _context.Exhibits.ToListAsync();
        }
    }
}
