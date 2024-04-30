using City.Hotel.Domain.Generic;

namespace City.Hotel.Domain.Customer.Events
{
  public class CustomerCreated : DomainEvent
  {
    public string Name { get; set; }
    public string Email { get; set; }
    public string InvitationCode { get; set; }
    public string Street { get; set; }
    public string District { get; set; }
    public string Details { get; set; }
    public short Cvc { get; set; }
    public string CardName { get; set; }
    public long Number { get; set; }
    public DateOnly ExpirationDate { get; set; }

    public CustomerCreated( string name,
                            string email,
                            string invitationCode,
                            string street,
                            string district,
                            string details,
                            short cvc,
                            string cardName,
                            long number,
                            DateOnly expirationDate ) : base(EventsEnum.CUSTOMER_CREATED.ToString())
    {
      Name = name;
      Email = email;
      InvitationCode = invitationCode;
      Street = street;
      District = district;
      Details = details;
      Cvc = cvc;
      CardName = cardName;
      Number = number;
      ExpirationDate = expirationDate;
    }
  }
}
