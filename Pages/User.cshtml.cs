﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Cambio_Climático.Pages
{
    public class UserModel : PageModel
    {
        public string nombre;
        public void OnGet()
        {
            nombre = nombre1.Value;
        }
    }
}