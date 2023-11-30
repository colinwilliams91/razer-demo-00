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
    public class DetailsModel : PageModel
    {
        private readonly razer_demo_00.Data.razer_demo_00Context _context;

        public DetailsModel(razer_demo_00.Data.razer_demo_00Context context)
        {
            _context = context;
        }

        public Fruit Fruit { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fruit = await _context.Fruit.FirstOrDefaultAsync(m => m.Id == id);
            if (fruit == null)
            {
                return NotFound();
            }
            else
            {
                Fruit = fruit;
            }
            return Page();
        }
    }
}
