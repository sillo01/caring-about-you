namespace notebook.entity
{
    public class Person
    {
        private Collection<Idea> Toughs { get; }

        public Person GetByReference(string ref)
        {
            throw new NotImplementedException(
                "A way to retrieve a person by code was not found");
        }

        public bool DoThinkAbout(Person person)
        {
            return this
                .Toughs
                .Any(t => t.Contains(person));
        }
    }
}