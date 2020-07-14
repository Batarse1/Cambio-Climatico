using System;
using System.Collections.Generic;
using Cambio_Climático.Controllers;
using Cambio_Climático.Models;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Cambio_Climático.Pages
{
    public class GraphicsModel : PageModel
    {
        public List<Central> centrales { get; private set; }
        public void OnGet()
        {
            centrales = CentralController.CentralList();
        }
    }
}