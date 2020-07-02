namespace BuilderApp
{
    public static class PersonFunctionBuilderExtensions
    {
        public static PersonFunctionalBuilder WorksAs(this PersonFunctionalBuilder builder, string position) =>
        builder.Do(p => p.Position = position);
    }
}