namespace Products.Domain.Products
{
    public class Product
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Id { get; set; }
        public List<Image> Images { get; set; } = new List<Image>();
    }
    public class Image
    {
        public string Name { get; set; }
        public byte Img { get; set; }
    }
}
