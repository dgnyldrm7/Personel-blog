using System.ComponentModel.DataAnnotations;

namespace dgnyldrm.com.Entity
{
    public class YorumcuKisi
    {
        [Key]
        public int YorumcuId { get; set; }
        public string? YorumcuName { get; set; }
        public string? YorumcuLastName { get; set; }
        public string? YorumcuFullName()
        {
            return YorumcuName + " " + YorumcuLastName;
        }
        public string? YorumcuEmail { get; set; }

        //Navigation Property - categories:yorumcukisi - one to many

        public List<YorumcuKisi> Yorumlari = new List<YorumcuKisi>();

        public static implicit operator YorumcuKisi(string v)
        {
            throw new NotImplementedException();
        }
    }
}
