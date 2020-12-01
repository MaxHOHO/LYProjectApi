using RabbitMQ.Client;
using System;

namespace LYProjectApi.Extensions.RabbitMQPersistent
{
    public interface IRabbitMQPersistentConnection
        : IDisposable
    {
        bool IsConnected { get; }

        bool TryConnect();

        IModel CreateModel();
    }
}
