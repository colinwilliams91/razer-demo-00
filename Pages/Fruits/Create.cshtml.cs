using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using razer_demo_00.Data;
using razer_demo_00.Models;

namespace razer_demo_00.Pages.Fruits
{
    public class CreateModel : PageModel
    {
        private readonly razer_demo_00.Data.razer_demo_00Context _context;

        public CreateModel(razer_demo_00.Data.razer_demo_00Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Fruit Fruit { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Fruit.Add(Fruit);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
