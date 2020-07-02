namespace BuilderApp
{
    public class PersonJobBuilder<T> : PersonInfoBuilder<PersonJobBuilder<T>>
    where T : PersonJobBuilder<T>
    {
        public T WorksAsA(string position)
        {
            person.Position = position;
            return (T) this;
        }
    }
}