namespace notebook.entity
{
    public class Person : Thinkable
    {
        public string Proffesion { get; }
        public Collection<Skill> Skills { get; }
        private Collection<Idea> Ideas { get; }

        public Person GetByReference(string ref)
        {
            throw new NotImplementedException(
                "A way to retrieve a person by code was not found");
        }

        public bool DoThinkAbout(Thinkable thinkable)
        {
            return this
                .Ideas
                .Any(t => t.Contains(thinkable));
        }
    }
}