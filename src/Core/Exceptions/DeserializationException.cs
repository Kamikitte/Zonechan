namespace Zonechan.Core.Exceptions;

public sealed class DeserializationException : Exception
{
    public DeserializationException(string? message = default) : base(message)
    {
    }
}