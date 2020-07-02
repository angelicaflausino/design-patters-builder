namespace BuilderApp
{
    public class HtmlBuilder
    {
        private readonly string rootName;
        HtmlElement Root = new HtmlElement();

        public HtmlBuilder(string rootName)
        {
            this.rootName = rootName;
            Root.Name = rootName;
        }

        public void AddChild(string childName, string childText)
        {
            var e = new HtmlElement(childName, childText);
            Root.Elements.Add(e);
        }
        
        //Utilizando FluentBuilder

        public HtmlBuilder AddChildFluent(string childName, string childText)
        {
            var e = new HtmlElement(childName, childText);
            Root.Elements.Add(e);
            return this;
        }

        public override string ToString()
        {
            return Root.ToString();
        }

        public void Clear()
        {
            Root = new HtmlElement{Name = rootName};
        }
    }
}