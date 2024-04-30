namespace City.Hotel.Generic
{
  public interface IValueObject<T>
  {
    public T Value { get; }
  }
}
