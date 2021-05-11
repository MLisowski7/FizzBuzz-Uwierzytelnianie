using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Uwierzytelanie.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;

namespace Uwierzytelanie.Pages
{
    public class Zapisane_w_sesjiModel : PageModel
    {
        public Class Class { get; set; }

        public void OnGet()
        {
            var SessionClass =
            HttpContext.Session.GetString("SessionClass");
            if (SessionClass != null)
                Class =
                JsonConvert.DeserializeObject<Class>(SessionClass);
        }
    }
}
