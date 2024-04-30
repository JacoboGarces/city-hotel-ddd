using City.Hotel.Generic;

namespace City.Hotel.Domain.Customer.Values.Address
{
  public class AddressId : Identity
  {
    public AddressId() : base() { }

    private AddressId( string value ) : base( value ) { }

    public static AddressId Of( string value )
    {
      return new AddressId( value );
    }
  }
}
