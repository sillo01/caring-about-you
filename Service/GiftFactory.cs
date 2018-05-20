namespace notebook.service
{
    public class GiftFactory
    {
        public async Task<Gift> CreateGiftAsync(
            Person person, Skill skill, Collection<Feeling> motivation)
        {
            bool ideaAdded = false;

            while(!ideaAdded)
            {
                try
                {
                    person.Ideas.Add(new Idea(motivation));
                    ideaAdded = true;
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Error ocurred while adding idea")
                }
            }
            
            Gift gift = await (Gift)person.CreateDeriverableAsync(skill);

            return gift;
        }
    }
}