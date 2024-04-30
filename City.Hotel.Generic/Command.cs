using City.Hotel.Generic;

namespace City.Hotel.Domain.Generic
{
  public abstract class Command<T> where T : Identity
  {
    public T AggregateId { get; }

    protected Command( T aggregateId )
    {
      AggregateId = aggregateId;
    }
  }

  public abstract class InitialCommand
  {
  }
}
