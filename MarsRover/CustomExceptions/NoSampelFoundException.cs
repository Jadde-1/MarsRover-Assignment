[Serializable]
internal class NoSampelFoundException : Exception
{
    public NoSampelFoundException()
    {
    }

    public NoSampelFoundException(string? message) : base(message)
    {
    }

    public NoSampelFoundException(string? message, Exception? innerException) : base(message, innerException)
    {
    }
}