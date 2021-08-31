using Microsoft.Extensions.Hosting;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace async_await_example.Services
{
    public class ThreadsCountHostedService : IHostedService, IDisposable
    {
        private Timer _timer;

        public Task StartAsync(CancellationToken stoppingToken)
        {

            _timer = new Timer(DoWork, null, TimeSpan.Zero,
                TimeSpan.FromSeconds(2));

            return Task.CompletedTask;
        }

        private void DoWork(object state)
        {
            Console.WriteLine($"Threads Esperando: {ThreadPool.PendingWorkItemCount}");
        }

        public Task StopAsync(CancellationToken stoppingToken)
        {

            _timer?.Change(Timeout.Infinite, 0);
            return Task.CompletedTask;
        }

        public void Dispose()
        {
            _timer?.Dispose();
        }
    }
}
