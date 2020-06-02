using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cambio_Climático.Controllers;
using Cambio_Climático.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Cambio_Climático.Pages
{
    public class IndexModel : PageModel
    {
        public IEnumerable<Estudiante> Estudiante { get; private set; }

        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            Estudiante = EstudianteController.GetEstudiante();
        }
    }
}
