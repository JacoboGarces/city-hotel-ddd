using City.Hotel.Generic;

namespace City.Hotel.Domain.Customer.Values.CreditCard
{
  public class Cvc : IValueObject<short>
  {
    private readonly short CVC_MAX_LENGTH = 9999;
    public short Value { get; private set; }

    private Cvc( short value )
    {
      if (!short.IsPositive( value ) && value > CVC_MAX_LENGTH)
      {
        throw new ArgumentNullException( nameof( Cvc ), $"The cvc cannot be less than 0 and greater than {CVC_MAX_LENGTH}" );
      }

      Value = value;
    }

    public static Cvc Of( short value )
    {
      return new Cvc( value );
    }
  }
}
