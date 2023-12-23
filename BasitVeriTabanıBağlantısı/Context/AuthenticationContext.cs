using BasitVeriTabanıBağlantısı.DataModel;
using Microsoft.EntityFrameworkCore;

namespace BasitVeriTabanıBağlantısı.Context
{
    public class AuthenticationContext:DbContext
    {
        


        public DbSet<Auth> Auths { get; set; }


        public AuthenticationContext(DbContextOptions<AuthenticationContext> options):base(options)
        {
            


        }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{

        //    // isterseniz bu metodun içerisinden de connectionstring değeri verilebilir.
        //    base.OnConfiguring(optionsBuilder);
        //}
    }
}
