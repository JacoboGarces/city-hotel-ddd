using City.Hotel.Domain.Customer.Values.Guest;
using City.Hotel.Domain.Customer.Values.Shared;
using City.Hotel.Generic;

namespace City.Hotel.Domain.Customer.Entities
{
  public class Guest : Entity<GuestId>
  {
    public Name Name { get; set; }
    public Email Email { get; set; }
    public InvitationCode InvitationCode { get; set; }

    private Guest( Email email, Name name, InvitationCode invitationCode ) : base( new GuestId )
    {
      Email = email;
      Name = name;
      InvitationCode = invitationCode;
    }

    public static Guest From( string email, string name, string invitationCode )
    {
      return new Guest( Email.Of( email ),
                        Name.Of( name ),
                        InvitationCode.Of( invitationCode ) );
    }

    public bool checkInvitationCode( string invitationCode )
    {
      return InvitationCode.Value.Equals( invitationCode );
    }
  }
}
