using System.Text;
using System;

namespace BuilderApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sem Builder");

            var hello = "hello";

            var sb = new StringBuilder();
            sb.Append("<p>");
            sb.Append(hello);
            sb.Append("</p>");
            Console.WriteLine(sb);

            var words = new[] { "hello", "world" };
            sb.Clear();
            sb.Append("<ul>");
            foreach(var word in words)
            {
                sb.AppendFormat("<li>{0}</li>", word);
            }
            sb.Append("</ul>");
            Console.WriteLine(sb);

            //builder
            Console.WriteLine("Com Builder");
            var builder = new HtmlBuilder("ul");
            builder.AddChild("li", "hello");
            builder.AddChild("li", "world");
            Console.WriteLine(builder.ToString());

            // utilizando fluent builder
            Console.WriteLine("Com Fluent Builder");
            var fluentBuilder = new HtmlBuilder("ul");
            fluentBuilder.AddChildFluent("li", "hello").AddChildFluent("li", "world");
            Console.WriteLine(fluentBuilder.ToString());

            //Fluent Builder Inheritance with Recursive Generics
            var person = Person.New
            .Called("Angélica")
            .WorksAsA("Dev at Softplan")
            .Build();
            
            Console.WriteLine(person);   

            //Function Builder
             Console.WriteLine("Function Builder");
            var personFunctionalBuilder = new PersonFunctionalBuilder()
            .Called("Angélica")
            .WorksAs("Dev at Softplan")
            .Build();

            //Facade Builder
            Console.WriteLine("Facade Builder");
            var pfb = new PersonFacadeBuilder();
            PersonFacade pf = pfb
            .Lives.At("123 London Road").In("London").WithPostCode("SW12NZ")
            .Works.At("Softplan").AsA("Developer").Earning(123456);

            Console.WriteLine(pf);

            //exercicio
            var cb = new Exercise.CodeBuilder("Person").AddField("Name", "string").AddField("Age", "int");
            Console.WriteLine(cb);
        }
    }
}
