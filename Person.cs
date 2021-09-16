namespace InheritanceObjects
{
    public class Person
    {
        protected string Name { get; set; }

        protected Person(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return "Hello! My name is " + Name;
        }
        
        ~Person()
        {
            Name = string.Empty;
        }
    }
}