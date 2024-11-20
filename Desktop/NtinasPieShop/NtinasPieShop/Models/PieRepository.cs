using Microsoft.EntityFrameworkCore;

namespace NtinasPieShop.Models
{
    public class PieRepository : IPieRepository
    {

        private readonly NtinasPieShopDbContext _ntinasPieShopDbContext;

            public PieRepository(NtinasPieShopDbContext ntinasPieShopDbContext)
        {
            _ntinasPieShopDbContext = ntinasPieShopDbContext;
        }

      public  IEnumerable<Pie> AllPies
        {
            get
            {
                return _ntinasPieShopDbContext.Pies.Include(c => c.Category);
            }
        }
        public IEnumerable<Pie> PiesOfTheWeek
        { get
            {
                return _ntinasPieShopDbContext.Pies.Include(c => c.Category).Where(p =>
                p.IsPieOfTheWeek);
            }
        }
         public Pie? GetPieById(int pieId)
        {
            return _ntinasPieShopDbContext.Pies.FirstOrDefault(p => p.PieId == pieId);

        }
    }
}