using System.Data.Entity;

namespace Entity
{
    class BDContext:DbContext
    {
 
        public BDContext():base("PgBD")
        {

        }

        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Filme> Filme { get; set; }
        public DbSet<Diretor> Diretor { get; set; }


        //Definindo o Schema
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("public");
            Database.SetInitializer<DbContext>(null);
            base.OnModelCreating(modelBuilder);
                      
        }

    }
}
