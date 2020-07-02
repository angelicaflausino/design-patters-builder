namespace BuilderApp
{
    public class PersonFacadeJobBuilder : PersonFacadeBuilder
    {
        public PersonFacadeJobBuilder(PersonFacade person)
        {
            this.Person = person;
        }

        public PersonFacadeJobBuilder At(string companyName)
        {
            Person.CompanyName = companyName;
            return this;
        }

        public PersonFacadeJobBuilder AsA(string position)
        {
            Person.Position = position;
            return this;
        }

        public PersonFacadeJobBuilder Earning(int amount)
        {
            Person.AnnualIncome = amount;
            return this;
        }
    }
}