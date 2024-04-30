using City.Hotel.Domain.Generic;

namespace City.Hotel.Application.Generics
{
  public interface IEventsRepository
  {
    DomainEvent Save(DomainEvent domainEvent);
    List<DomainEvent> FindByAggregateId(string aggregateId);
  }
}
