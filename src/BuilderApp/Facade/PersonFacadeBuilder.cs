namespace BuilderApp
{
    public class PersonFacadeBuilder
    {
        //reference!
        protected PersonFacade Person = new PersonFacade();

        public PersonFacadeJobBuilder Works => new PersonFacadeJobBuilder(Person);
        public PersonFacadeAddressBuilder Lives => new PersonFacadeAddressBuilder(Person);

        //Operador de conversão implicito para a classe PersonFacade
        public static implicit operator PersonFacade(PersonFacadeBuilder pb) => pb.Person;
    }
}