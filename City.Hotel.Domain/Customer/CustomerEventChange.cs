using City.Hotel.Domain.Customer.Entities;
using City.Hotel.Domain.Customer.Events;
using City.Hotel.Domain.Customer.Values.Guest;
using City.Hotel.Domain.Customer.Values.Shared;
using City.Hotel.Domain.Generic;

namespace City.Hotel.Domain.Customer
{
  public class CustomerEventChange : EventChange
  {
    public CustomerEventChange( Customer customer )
    {
      AddSub( ( CustomerCreated domainEvent ) =>
      {
        customer.Guest = [];
        customer.Name = Name.Of( domainEvent.Name );
        customer.InvitationCode = InvitationCode.Of( domainEvent.InvitationCode );
        customer.Email = Email.Of( domainEvent.Email );
        customer.Address = Address.From( domainEvent.Street, domainEvent.District, domainEvent.Details );
        customer.CreditCard = CreditCard.From( domainEvent.Cvc, domainEvent.Name, domainEvent.Number, domainEvent.ExpirationDate );
      } );

      AddSub( ( GuestAdded domainEvent ) =>
      {
        Guest guest = Guest.From( domainEvent.Name, domainEvent.Email, domainEvent.InvitationCode );

        if (guest.checkInvitationCode( customer.InvitationCode.Value ))
        {
          customer.Guest.Add( guest );
        }
        else
        {
          throw new Exception( "El codigo de invitacion no coincide" );
        }
      } );
    }
  }
}
