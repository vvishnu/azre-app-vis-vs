using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using azre_app_vis_vs.Data;

namespace azre_app_vis_vs.Pages.Persons
{
    public class IndexModel : PageModel
    {
        private readonly azre_app_vis_vs.Data.AppDbContext _context;

        public IndexModel(azre_app_vis_vs.Data.AppDbContext context)
        {
            _context = context;
        }

        public IList<Person> Person { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Person = await _context.Persons.ToListAsync();
        }
    }
}
