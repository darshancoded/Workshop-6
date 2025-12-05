class Applicant
{
    public string Name { get; set; }
    public int Age { get; set; }
}

class QuantifierDemo
{
    public static void Run()
    {
        List<Applicant> applicants = new List<Applicant>
        {
            new Applicant { Name = "John", Age = 20 },
            new Applicant { Name = "Emma", Age = 17 },
            new Applicant { Name = "Sam", Age = 15 }
        };

        Console.WriteLine("=== Quantifier Operators ===");
        bool anyUnder18 = applicants.Any(a => a.Age < 18);
        bool allAbove16 = applicants.All(a => a.Age > 16);

        Console.WriteLine($"Any applicant under 18? {anyUnder18}");
        Console.WriteLine($"All applicants above 16? {allAbove16}");
        Console.WriteLine();
    }
}