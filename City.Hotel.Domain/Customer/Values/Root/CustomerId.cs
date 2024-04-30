using City.Hotel.Generic;

namespace City.Hotel.Domain.Customer.Values.Root
{
  public class CustomerId : Identity
  {
    public CustomerId() : base() { }

    private CustomerId( string value ) : base( value ) { }

    public static CustomerId Of( string value )
    {
      return new CustomerId( value );
    }
  }
}
