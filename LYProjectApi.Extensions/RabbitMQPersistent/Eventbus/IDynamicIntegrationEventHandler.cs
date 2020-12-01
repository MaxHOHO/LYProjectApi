using System.Threading.Tasks;

namespace LYProjectApi.Extensions.RabbitMQPersistent
{
    public interface IDynamicIntegrationEventHandler
    {
        Task Handle(dynamic eventData);
    }
}
