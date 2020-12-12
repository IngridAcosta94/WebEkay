using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Ekay.Clases;

namespace EKay.Pages
{
    public class EditarDoc : PageModel
    {

        [BindProperty]
        public DocumentoRequestDto DocumentoRequest { get; set; }
        [BindProperty]
        public AutorRequestDto AutorRequest { get; set; }
        [BindProperty]
        public RemitenteRequestDto RemitenteRequest { get; set; }

        public void OnGet()
        {
        }
    }
}
