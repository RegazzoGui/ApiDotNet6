

using Api.DotNet6.Domain.Validations;
using System.IO.Pipes;

namespace Api.DotNet6.Domain.Entities
{
    public class Purchase
    {
        public int Id { get; private set; }
        public int ProductId { get; private set; }
        public int PersonId { get; private set; }
        public DateTime Date { get; private set; }

        public Person Person { get; set; }

        public Product Product { get; set; }

        public Purchases(int productId, int personId, DateTime? date)
        {
            Validation(productId, personId, date);

        }
        public Purchase(int id, int productId, int personId, DateTime date)
        {
            DomainValidationException.When(id < 0, "Id deve ser maior que zero!");
            Validation(productId, personId, date);
            Id = id;
        }

        public void Validation(int productId, int personId, DateTime? date)
        {

            DomainValidationException.When(productId < 0, "ProductId deve ser maior que zero!");
            DomainValidationException.When(personId < 0, "RersonId deve ser maior que zero!");
            DomainValidationException.When(!date.HasValue, "A data da compra deve ser informada");

            ProductId = productId;
            PersonId = personId;
            Date = date.Value;
        }
    }
}
