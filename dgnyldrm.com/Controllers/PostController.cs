using System.Diagnostics;
using dgnyldrm.com.Data.Abstract;
using dgnyldrm.com.Data.Concrete.EfCore;
using dgnyldrm.com.Entity;
using dgnyldrm.com.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NuGet.Protocol.Core.Types;

namespace dgnyldrm.com.Controllers
{
    public class PostController : Controller
    {

        private IPostRepository _repository;
        private ICategoriesRepository _categoriesRepository;
        private ICommendRepository _commendRepository;


        public PostController(IPostRepository repository, ICategoriesRepository categoriesRepository , ICommendRepository commendRepository)
        {
            _repository = repository;
            _categoriesRepository = categoriesRepository;
            _commendRepository = commendRepository;
        }

        //Burda yazýlarým listelenecek
        public async Task<IActionResult> Index(string Slug)
        {
            var yazilar = _repository._Yazilar;
            var kategoriler = _categoriesRepository._kategoriler;

            

            if (!string.IsNullOrEmpty(Slug))
            {
                yazilar = _repository._Yazilar.Where(x => x.Categories.Any(p => p.Slug == Slug));

            }

            return View(new PostViewModel { Yazilar = await yazilar.ToListAsync() });

        }



        //Yazýlarýn týklanýlýnca detay sayfasý.
        public async Task<IActionResult> Details(string Slug)
        {
                return View( await _repository._Yazilar
                                                       .Include(x => x.Comments)
                                                       .ThenInclude(p => p.YorumcuKisi)
                                                       .FirstOrDefaultAsync(x => x.Slug == Slug) );
        }




        public IActionResult Commend(int PostId,string Email, string userName , string lName ,string Message, string PostUrl)
        {
            var entitiy = new Comments
            {
                NewsID = PostId,
                CommentContent = Message,
                CreatedTime = DateTime.Now,
                YorumcuKisi = new YorumcuKisi
                {
                    YorumcuEmail = Email,
                    YorumcuName = userName,
                    YorumcuLastName = lName,
                }
            };

            _commendRepository.CreateComment(entitiy);

            return Redirect("Index");

        }
    } 

}
