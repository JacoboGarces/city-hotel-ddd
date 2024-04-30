using City.Hotel.Domain.Generic;

namespace City.Hotel.Application.Generics
{
  public interface IInitialCommandUseCase<T> where T : InitialCommand
  {
    List<DomainEvent> Execute( T command );
  }
}
