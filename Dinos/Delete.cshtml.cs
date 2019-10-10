using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Jurasssic_World.Data;

namespace Jurasssic_World.Pages.Dinos
{
    public class DeleteModel : PageModel
    {
        private readonly Jurasssic_World.Data.ApplicationDbContext _context;

        public DeleteModel(Jurasssic_World.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Dinosaurs Dinosaurs { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Dinosaurs = await _context.Dinosaurs
                .Include(d => d.ExID).FirstOrDefaultAsync(m => m.DID == id);

            if (Dinosaurs == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Dinosaurs = await _context.Dinosaurs.FindAsync(id);

            if (Dinosaurs != null)
            {
                _context.Dinosaurs.Remove(Dinosaurs);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
