using System;

public class InvalidSongException : Exception
{
    private const string DefaultMessage = "Invalid song.";

    public InvalidSongException()
        : base(DefaultMessage)
    {
    }

    public InvalidSongException(string message)
        : base(message)
    {
    }
}
