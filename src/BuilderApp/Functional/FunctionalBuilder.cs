using System;
using System.Collections.Generic;
using System.Linq;

namespace BuilderApp
{
    //Tornando o PersonFunctionalBuilder mais genérico
    public abstract class FunctionalBuilder<S, T> 
     where T: FunctionalBuilder<S, T>
     where S : new()
    {
        private readonly List<Func<Person, Person>> actions = new List<Func<Person, Person>>();

        public T Called(string name) => Do(p => p.Name = name);

        public T Do(Action<Person> action) => AddAction(action);

        public Person Build() => actions.Aggregate(new Person(), (p, f) => f(p));

        private T AddAction(Action<Person> action)
        {
            actions.Add(p => 
            { 
                action(p);
                return p;
            });
            return (T)this;
        }
    }
}