using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dgnyldrm.com.Entity
{
    public class Comments
    {
        [Key]
        public int CommentsId { get; set; }
        public string CommentContent { get; set; } = null!;
        public DateTime CreatedTime { get; set; }


        //Navigation Property - categories:yorumcukisi - one to one
        [ForeignKey(nameof(YorumcuKisi))]
        public int YorumcuId { get; set; }
        public YorumcuKisi YorumcuKisi { get; set; } = null!;





















        //Navigation propert : yorum-yazılar : One - To - Many
        public int NewsID { get; set; }
        public News News { get; set; } = null!;


    }
}
