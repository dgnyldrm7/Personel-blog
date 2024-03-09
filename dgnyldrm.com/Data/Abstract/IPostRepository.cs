using dgnyldrm.com.Entity;

namespace dgnyldrm.com.Data.Abstract
{
    public interface IPostRepository
    {
       IQueryable<News> _Yazilar {  get; }
    }
}
