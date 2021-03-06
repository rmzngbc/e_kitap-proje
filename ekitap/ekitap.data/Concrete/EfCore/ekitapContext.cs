using Microsoft.EntityFrameworkCore;
using ekitap.entity;

namespace ekitap.data.Concrete.EfCore
{
    public class ekitapContext:DbContext
    {
        public DbSet<kitap> kitaplar { get; set; }

        public DbSet<kategori> kategoriler { get; set; }

        public DbSet<yazar> yazarlar { get; set; }

        public DbSet<yayinevi> yayinevleri { get; set; }

        public DbSet<Sepet> Sepets { get; set; }

        public DbSet<SepetItem> SepetItems { get; set; }

        



        
        

       

        protected  override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                //.UseSqlite("Data Source=ekitapDB");
                //.UseMySql(@"server=localhost;port=3306;database=ekitapDbA;user=root;password=rg9030;"); 
                .UseSqlServer(@"Data Source=.\SQLEXPRESS;Initial Catalog=ekitapDB;Integrated Security=SSPI;");
        }

        //--fluent api--kitapyazar entity si için:
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<kitapyazar>()
                .HasKey(i => new { i.yazarId, i.kitapId });
        }


        
    }




}