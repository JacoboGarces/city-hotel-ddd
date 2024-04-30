using City.Hotel.Generic;

namespace City.Hotel.Domain.Customer.Values.Guest
{
  public class InvitationCode : IValueObject<string>
  {
    public string Value { get; private set; }

    private InvitationCode( string value )
    {
      if (!string.IsNullOrEmpty( value ))
      {
        throw new ArgumentNullException( nameof( InvitationCode ), "The code cannot be null" );
      }

      if (value.Length > 10)
      {
        throw new ArgumentNullException( nameof( InvitationCode ), "The code exceeds the defined limit" );
      }

      Value = value;
    }

    public static InvitationCode Of( string value )
    {
      return new InvitationCode( value );
    }
  }
}
