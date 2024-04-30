using City.Hotel.Domain.Customer.Values.Root;
using City.Hotel.Domain.Generic;

namespace City.Hotel.Domain.Customer.Commands
{
  public class AddGuestCommand : Command<CustomerId>
  {
    public string Name { get; set; }
    public string Email { get; set; }
    public string InvitationCode { get; set; }

    public AddGuestCommand( string name,
                            string email,
                            string aggregateId,
                            string invitationCode ) : base( CustomerId.Of( aggregateId ) )
    {
      Name = name;
      Email = email;
      InvitationCode = invitationCode;
    }
  }
}
