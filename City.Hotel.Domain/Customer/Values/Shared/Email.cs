using City.Hotel.Generic;

namespace City.Hotel.Domain.Customer.Values.Shared
{
  public class Email : IValueObject<string>
  {
    public string Value { get; private set; }

    private Email( string value )
    {
      if (string.IsNullOrEmpty( value ))
      {
        throw new ArgumentNullException( nameof( Email ), "The email cannot be null" );
      }

      Value = value.Trim();
    }

    public static Email Of( string value )
    {
      return new Email( value );
    }
  }
}
