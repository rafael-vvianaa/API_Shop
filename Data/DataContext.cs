using API_SHOP.Models;
using Microsoft.EntityFrameworkCore;

namespace API_SHOP.Data
{

    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
            {

            }


            public DbSet<Produto> Produtos { get; set;}
            public DbSet<Categoria> Categorias { get; set;}
            public DbSet<Usuario> Usuarios { get; set;}

    }

}