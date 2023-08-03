using CriarAPI.WebApi.Contexts;
using CriarAPI.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace CriarAPI.WebApi.Repositories
{
public class LivroRepository
{
private readonly CriarAPIContext _context;
public LivroRepository(CriarAPIContext context)
{
_context = context;
}
public List<Livro> Listar()
{
return _context.Livros.ToList();
}
}
}