using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Jurasssic_World.Data;

namespace Jurasssic_World.Pages.Dinos
{
    public class CreateModel : PageModel
    {
        private readonly Jurasssic_World.Data.ApplicationDbContext _context;

        public CreateModel(Jurasssic_World.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["EID"] = new SelectList(_context.Set<Exhibits>(), "EID", "EID");
            return Page();
        }

        [BindProperty]
        public Dinosaurs Dinosaurs { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Dinosaurs.Add(Dinosaurs);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
