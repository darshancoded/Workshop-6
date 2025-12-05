using System;
using System.Collections.Generic;
using System.Linq;

class CashierSales
{
    public string CashierName { get; set; }
    public double Sales { get; set; }
}

class AggregationDemo
{
    public static void Run()
    {
        List<CashierSales> salesList = new List<CashierSales>
        {
            new CashierSales { CashierName = "Alice", Sales = 250.5 },
            new CashierSales { CashierName = "Bob", Sales = 400.0 },
            new CashierSales { CashierName = "Charlie", Sales = 150.25 }
        };

        Console.WriteLine("=== Aggregation Operators ===");
        Console.WriteLine($"Total Cashiers: {salesList.Count()}");
        Console.WriteLine($"Total Sales: {salesList.Sum(c => c.Sales)}");
        Console.WriteLine($"Highest Sales: {salesList.Max(c => c.Sales)}");
        Console.WriteLine($"Lowest Sales: {salesList.Min(c => c.Sales)}");
        Console.WriteLine($"Average Sales: {salesList.Average(c => c.Sales)}");
        Console.WriteLine();
    }
}