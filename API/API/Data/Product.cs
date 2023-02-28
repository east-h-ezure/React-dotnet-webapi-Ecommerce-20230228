namespace API.Data
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string Type { get; set; }
        public string Brand { get; set; }
        public string PictureUrl { get; set; }
        public int QuantiryInStock { get; set; }

    }
}
