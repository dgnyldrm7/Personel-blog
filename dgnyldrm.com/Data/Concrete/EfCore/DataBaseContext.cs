using dgnyldrm.com.Entity;
using Microsoft.EntityFrameworkCore;

namespace dgnyldrm.com.Data.Concrete.EfCore
{
    public class DataBaseContext : DbContext
    {

        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {

        }


        public DbSet<Authors> Yazarlar { get; set; }
        public DbSet<Categories> Kategoriler { get; set; }
        public DbSet<Comments> Yorumlar { get; set; }
        public DbSet<News> Yazilarim { get; set; }
        public DbSet<YorumcuKisi> Yorumcular { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<News>()
                .HasData(
                    new News() { NewsID = 1, Title = "Php ile kodlama", Content = "Yazının içeriği 1", CreatedTime = DateTime.Now, IsActive = true, AuthorID = 1 , Slug = "php-ile-kodlama" },
                    new News() { NewsID = 2, Title = "JavaScript ile kodlama", Content = "Yazının içeriği 2", CreatedTime = DateTime.Now, IsActive = true, AuthorID = 1 , Slug = "js-ile-kodlama" },
                    new News() { NewsID = 3, Title = "Python ile kodlama", Content = "Yazının içeriği 3", CreatedTime = DateTime.Now, IsActive = true, AuthorID = 2 , Slug = "python-ile-kodlama" },
                    new News() { NewsID = 4, Title = "C# ile kodlama", Content = "Yazının içeriği 4", CreatedTime = DateTime.Now, IsActive = true, AuthorID = 2 , Slug = "csharp-ile-kodlama"  }

                );


            modelBuilder.Entity<Authors>()
                .HasData(
                    new Authors() { AuthorID = 1, AuthorName = "Doğan", AuthorEmail = "dgnyldrm7@icloud.com" },
                    new Authors() { AuthorID = 2, AuthorName = "Merve", AuthorEmail = "merve7@icloud.com" }
                );


            modelBuilder.Entity<Comments>()
                .HasData(
                    new Comments() {  CommentsId = 1  ,CommentContent= "Gerçekten Çok Beğendim.Sağ olun!" , NewsID = 1  , YorumcuId = 1  },
                    new Comments() {  CommentsId = 2 , CommentContent= "Çok yardımcı oldunuz.Sağ olun !" , NewsID = 1 , YorumcuId = 2  },
                    new Comments() {  CommentsId = 3 ,CommentContent= "Başka örnekler var mı ?" , NewsID = 2  , YorumcuId = 3 },
                    new Comments() {  CommentsId = 4 ,CommentContent= "Çok iyisiniz.Allah yardımcımız olsun bu alanda uzmanlaşmak gerçekten çok zor. HAHAHAHHAHA bu bir test verisi ama ben daha çok şey yazarak aslında bazı şeylere çözüm üretmeye çalışıyorum!!!!!" , NewsID = 3 , CreatedTime = DateTime.Now  , YorumcuId = 4   }
                );


            modelBuilder.Entity<YorumcuKisi>()
               .HasData(
                   new YorumcuKisi() { YorumcuEmail = "dgn@mail.com" , YorumcuName = "Doğan" , YorumcuLastName = "Yıldırım" , YorumcuId = 1  },
                   new YorumcuKisi() { YorumcuEmail = "diyar@mail.com", YorumcuName = "Diyar" , YorumcuLastName = "Ahmet"  , YorumcuId = 2 },
                   new YorumcuKisi() { YorumcuEmail = "kemal@mail.com", YorumcuName = "Kemal" , YorumcuLastName = "Tanca" , YorumcuId = 3 },
                   new YorumcuKisi() { YorumcuEmail = "abc@mail.com", YorumcuName = "Abece" , YorumcuLastName = "Harfes" , YorumcuId = 4 }
               );



            modelBuilder.Entity<Categories>()
                .HasData(
                    new Categories() { CategoryID = 1, CategoryName = "Javascript" , Slug = "Javascript" },
                    new Categories() { CategoryID = 2, CategoryName = "AspCore", Slug = "AspCore" },
                    new Categories() { CategoryID = 3, CategoryName = "Python", Slug = "Python" },
                    new Categories() { CategoryID = 4, CategoryName = "C#", Slug = "C#" },
                    new Categories() { CategoryID = 5, CategoryName = "Php", Slug = "Php" }
                );


        }


    }
}
