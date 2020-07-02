using System.Linq;
using System;
using System.Collections.Generic;
namespace BuilderApp
{
    public sealed class PersonFunctionalBuilder
    {
        private readonly List<Func<Person, Person>> actions = new List<Func<Person, Person>>();

        public PersonFunctionalBuilder Called(string name) => Do(p => p.Name = name);

        public PersonFunctionalBuilder Do(Action<Person> action) => AddAction(action);

        public Person Build() => actions.Aggregate(new Person(), (p, f) => f(p));

        private PersonFunctionalBuilder AddAction(Action<Person> action)
        {
            actions.Add(p => 
            { 
                action(p);
                return p;
            });
            return this;
        }
    }
}