using FSH.API.Shared.Events;

namespace FSH.API.Application.Common.Events;

public interface IEventPublisher : ITransientService
{
    Task PublishAsync(IEvent @event);
}