using ASP_NET_Razor_Page_Work_DB.Model;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace ASP_NET_Razor_Page_Work_DB.Pages.ElectricalElements
{
    public class ElectricalElementEditFormModel : PageModel
    {

        private readonly ApplicationDbContext _db;

        [BindProperty]

        public ElectricalElement ElectricalElement { get; set; } = new();

        public ElectricalElementEditFormModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task<IActionResult> OnGetAsync(int id)
        {
            ElectricalElement? electricalElement = await _db.DataBlock_t.FirstOrDefaultAsync(c => c.Id == id);
            if (electricalElement == null)
            {
                return NotFound();
            }
            ElectricalElement = electricalElement;
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            ElectricalElement? update = await _db.DataBlock_t.FirstOrDefaultAsync(c => c.Id == ElectricalElement.Id);
            if (update == null)
            {
                return NotFound();
            }
            update.Handl_f = ElectricalElement.Handl_f;
            update.BlockName_f=ElectricalElement.BlockName_f;
            update.CableName_f = ElectricalElement.CableName_f;
            update.CableStart_f = ElectricalElement.CableStart_f;
            update.CableEnd_f = ElectricalElement.CableEnd_f;
            update.CableFans_f = ElectricalElement.CableFans_f;
            update.CableDescr_f = ElectricalElement.CableDescr_f;
            update.BlockX_f = ElectricalElement.BlockX_f;
            update.BlockY_f = ElectricalElement.BlockY_f;
            update.BlockZ_f = ElectricalElement.BlockZ_f;
            update.LayerName_f = ElectricalElement.LayerName_f;
            await _db.SaveChangesAsync();
            return RedirectToPage("ElectricalElementsList");
        }
    }
}
