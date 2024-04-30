using City.Hotel.Generic;

namespace City.Hotel.Domain.Customer.Values.Guest
{
  public class GuestId : Identity
  {
    public GuestId() : base() { }

    private GuestId( string value ) : base( value ) { }

    public static GuestId Of( string value )
    {
      return new GuestId( value );
    }
  }
}
