using Microsoft.EntityFrameworkCore;
using vaivoaCard.Models;

namespace vaivoaCard.Data
{
    public class DataContext : DbContext
    {
        //Definições do Banco e Tabelas (Utilizando EntityFrameworkCore.InMemory)
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
            {
            }
        public DbSet<Card> Cards { get; set; }
    }
}