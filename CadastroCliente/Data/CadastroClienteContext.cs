using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CadastroCliente.Models;

namespace CadastroCliente.Data
{
    public class CadastroClienteContext : DbContext
    {
        public CadastroClienteContext (DbContextOptions<CadastroClienteContext> options)
            : base(options)
        {
        }

        public DbSet<CadastroCliente.Models.Cliente> Cliente { get; set; } = default!;
    }
}
