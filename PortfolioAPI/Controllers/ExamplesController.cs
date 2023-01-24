using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PortfolioAPI.Models;

namespace PortfolioAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExamplesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ExamplesController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Examples>>> GetExamples()
        {
            List<Examples> toReturn = new();
            var examples = await _context.Examples.ToListAsync();
            var languages = await _context.Languages.ToListAsync();
            var frameworks = await _context.Frameworks.ToListAsync();
            var operatingSytesms = await _context.OperatingSystems.ToListAsync();
            var images = await _context.Images.ToListAsync();
            examples.ForEach((x) =>
            {
                var tempL = languages.Where(y => x.Id == y.ExampleId).ToList();
                var tempF = frameworks.Where(y => x.Id == y.ExampleId).ToList();
                var tempO = operatingSytesms.Where(y => x.Id == y.ExampleId).ToList();
                var tempI = images.Where(y => x.Id == y.ExampleId).ToList();
                toReturn.Add(new Examples(x, tempL, tempF, tempO, tempI));
            });
            return toReturn;
        }


        [HttpPost]
        public bool Any()
        {
            return true;
        }

        private bool ExampleExists(int id)
        {
            return _context.Examples.Any(e => e.Id == id);
        }
    }
}
