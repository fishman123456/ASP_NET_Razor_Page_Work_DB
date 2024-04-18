using ASP_NET_Razor_Page_Work_DB.Model;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASP_NET_Razor_Page_Work_DB.Pages.ElectricalElements
{
    public class ElectricalElementsListModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public List<ElectricalElement> ElectricalElements { get; private set; } = new();
        public ElectricalElementsListModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public void OnGet()
        {
            ElectricalElements = _db.DataBlock_t.ToList();
        }
    }
}
