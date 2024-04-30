using City.Hotel.Domain.Generic;
using City.Hotel.Generic;

namespace City.Hotel.Application.Generics
{
  public interface ICommandUseCase<T, I> where T : Command<I> where I : Identity
  {
    List<DomainEvent> Execute( T command );
  }
}
