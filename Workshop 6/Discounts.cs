public delegate double DiscountStrategy(double price);

public class Discounts
{
    public static double FestivalDiscount(double price) => price * 0.80;   // 20% off

    public static double SeasonalDiscount(double price) => price * 0.90;   // 10% off

    public static double NoDiscount(double price) => price;                // no discount


    // 2.1 CalculateFinalPrice Method
    public static double CalculateFinalPrice(double originalPrice, DiscountStrategy strategy)
        => strategy(originalPrice);




}