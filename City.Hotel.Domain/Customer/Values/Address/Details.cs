using City.Hotel.Generic;

namespace City.Hotel.Domain.Customer.Values.Address
{
  public class Details : IValueObject<string>
  {
    public string Value { get; private set; }

    private Details( string value )
    {
      if (string.IsNullOrEmpty( value ))
      {
        throw new ArgumentNullException( nameof( Details ), "The details cannot be null" );
      }

      Value = value.Trim();
    }

    public static Details Of( string value )
    {
      return new Details( value );
    }
  }
}
