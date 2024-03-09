using dgnyldrm.com.Data.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace dgnyldrm.com.ViewComponents
{
    public class TagMenuler : ViewComponent
    {


        private ICategoriesRepository _categoriesRepository;
        public TagMenuler(ICategoriesRepository categoriesRepository)
        {
            _categoriesRepository = categoriesRepository;
        }



        public IViewComponentResult Invoke()
        {
            return View(_categoriesRepository._kategoriler.ToList());
        }
    }
}
