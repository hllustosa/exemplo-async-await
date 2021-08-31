using async_await_example.Domain;
using async_await_example.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace async_await_example.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AddressesController : ControllerBase
    {
        private readonly IRepository Repository;
        private readonly IRepositoryAsync AsyncRepository;

        public AddressesController(IRepository repository, IRepositoryAsync asyncRepository)
        {
            AsyncRepository = asyncRepository;
            Repository = repository;
        }

        [HttpGet]
        public async Task<CompleteAddress> GetAsync([FromQuery] string cep)
        {
            var address = await AsyncRepository.GetAddressInfo(cep);
            return address;
        }

        [HttpGet("sync")]
        public CompleteAddress Get([FromQuery] string cep)
        {
            var address = Repository.GetAddressInfo(cep);
            return address;
        }
    }
}
