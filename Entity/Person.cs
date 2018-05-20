namespace notebook.entity
{
    public class Person : Interactable
    {
        public string Proffesion { get; }
        public Collection<Skill> Skills { get; }

        private Collection<Idea> Ideas { get; }

        public Person GetByReference(string ref)
        {
            throw new NotImplementedException(
                "A way to retrieve a person by code was not found");
        }

        public bool DoThinkAbout(Interactable interactable)
        {
            return this
                .Ideas
                .Any(t => t.Contains(interactable));
        }

        public Collection<Feeling> GetFeelings(Interactable interactable)
        {
            throw new NotImplementedException(
                "You know that people are complicated, right?");
        }

        public async Task<Deriverable> CreateDeriverable(Skill skill)
        {
            throw new NotImplementedException(
                "So you reached this line");
        }
    }
}