using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Uwierzytelanie.Data;
using Uwierzytelanie.Models;

namespace Uwierzytelanie.Pages
{
    public class IndexModel : PageModel
    {
        private readonly LiczbaContext _context;

        private readonly ILogger<IndexModel> _logger;



        [BindProperty]
        public Class Class { get; set; }


        public IndexModel(ILogger<IndexModel> logger, LiczbaContext context)
        {
            _logger = logger;
            _context = context;
        }

        public void OnGet()
        {

        }

        public void OnPost()
        {
            if (ModelState.IsValid)
            {
                Class.FizzBuzz(Class.Liczba);

                _context.Class.Add(Class);
                _context.SaveChanges();
                HttpContext.Session.SetString("SessionClass",
                JsonConvert.SerializeObject(Class));
            }
        }
    }
}
