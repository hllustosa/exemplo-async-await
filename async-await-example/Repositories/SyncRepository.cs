using async_await_example.Domain;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace async_await_example.Repositories
{
    public class SyncRepository : IRepository
    {
        public CompleteAddress GetAddressInfo(string cep)
        {
            //Simulando espera por operação de I/O com alta latência
            Task.Delay(3000).Wait();

            //Retornando dados
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
