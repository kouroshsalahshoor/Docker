using MvcApp.Models;

namespace MvcApp.Repository
{
    public interface IRepository
    {
        IQueryable<Product> Products { get; }
    }
}
