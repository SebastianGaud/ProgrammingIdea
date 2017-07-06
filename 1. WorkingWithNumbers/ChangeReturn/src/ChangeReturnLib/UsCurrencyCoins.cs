namespace ChangeReturnLib
{
    public struct UsCurrencyCoin
    {
        private const decimal penny = 0.01M;
        private const decimal nickel = 0.05M;

        private const decimal dime = 0.10M;

        private const decimal quarter = 0.25M;

        private const decimal dollar = 1M;


        public decimal GetPenny()
        {
            return penny;
        }


        public decimal GetNickel()
        {
            return nickel;
        }

        public decimal GetDime()
        {
            return dime;
        }


        public decimal GetQuarter()
        {
            return quarter;
        }

        public decimal GetDollar(){
            return dollar;
        }
    }
}