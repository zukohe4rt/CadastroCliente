using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CadastroCliente.Data;
using CadastroCliente.Models;

namespace CadastroCliente.Pages.Clientes
{
    public class DetailsModel : PageModel
    {
        private readonly CadastroCliente.Data.CadastroClienteContext _context;

        public DetailsModel(CadastroCliente.Data.CadastroClienteContext context)
        {
            _context = context;
        }

      public Cliente Cliente { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Cliente == null)
            {
                return NotFound();
            }

            var cliente = await _context.Cliente.FirstOrDefaultAsync(m => m.Id == id);
            if (cliente == null)
            {
                return NotFound();
            }
            else 
            {
                Cliente = cliente;
            }
            return Page();
        }
    }
}
