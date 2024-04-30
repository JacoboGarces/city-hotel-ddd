using City.Hotel.Generic;

namespace City.Hotel.Domain.Customer.Values.Address
{
  public class District : IValueObject<string>
  {
    public string Value { get; private set; }

    private District( string value )
    {
      if (string.IsNullOrEmpty( value ))
      {
        throw new ArgumentNullException( nameof( District ), "The district cannot be null" );
      }

      Value = value.Trim();
    }

    public static District Of( string value )
    {
      return new District( value );
    }
  }
}
