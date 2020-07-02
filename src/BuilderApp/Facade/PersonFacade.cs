namespace BuilderApp
{
    public class PersonFacade
    {
        //address
        public string StreetAddress, PostCode, City;

        //employment
        public string CompanyName, Position;
        public int AnnualIncome;

        public override string ToString()
        {
           return $"{nameof(StreetAddress)}: {StreetAddress}, {nameof(PostCode)}: {PostCode}, {nameof(City)}: {City}, " +
           $"{nameof(CompanyName)} : {CompanyName}, {nameof(Position)}: {Position}, {nameof(AnnualIncome)} : {AnnualIncome}";
        }
    }
}