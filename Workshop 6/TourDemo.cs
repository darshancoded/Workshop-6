class TourDemo
{
    public static void Run()
    {
        List<TourBooking> bookings = new List<TourBooking>
        {
            new TourBooking { CustomerName = "Drake", Destination = "Kathmandu", Price = 8000, DurationInDays = 3, IsInternational = false },
            new TourBooking { CustomerName = "Darshan", Destination = "Pokhara", Price = 12000, DurationInDays = 5, IsInternational = false },
            new TourBooking { CustomerName = "Son", Destination = "Thailand", Price = 25000, DurationInDays = 7, IsInternational = true },
            new TourBooking { CustomerName = "Messi", Destination = "Nepalgunj", Price = 15000, DurationInDays = 6, IsInternational = false },
            new TourBooking { CustomerName = "Nirya", Destination = "India", Price = 18000, DurationInDays = 5, IsInternational = true }
        };

        // LINQ Query
        var summaryList = bookings
            .Where(t => t.Price > 10000 && t.DurationInDays > 4)  // Filter
            .Select(t => new TourSummary    // Transform/Project
            {
                CustomerName = t.CustomerName,
                Destination = t.Destination,
                Category = t.IsInternational ? "International" : "Domestic",
                Price = t.Price
            })
            .OrderBy(t => t.Category)       // Sort by Category: Domestic first
            .ThenBy(t => t.Price)           // Sort by Price
            .ToList();

        // Display in clean format
        Console.WriteLine("=== Tour Summary Report ===");
        foreach (var tour in summaryList)
        {
            Console.WriteLine($"Customer: {tour.CustomerName}");
            Console.WriteLine($"Destination: {tour.Destination}");
            Console.WriteLine($"Category: {tour.Category}");
            Console.WriteLine($"Price: Rs. {tour.Price}");
            Console.WriteLine(new string('-', 30));
        }
    }
}