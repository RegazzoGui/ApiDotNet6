using Api.DotNet6.Domain.Validations;

namespace Api.DotNet6.Domain.Entities
{
    public sealed class Product
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string CodErp { get; private set; }
        public decimal Price { get; private set; }
        public ICollection<Purchase> Purchase { get; set; }

        public Product(string name, string coderp, decimal price)
        {
            Validation(name, coderp, price);
        }

        public Product(int id, string name, string coderp, decimal price)
        {
            DomainValidationException.When(id < 0, "Id do produto deve ser informado!");

            Id = id;

            Validation(name, coderp, price);
        }

        private void Validation(string name, string coderp, decimal price)
        {
            DomainValidationException.When(string.IsNullOrEmpty(name), "Nome deve ser informado!");
            DomainValidationException.When(string.IsNullOrEmpty(coderp), "CodErp deve ser informado!");
            DomainValidationException.When(price < 0, "O preço deve ser informado!");

            Name = name;
            CodErp = coderp;
            Price = price;
        }
    }
}
