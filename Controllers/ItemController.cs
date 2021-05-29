using System.Linq;
using System.Threading.Tasks;
using DesafioNasa.Entidades;
using DesafioNasa.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DesafioNasa.Controllers
{
    public class ItemController : Controller
    {
        private readonly AppDbContext _context;

        public ItemController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var itens = await _context.Set<Item>().ToListAsync();

            var model = new ListaItemViewModel
            {
                Itens = itens.Select(i => (ItemViewModel)i).ToList()
            };

            return View(model);
        }
    }
}
