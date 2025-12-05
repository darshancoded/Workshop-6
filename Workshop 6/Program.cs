using System;
using System.Drawing;

class Program
{
    static void Main(string[] args)
    {
        Rectangle rect = new Rectangle();

        rect.Length = 10;
        rect.Breadth = 5;

        Console.WriteLine(rect.ShowDetails());
        Console.WriteLine($"Area: {rect.GetArea()}");
        Console.WriteLine($"Perimeter: {rect.GetPerimeter()}");

        // --------------------------
        // Using the Calculate Delegate
        // --------------------------
        Calculate add = MathOperations.Add;
        Calculate subtract = MathOperations.Subtract;

        Console.WriteLine("Add: " + add(10, 5));
        Console.WriteLine("Subtract: " + subtract(10, 5));


        // --------------------------
        // Using DiscountStrategy Delegate
        // --------------------------
        double price = 1000;

        DiscountStrategy festival = Discounts.FestivalDiscount;
        DiscountStrategy seasonal = Discounts.SeasonalDiscount;
        DiscountStrategy noDiscount = Discounts.NoDiscount;

        Console.WriteLine("\nFestival Discount: " + festival(price));
        Console.WriteLine("Seasonal Discount: " + seasonal(price));
        Console.WriteLine("No Discount: " + noDiscount(price));


        // -----------------------------------------
        // 2.2 Calling CalculateFinalPrice one by one
        // -----------------------------------------

        Console.WriteLine("Festival Discount Final Price: " +
            Discounts.CalculateFinalPrice(price, Discounts.FestivalDiscount));

        Console.WriteLine("Seasonal Discount Final Price: " +
            Discounts.CalculateFinalPrice(price, Discounts.SeasonalDiscount));

        Console.WriteLine("No Discount Final Price: " +
            Discounts.CalculateFinalPrice(price, Discounts.NoDiscount));


        // -----------------------------------------
        // 2.3 Calling with Lambda Expression (30% off)
        // -----------------------------------------

        Console.WriteLine("Lambda 30% Discount Final Price: " +
            Discounts.CalculateFinalPrice(price, p => p * 0.70));



        // --------------------------
        // Task 3 : Built-in Delegate
        // --------------------------

        int[] nums = { 2, 5, 12, 7, 20, 3, 18 };

        Console.WriteLine("\nEven Numbers:");
        NumberProcessor.ProcessNumbers(nums, n => n % 2 == 0);

        Console.WriteLine("\nNumbers Greater Than 10:");
        NumberProcessor.ProcessNumbers(nums, n => n > 10);


        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

        var squared = numbers.Select(n => n * n);

        Console.WriteLine("Squared Numbers:");
        foreach (var num in squared)
        {
            Console.WriteLine(num);
        }


        // 2. Filtering Premium Books
        List<Book> books = new List<Book>
{
    new Book { Title = "C# Programming", Price = 1200 },
    new Book { Title = "Database Systems", Price = 950 },
    new Book { Title = "AI Fundamentals", Price = 1500 },
    new Book { Title = "Web Development", Price = 800 }
};

        var premiumBooks = books.Where(b => b.Price > 1000);

        Console.WriteLine("\nPremium Books (Price > 1000):");
        foreach (var b in premiumBooks)
        {
            Console.WriteLine($"{b.Title} - Rs. {b.Price}");
        }
        // 3. Sorting Students Alphabetically
        List<Student> students = new List<Student>
{
            new Student { Name = "Ram" },
            new Student { Name = "Aashish" },
            new Student { Name = "Kriti" },
            new Student { Name = "Binay" },
            new Student { Name = "Sita" },
            new Student { Name = "Milan" },
            new Student { Name = "Puja" },
            new Student { Name = "Dipesh" },
            new Student { Name = "Niraj" },
            new Student { Name = "Anita" }
        };

        var sortedStudents = students.OrderBy(s => s.Name);

        Console.WriteLine("\nSorted Student Names (AAA Scholarship):");
        foreach (var s in sortedStudents)
        {
            Console.WriteLine(s.Name);
        }


        AggregationDemo.Run();
        QuantifierDemo.Run();
        ElementDemo.Run();
        TourDemo.Run();
    }
}