namespace City.Hotel.Application.Customer
{
  using City.Hotel.Application.Generics;
  using City.Hotel.Domain.Customer;
  using City.Hotel.Domain.Customer.Commands;
  using City.Hotel.Domain.Customer.Values.Root;
  using City.Hotel.Domain.Generic;
  using System.Collections.Generic;

  public class AddGuestUseCase : ICommandUseCase<AddGuestCommand, CustomerId>
  {
    private readonly IEventsRepository _repository;

    public AddGuestUseCase( IEventsRepository repository )
    {
      _repository = repository;
    }

    public List<DomainEvent> Execute( AddGuestCommand command )
    {
      var events = _repository.FindByAggregateId( command.AggregateId.Value );
      var customer = Customer.From( command.AggregateId.Value, events );
      customer.AddGuest( command.Name, command.Email, command.InvitationCode );
      var domainEvents = customer.GetUncommittedChanges().ToList();

      domainEvents.ForEach( ( DomainEvent domainEvent ) =>
      {
        _repository.Save( domainEvent );
      } );

      customer.MarkAsCommitted();
      return domainEvents;
    }
  }
}
