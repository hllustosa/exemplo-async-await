using async_await_example.Domain;
using System.Threading.Tasks;

namespace async_await_example.Repositories
{
    public interface IRepository
    {
        CompleteAddress GetAddressInfo(string cep);
    }

    public interface IRepositoryAsync
    {
        Task<CompleteAddress> GetAddressInfo(string cep);
    }
}
