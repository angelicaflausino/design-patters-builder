using System;
namespace BuilderApp.Exercise
{
    public class CodeBuilder
    {
        private readonly string className;
        private ClassElement classElement;

        public CodeBuilder(string name)
        {
            className = name ?? throw new ArgumentNullException(paramName: name);
            classElement = new ClassElement(name);
        }

        public CodeBuilder AddField(string paramName, string paramType)
        {
            classElement.Parameters.Add(new ClassParameter{Name = paramName, Type = paramType});
            return this;
        }  

        public override string ToString()
        {
           return classElement.ToString();
        }      
    }
}