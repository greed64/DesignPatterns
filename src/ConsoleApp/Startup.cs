using DesignPatterns.Builder.Builders;
using Microsoft.Extensions.Hosting;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Startup : IHostedService
    {
        private readonly IPersonBuilder _personBuilder;

        public Startup(IPersonBuilder personBuilder)
        {
            _personBuilder = personBuilder;
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            Builders();

            return Task.CompletedTask;
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }

        void Builders()
        {
            var person = _personBuilder
                .SetPersonalData("John", "Snow", 28)
                .SetAddress("aa", "bb")
                .Build();
        }
    }
}