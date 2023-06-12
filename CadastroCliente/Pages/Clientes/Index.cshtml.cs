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
    public class IndexModel : PageModel
    {
        private readonly CadastroCliente.Data.CadastroClienteContext _context;

        public IndexModel(CadastroCliente.Data.CadastroClienteContext context)
        {
            _context = context;
        }

        public IList<Cliente> Cliente { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Cliente != null)
            {
                Cliente = await _context.Cliente.ToListAsync();
            }
        }
    }
}
