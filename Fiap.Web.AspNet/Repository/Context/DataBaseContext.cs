using Fiap.Web.AspNet.Models;
using Microsoft.EntityFrameworkCore;

namespace Fiap.Web.AspNet.Repository.Context
{
    public class DataBaseContext : DbContext
    {
        // Propriedade que será responsável pelo acesso a tabela de Representantes
        public DbSet<RepresentanteModel> Representante { get; set; }

        public DataBaseContext(DbContextOptions options) : base(options)
        {
        }

        protected DataBaseContext()
        {
        }

    }
}
