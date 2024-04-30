using City.Hotel.Generic;

namespace City.Hotel.Domain.Customer.Values.Shared
{
  public class Name : IValueObject<string>
  {
    public string Value { get; private set; }

    private Name( string value )
    {
      if (string.IsNullOrEmpty( value ))
      {
        throw new ArgumentNullException( nameof( Name ), "The name cannot be null" );
      }

      Value = value.Trim();
    }

    public static Name Of( string value )
    {
      return new Name( value );
    }
  }
}
