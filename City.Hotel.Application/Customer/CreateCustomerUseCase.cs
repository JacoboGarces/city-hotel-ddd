using City.Hotel.Application.Generics;
using City.Hotel.Domain.Customer.Commands;
using City.Hotel.Domain.Generic;

namespace City.Hotel.Application.Customer
{
  public class CreateCustomerUseCase : IInitialCommandUseCase<CreateCustomerCommand>
  {
    private readonly IEventsRepository _repository;

    public CreateCustomerUseCase( IEventsRepository repository )
    {
      _repository = repository;
    }

    public List<DomainEvent> Execute( CreateCustomerCommand command )
    {
      var customer = new Domain.Customer.Customer( command.Name, command.Email, command.InvitationCode, command.Street, command.District, command.Details, command.Cvc, command.CardName, command.Number, command.ExpirationDate );
      var domainEvents = customer.GetUncommittedChanges().ToList();

      domainEvents.ForEach((DomainEvent domainEvent) =>
      {
        _repository.Save( domainEvent );
      } );

      customer.MarkAsCommitted();
      return domainEvents;
    }
  }
}
