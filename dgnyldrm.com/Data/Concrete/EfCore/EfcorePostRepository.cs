using dgnyldrm.com.Data.Abstract;
using dgnyldrm.com.Entity;

namespace dgnyldrm.com.Data.Concrete.EfCore
{
    public class EfcorePostRepository : IPostRepository
    {

        //İnjection yöntemini gelip burada ele alırız.
        private readonly DataBaseContext _context;

        public EfcorePostRepository(DataBaseContext context)
        {
            _context = context;
        }

        public IQueryable<News> _Yazilar => _context.Yazilarim;
    }
}
