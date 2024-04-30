using City.Hotel.Domain.Customer.Values.CreditCard;
using City.Hotel.Domain.Customer.Values.Shared;
using City.Hotel.Generic;

namespace City.Hotel.Domain.Customer.Entities
{
  public class CreditCard : Entity<CreditCardId>
  {
    public Cvc Cvc { get; set; }
    public Name Name { get; set; }
    public Number Number { get; set; }
    public ExpirationDate ExpirationDate { get; set; }

    private CreditCard( Cvc cvc, Name name, Number number, ExpirationDate expirationDate ) : base( new CreditCardId() )
    {
      Cvc = cvc;
      Name = name;
      Number = number;
      ExpirationDate = expirationDate;
    }

    public static CreditCard From( short cvc, string name, long number, DateOnly expirationDate )
    {
      return new CreditCard( Cvc.Of( cvc ),
                             Name.Of( name ),
                             Number.Of( number ),
                             ExpirationDate.Of( expirationDate ) );
    }
  }
}
