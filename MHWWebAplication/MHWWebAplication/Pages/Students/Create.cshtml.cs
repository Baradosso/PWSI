using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MHWWebAplication.DataContext;
using MHWWebAplication.EFModels;

namespace MHWWebAplication.Pages.StudentPages
{
    public class CreateModel : PageModel
    {
        private readonly CoreStudentsContext _context;

        public CreateModel(CoreStudentsContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["GroupId"] = new SelectList(_context.Group, "GroupId", "Name");
            return Page();
        }

        [BindProperty]
        public Student Student { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            // Retrieve the selected group object based on the selected GroupId
            Student.Group = await _context.Group.FindAsync(Student.GroupId);

            _context.Students.Add(Student);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
