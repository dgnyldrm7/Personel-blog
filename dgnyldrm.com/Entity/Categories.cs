using System.ComponentModel.DataAnnotations;

namespace dgnyldrm.com.Entity
{
    public class Categories
    {
        [Key]
        public int? CategoryID { get; set; }
        public string CategoryName { get; set; } = null!;
        public string? Slug { get; set; }



        //Navigation Property : Kategoriler-Yazılar : Many to Many
        public List<News> News { get; set; } = new List<News>();
    }
}
