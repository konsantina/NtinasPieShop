using Microsoft.EntityFrameworkCore;

namespace NtinasPieShop.Models
{
    public class NtinasPieShopDbContext: DbContext
    {
        public NtinasPieShopDbContext(DbContextOptions<NtinasPieShopDbContext>options):base(options) 
        {

        }   

        public DbSet<Category> Categories { get; set; }
        public DbSet<Pie> Pies { get; set; }

        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }  


    }
}
