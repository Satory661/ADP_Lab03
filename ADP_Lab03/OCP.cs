namespace ADP_Lab03;

{
    public enum CustomerType
    {
        Regular,
        Silver,
        Gold
    }

    public class Customer
    {
        public CustomerType Type { get; set; }
        public double Total { get; set; }
    }

    public interface IDiscount
    {
        double CalculateDiscount(double total);
    }

    public class RegularDiscount : IDiscount
    {
        public double CalculateDiscount(double total)
        {
            return total;
        }
    }

    public class SilverDiscount : IDiscount
    {
        public double CalculateDiscount(double total)
        {
            return total * 0.9;
        }
    }

    public class GoldDiscount : IDiscount
    {
        public double CalculateDiscount(double total)
        {
            return total * 0.8;
        }
    }
}
