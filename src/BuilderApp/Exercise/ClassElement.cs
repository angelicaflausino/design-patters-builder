using System.ComponentModel;
using System.Text;
using System;
using System.Collections.Generic;

namespace BuilderApp.Exercise
{
    public class ClassElement
    {
        public string Name;
        public List<ClassParameter> Parameters = new List<ClassParameter>();

        public ClassElement(string name)
        {
            Name = name ?? throw new ArgumentNullException(paramName: nameof(name));
        }

        private string ToStringImplementation()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"public class {Name}");
            sb.AppendLine("{");

            foreach(var e in Parameters)
            {
                sb.AppendLine($"    public {e.Type} {e.Name};");
            }

            sb.AppendLine("}");

            return sb.ToString();
        }

        public override string ToString()
        {
            return ToStringImplementation();
        }
    }

    public class ClassParameter
    {
        public string Name;
        public string Type;
    }
}