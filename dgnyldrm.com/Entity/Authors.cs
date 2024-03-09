using System.ComponentModel.DataAnnotations;

namespace dgnyldrm.com.Entity
{
    public class Authors
    {
        [Key]
        public int? AuthorID { get; set; }
        public string? AuthorName { get; set; }
        public string AuthorEmail { get; set; } = null!;





        //Navigation property : Yazar-Yazılar : One-To-Many
        public List<News> Yazilar = new List<News>();

    }
}
