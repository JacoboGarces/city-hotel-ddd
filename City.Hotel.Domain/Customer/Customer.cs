using City.Hotel.Domain.Customer.Entities;
using City.Hotel.Domain.Customer.Events;
using City.Hotel.Domain.Customer.Values.Guest;
using City.Hotel.Domain.Customer.Values.Root;
using City.Hotel.Domain.Customer.Values.Shared;
using City.Hotel.Domain.Generic;
using City.Hotel.Generic;

namespace City.Hotel.Domain.Customer
{
  public class Customer : AggregateRoot<CustomerId>
  {
    public Name Name { get; set; }
    public Email Email { get; set; }
    public InvitationCode InvitationCode { get; set; }
    public Address Address { get; set; }
    public CreditCard CreditCard { get; set; }
    public List<Guest> Guest { get; set; }

    private Customer( CustomerId identity ) : base( identity )
    {
    }

    public Customer( string name,
                     string email,
                     string invitationCode,
                     string street,
                     string district,
                     string details,
                     short cvc,
                     string cardName,
                     long number,
                     DateOnly expirationDate ) : base( new CustomerId() )
    {
      Subscribe( new CustomerEventChange( this ) );
      AppendEvent( new CustomerCreated( name, email, invitationCode, street, district, details, cvc, cardName, number, expirationDate ) ).Invoke();
    }

    public void AddGuest( string name,
                          string email,
                          string invitationCode )
    {
      AppendEvent( new GuestAdded( name, email, invitationCode ) ).Invoke();
    }

    public static Customer From(string identity, List<DomainEvent> events)
    {
      var customer = new Customer(CustomerId.Of(identity));
      events.ForEach(customer.Apply);
      return customer;
    }
  }
}
