using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Uwierzytelanie.Data;
using Uwierzytelanie.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;

namespace Uwierzytelanie.Pages
{
    [Authorize]
    public class ClassModel : PageModel
    {
        private readonly LiczbaContext _context;
        public ClassModel(LiczbaContext context)
        {
            _context = context;
        }
        [BindProperty]
        public Class Class { get; set; }
        public IEnumerable<Class> Wyszukania { get; set; }
        public async Task OnGetAsync()
        {
            Wyszukania = await _context.Class.OrderByDescending(m => m.Data).Take(20).ToListAsync();
        }
        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Class = await _context.Class.FindAsync(id);
            if (Class != null)
            {
                _context.Class.Remove(Class);
                await _context.SaveChangesAsync();
            }
            return RedirectToPage("./Wyszukania");
        }
    }
}