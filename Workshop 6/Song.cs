class Song
{
    public string Title { get; set; }
    public int DurationInSeconds { get; set; }  // duration in seconds
}

class ElementDemo
{
    public static void Run()
    {
        List<Song> songs = new List<Song>
        {
            new Song { Title = "Song A", DurationInSeconds = 180 },
            new Song { Title = "Song B", DurationInSeconds = 250 },
            new Song { Title = "Song C", DurationInSeconds = 300 },
            new Song { Title = "Song D", DurationInSeconds = 700 }
        };

        Console.WriteLine("=== Element Operators ===");
        var firstSong = songs.First();
        var lastSong = songs.Last();
        var firstAbove4Min = songs.First(s => s.DurationInSeconds > 240);  // > 4 min
        var firstAbove10Min = songs.FirstOrDefault(s => s.DurationInSeconds > 600);  // > 10 min

        Console.WriteLine($"First Song: {firstSong.Title}");
        Console.WriteLine($"Last Song: {lastSong.Title}");
        Console.WriteLine($"First Song above 4 minutes: {firstAbove4Min.Title}");
        Console.WriteLine($"First Song above 10 minutes: {(firstAbove10Min != null ? firstAbove10Min.Title : "No song found")}");
        Console.WriteLine();
    }
}