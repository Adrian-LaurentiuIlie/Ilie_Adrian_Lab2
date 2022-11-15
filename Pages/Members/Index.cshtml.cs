using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Ilie_Adrian_Lab2.Data;
using Ilie_Adrian_Lab2.Models;

namespace Ilie_Adrian_Lab2.Pages.Members
{
    public class IndexModel : PageModel
    {
        private readonly Ilie_Adrian_Lab2.Data.Ilie_Adrian_Lab2Context _context;

        public IndexModel(Ilie_Adrian_Lab2.Data.Ilie_Adrian_Lab2Context context)
        {
            _context = context;
        }

        public IList<Member> Member { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Member != null)
            {
                Member = await _context.Member.ToListAsync();
            }
        }
    }
}
