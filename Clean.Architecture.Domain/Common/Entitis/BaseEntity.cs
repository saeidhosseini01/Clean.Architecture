namespace Clean.Architecture.Domain.Common.Entitis
{
    public class BaseEntity : Base
    {
        public int CreateBy { get; set; }
        public int UpdateBy { get; set; }
        public DateTime CreateOn { get; set; }= DateTime.Now;
        public DateTime UpdateOn { get; set; }
    }
}
