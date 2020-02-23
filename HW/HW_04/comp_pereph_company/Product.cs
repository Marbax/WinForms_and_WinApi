
namespace comp_pereph_company
{
    public class Product
    {
        public string Name { get; set; }

        public string Specifications { get; set; }

        public string Description { get; set; }

        public decimal Value { get; set; }
        public Product(string name, string specifications, string description, decimal value)
        {
            Name = name;
            Specifications = specifications;
            Description = description;
            Value = value;
        }

    }
}
