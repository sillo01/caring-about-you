namespace notebook.entity
{
    public class Skill
    {
        public string Name { get; }
        public Proficency Proficency { get; }

        private enum Proficency
        {
            Novice = 1,
            Advanced = 2,
            Proficent = 3,
            Expert = 4,
        }
    }
    
}