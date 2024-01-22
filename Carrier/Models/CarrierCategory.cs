namespace Carrier.Models
{
    public class CarrierCategory
    {
        public int id { get; set; }
        public int DisplayOrder{ get; set; }
        public string Title { get; set; } = string.Empty;

        public string CatergoryType { get; set; } = string.Empty;
        public string MyProperty { get; set; } = string.Empty;
        public string ImageName { get; set; } = string.Empty;
        public string CssStyle { get; set; }=string.Empty;
        public DateTime CreatedOn { get; set; }





 
    }
}
