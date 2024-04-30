using City.Hotel.Domain.Generic;

namespace City.Hotel.Domain.Customer.Events
{
  public class GuestAdded : DomainEvent
  {
    public string Name { get; set; }
    public string Email { get; set; }
    public string InvitationCode { get; set; }

    public GuestAdded( string name,
                            string email,
                            string invitationCode ) : base( EventsEnum.GUEST_ADDED.ToString() )
    {
      Name = name;
      Email = email;
      InvitationCode = invitationCode;
    }
  }
}
