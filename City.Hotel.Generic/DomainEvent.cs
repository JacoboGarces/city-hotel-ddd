﻿namespace City.Hotel.Domain.Generic
{
  public abstract class DomainEvent
  {
    public DateTime Moment { get; private set; }
    public int Version { get; set; }
    public string UUID { get; private set; }
    public string Type { get; private set; }
    public string AggregateName { get; set; }
    public string AggregateId{ get; set; }

    public DomainEvent( string type )
    {
      Type = type;
      Moment = DateTime.Now;
      UUID = Guid.NewGuid().ToString();
      Version = 1;
      AggregateName = string.Empty;
      AggregateId = string.Empty;
    }
  }
}

