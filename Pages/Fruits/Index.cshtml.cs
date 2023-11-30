using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using razer_demo_00.Data;
using razer_demo_00.Models;

namespace razer_demo_00.Pages.Fruits
{
    public class IndexModel : PageModel
    {
        private readonly razer_demo_00.Data.razer_demo_00Context _context;

        public IndexModel(razer_demo_00.Data.razer_demo_00Context context)
        {
            _context = context;
        }

        public IList<Fruit> Fruit { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Fruit = await _context.Fruit.ToListAsync();
        }
    }
}
