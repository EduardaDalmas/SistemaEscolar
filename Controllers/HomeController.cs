using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SistemaEscolar.Data;
using SistemaEscolar.Models;

namespace SistemaEscolar.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
         private readonly appEscolarContext _context;

        public HomeController(ILogger<HomeController> logger, appEscolarContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            IList<Aluno> alunos = _context.Alunos.ToList();
            return View(alunos);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
