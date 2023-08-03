using CriarAPI.WebApi.Models;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
namespace CriarAPI.WebApi.Contexts
{
    public class LivrosContext : DbContext
    {
        public LivrosContext()
        {
        }
        
        public LivrosContext(DbContextOptions<LivrosContext>

        options) : base(options)

        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder

        optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=PC03LAB2018/SQLEXPRESS01;"
                +
                "Database=CriarAPI;Trusted_Connection=True;");


            }
        }
        public DbSet<Livro> Livros { get; set; }
    }
}