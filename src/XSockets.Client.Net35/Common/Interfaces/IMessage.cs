using System.Collections.Generic;
using XSockets.Common.Event.Arguments;

namespace XSockets.Common.Interfaces
{
    public interface IMessage
    {
        IEnumerable<byte> Blob { get; }
        string Data { get; }
        MessageType MessageType { get; }
        string Controller { get; set; }
        string Topic { get; set; }
        T Extract<T>();
        string ToString();
        byte[] ToBytes();
    }
}