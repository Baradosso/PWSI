using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MHWWebAplication.DataContext;
using MHWWebAplication.EFModels;

namespace MHWWebAplication.Pages.Groups
{
    public class IndexModel : PageModel
    {
        private readonly CoreStudentsContext _context;

        public IndexModel(CoreStudentsContext context)
        {
            _context = context;
        }

        public IList<Group> Group { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Group != null)
            {
                Group = await _context.Group.ToListAsync();
            }
        }
    }
}
