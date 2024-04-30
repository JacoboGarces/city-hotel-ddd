using City.Hotel.Domain.Customer.Values.Address;
using City.Hotel.Generic;

namespace City.Hotel.Domain.Customer.Entities
{
  public class Address : Entity<AddressId>
  {
    public Street Street { get; private set; }
    public District District { get; private set; }
    public Details Details { get; private set; }

    private Address( Street street, District district, Details details ) : base( new AddressId() )
    {
      Street = street;
      District = district;
      Details = details;
    }

    public static Address From( string street, string district, string details )
    {
      return new Address( Street.Of( street ),
                          District.Of( district ),
                          Details.Of( details ) );
    }
  }
}
