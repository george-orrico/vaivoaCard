using Microsoft.EntityFrameworkCore;
using vaivoaCard.Models;

namespace vaivoaCard.Data
{
    public class DataContext : DbContext
    {
        //Defini��es do Banco e Tabelas (Utilizando EntityFrameworkCore.InMemory)
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
            {
            }
        public DbSet<Card> Cards { get; set; }
    }
}