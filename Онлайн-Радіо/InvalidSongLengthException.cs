using System;

public class InvalidSongLengthException : InvalidSongException
{
    // Обидва конструктори потрібні для коректного наслідування
    public InvalidSongLengthException()
        : base("Invalid song length.")
    {
    }

    public InvalidSongLengthException(string message)
        : base(message)
    {
    }
}