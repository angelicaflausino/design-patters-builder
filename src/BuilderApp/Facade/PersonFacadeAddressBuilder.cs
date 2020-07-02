namespace BuilderApp
{
    public class PersonFacadeAddressBuilder : PersonFacadeBuilder
    {
        public PersonFacadeAddressBuilder(PersonFacade person)
        {
            this.Person = person;
        }

        public PersonFacadeAddressBuilder At(string streetAddress)
        {
            Person.StreetAddress = streetAddress;
            return this;
        }

        public PersonFacadeAddressBuilder WithPostCode(string postCode)
        {
            Person.PostCode = postCode;
            return this;
        }

        public PersonFacadeAddressBuilder In(string city)
        {
            Person.City = city;
            return this;
        }
    }
}