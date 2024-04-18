using ASP_NET_Razor_Page_Work_DB.Model;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASP_NET_Razor_Page_Work_DB.Pages.ElectricalElements
{
    public class ElectricalElementsFormModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        [BindProperty]
        public ElectricalElement ElectricalElement { get; set; } = new();

        public ElectricalElementsFormModel(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<IActionResult> OnPostAsync()
        {
            await _db.DataBlock_t.AddAsync(ElectricalElement);
            await _db.SaveChangesAsync();
            return RedirectToPage("ElectricalElementsList"); // перенаправление запроса на список элементов
        }
    }
}
