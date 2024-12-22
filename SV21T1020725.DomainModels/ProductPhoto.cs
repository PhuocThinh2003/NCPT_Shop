namespace SV21T1020725.DomainModels
{
    public class ProductPhoto
    {
        public long PhotoID { get; set; }
        public int ProductID { get; set; }
        public string Photo { get; set; } = string.Empty;
        public string Description { get; set; } =  string.Empty;
        public int DisplayOrder { get; set; }
        public bool IsHidden { get; set; }
    }
}
