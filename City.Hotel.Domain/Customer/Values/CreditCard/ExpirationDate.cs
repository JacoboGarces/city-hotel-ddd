using City.Hotel.Generic;

namespace City.Hotel.Domain.Customer.Values.CreditCard
{
  public class ExpirationDate : IValueObject<DateOnly>
  {
    public DateOnly Value { get; private set; }

    private ExpirationDate( DateOnly value )
    {
      if (value.CompareTo( new DateOnly() ) <= 0)
      {
        throw new ArgumentNullException( nameof( ExpirationDate ), "The expiration date cannot be greater than today" );
      }

      Value = value;
    }

    public static ExpirationDate Of( DateOnly value )
    {
      return new ExpirationDate( value );
    }
  }
}
