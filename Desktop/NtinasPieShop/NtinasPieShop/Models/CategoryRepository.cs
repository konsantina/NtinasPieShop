namespace NtinasPieShop.Models
{
    public class CategoryRepository : ICategoryRepository   
    {
        private readonly NtinasPieShopDbContext _ntinasPieShopDbContext;

        public CategoryRepository(NtinasPieShopDbContext ntinasPieShopDbContext)
        { 
           _ntinasPieShopDbContext = ntinasPieShopDbContext;    
        }

        public IEnumerable<Category> AllCategories =>
            _ntinasPieShopDbContext.Categories.OrderBy(p => p.CategoryName);

    }
}
