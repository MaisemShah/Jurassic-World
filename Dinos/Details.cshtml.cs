﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Jurasssic_World.Data;

namespace Jurasssic_World.Pages.Dinos
{
    public class DetailsModel : PageModel
    {
        private readonly Jurasssic_World.Data.ApplicationDbContext _context;

        public DetailsModel(Jurasssic_World.Data.ApplicationDbContext context)
        {
            _context = context;
        }

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
    }
}
