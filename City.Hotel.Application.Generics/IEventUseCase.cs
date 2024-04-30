using City.Hotel.Domain.Generic;

namespace City.Hotel.Application.Generics
{
  public interface IEventUseCase<T> where T : DomainEvent
  {
    List<DomainEvent> Execute( T domainEvent );
  }
}
