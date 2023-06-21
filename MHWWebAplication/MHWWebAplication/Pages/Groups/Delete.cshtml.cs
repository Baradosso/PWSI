using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MHWWebAplication.DataContext;
using MHWWebAplication.EFModels;

namespace MHWWebAplication.Pages.Groups
{
    public class DeleteModel : PageModel
    {
        private readonly CoreStudentsContext _context;

        public DeleteModel(CoreStudentsContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Group Group { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Group == null)
            {
                return NotFound();
            }

            var group = await _context.Group.FirstOrDefaultAsync(m => m.GroupId == id);

            if (group == null)
            {
                return NotFound();
            }
            else 
            {
                Group = group;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Group == null)
            {
                return NotFound();
            }
            var group = await _context.Group.FindAsync(id);

            if (group != null)
            {
                Group = group;
                _context.Group.Remove(Group);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
