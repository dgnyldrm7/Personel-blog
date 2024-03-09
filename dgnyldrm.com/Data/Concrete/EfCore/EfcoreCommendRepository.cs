using dgnyldrm.com.Data.Abstract;
using dgnyldrm.com.Entity;

namespace dgnyldrm.com.Data.Concrete.EfCore
{
    public class EfcoreCommendRepository : ICommendRepository
    {

        //injection yöntemini burada da yapalım!
        private readonly DataBaseContext _context;

        public EfcoreCommendRepository(DataBaseContext context)
        {
            _context = context;
        }

        public IQueryable<Comments> _yorumlar => _context.Yorumlar;

        public void CreateComment(Comments comment)
        {
            _context.Yorumlar.Add(comment);
            _context.SaveChanges();
        }
    }
}
