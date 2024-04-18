using ASP_NET_Razor_Page_Work_DB.Model;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace ASP_NET_Razor_Page_Work_DB.Pages.ElectricalElements
{
    public class ElectricalElementDeleteModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public ElectricalElementDeleteModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task<IActionResult> OnGetAsync(int id)
        {
            ElectricalElement? removeble = await _db.DataBlock_t.FirstOrDefaultAsync(c => c.Id == id);
            if (removeble != null)
            {
                _db.DataBlock_t.Remove(removeble);
                await _db.SaveChangesAsync();
            }
            return RedirectToPage("ElectricalElementsList");
        }
    }
}
