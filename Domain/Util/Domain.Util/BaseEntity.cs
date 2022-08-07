using System.Net;
using System.Net.Sockets;

namespace Domain.Util;

public abstract class BaseEntity<T>
{
    public Guid Id { get; protected set; }
    
    public DateTimeOffset Control_DataInc { get; set; }
    
    public DateTimeOffset Control_DataAlter { get; set; }

}