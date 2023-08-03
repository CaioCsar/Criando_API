using CriarAPI.WebApi.Models;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
namespace CriarAPI.WebApi.Contexts
{
    public class CriarAPIContext : DbContext
    {
        public CriarAPIContext()
        {
        }
        public CriarAPIContext(DbContextOptions<CriarAPIContext>

        options) : base(options)

        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder

        optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // Essa string de conexão foi depende da SUA máquina.
                optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS01;"
                +
                "Database=CriarAPI;Trusted_Connection=True;");


            }
        }
        public DbSet<Livro> Livros { get; set; }
    }
}