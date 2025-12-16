using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<Song> songs = new List<Song>();
        int numberOfSongs = 0;

        try
        {
            if (!int.TryParse(Console.ReadLine(), out numberOfSongs))
            {
                return;
            }

            for (int i = 0; i < numberOfSongs; i++)
            {
                string input = Console.ReadLine();
                string[] parts = input.Split(';');

                if (parts.Length != 3)
                {

                    Console.WriteLine(new InvalidSongException().Message);
                    continue;
                }

                string artist = parts[0];
                string title = parts[1];

                string[] timeParts = parts[2].Split(':');

                if (timeParts.Length != 2 ||
                    !int.TryParse(timeParts[0], out int minutes) ||
                    !int.TryParse(timeParts[1], out int seconds))
                {
                    Console.WriteLine(new InvalidSongLengthException().Message);
                    continue;
                }

                try
                {
                    Song song = new Song(artist, title, minutes, seconds);
                    songs.Add(song);
                    Console.WriteLine("Song added.");
                }
                catch (InvalidSongException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            int totalLengthSeconds = songs.Sum(s => s.TotalSeconds);
            int hours = totalLengthSeconds / 3600;
            int remainingMinutes = (totalLengthSeconds % 3600) / 60;
            int remainingSeconds = totalLengthSeconds % 60;

            Console.WriteLine($"Songs added: {songs.Count}");
            Console.WriteLine($"Playlist length: {hours}h {remainingMinutes}m {remainingSeconds}s");
        }
        catch (Exception ex)
        {

            Console.WriteLine($"Неочікувана системна помилка: {ex.Message}");
        }
    }
}