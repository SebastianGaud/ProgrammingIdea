namespace TaxCalculatorLib
{
    public static class TaxUtility
    {
        public static double AddTaxToPrice(double price, double tax)
            => price = price + ((price / 100)*tax);
    }
}