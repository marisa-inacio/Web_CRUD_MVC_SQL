using Microsoft.EntityFrameworkCore;

namespace WebCRUDMVCSQL.Models
{
    public class Contexto : DbContext 
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }

        //quais os modelos que queremos que sejam geridos
        public DbSet<Produto> Produto { get; set; }
    }
}
