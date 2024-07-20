using CleanArch.Domain.Entities;

namespace CleanArch.Domain.Interfaces
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product> >GetProducts();

        Task<Product> GetById(int? id);

        void Add(Product product);

        Task Update(Product product);

        void Remove(int productId);

    }
}
