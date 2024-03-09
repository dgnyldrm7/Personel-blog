using dgnyldrm.com.Data.Abstract;
using dgnyldrm.com.Entity;

namespace dgnyldrm.com.Data.Concrete.EfCore
{
    public class EfcoreCategoriesRepository : ICategoriesRepository
    {

        //İnjection yöntemini gelip burada ele alırız.
        private readonly DataBaseContext _context;

        public EfcoreCategoriesRepository(DataBaseContext context)
        {
            _context = context;
        }

        public IQueryable<Categories> _kategoriler => _context.Kategoriler;
    }
}
