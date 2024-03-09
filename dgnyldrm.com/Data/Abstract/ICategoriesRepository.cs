using dgnyldrm.com.Entity;

namespace dgnyldrm.com.Data.Abstract
{
    public interface ICategoriesRepository
    {
       IQueryable<Categories> _kategoriler {  get; }
    }
}
