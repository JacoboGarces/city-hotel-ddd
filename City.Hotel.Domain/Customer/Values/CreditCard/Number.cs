using City.Hotel.Generic;

namespace City.Hotel.Domain.Customer.Values.CreditCard
{
  public class Number : IValueObject<long>
  {
    public long Value { get; private set; }

    private Number( long value )
    {
      if (!long.IsPositive( value ))
      {
        throw new ArgumentNullException( nameof( Number ), "The number cannot be less than 0" );
      }

      Value = value;
    }

    public static Number Of( long value )
    {
      return new Number( value );
    }
  }
}
