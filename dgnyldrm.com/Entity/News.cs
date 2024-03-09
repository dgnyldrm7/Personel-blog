using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dgnyldrm.com.Entity
{
    public class News
    {
        [Key]
        public int NewsID { get; set; }
        public string? Title { get; set; }
        public string? Content { get; set; }
        public DateTime CreatedTime { get; set; }
        public bool IsActive { get; set; }
        public string? Slug { get; set; }




        //Navigation property : Yazar-Yazılar : One-To-Many
        [ForeignKey(nameof(Authors))]
        public int AuthorID { get; set; }
        public Authors Authors { get; set; } = null!;


        //Navigation propert : yorum-yazılar : One - To - Many
        public List<Comments> Comments { get; set; } = new List<Comments>();



        //Navigation Property : Kategoriler-Yazılar : Many to Many
        public List<Categories> Categories { get; set; } = new List<Categories>();

    }
}
