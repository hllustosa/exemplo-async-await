using async_await_example.Domain;
using System.Threading.Tasks;

namespace async_await_example.Repositories
{
    public class AsyncRepository : IRepositoryAsync
    {
        public async Task<CompleteAddress> GetAddressInfo(string cep)
        {
            await Task.Delay(3000);

            return new CompleteAddress()
            {
                Address = "Rua dos Bobos nº 0",
                Burrow = "Alcântara",
                City = "Niteroi",
                State = "RJ"
            };
        }
    }
}
