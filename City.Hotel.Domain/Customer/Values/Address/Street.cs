using City.Hotel.Generic;

namespace City.Hotel.Domain.Customer.Values.Address
{
  public class Street : IValueObject<string>
  {
    public string Value { get; private set; }

    private Street( string value )
    {
      if (string.IsNullOrEmpty( value ))
      {
        throw new ArgumentNullException( nameof( Street ), "The street cannot be null" );
      }

      Value = value.Trim();
    }

    public static Street Of( string value )
    {
      return new Street( value );
    }
  }
}
