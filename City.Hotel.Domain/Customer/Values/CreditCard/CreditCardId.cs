using City.Hotel.Generic;

namespace City.Hotel.Domain.Customer.Values.CreditCard
{
  public class CreditCardId : Identity
  {
    public CreditCardId() : base() { }

    private CreditCardId( string value ) : base( value ) { }

    public static CreditCardId Of( string value )
    {
      return new CreditCardId( value );
    }
  }
}
