namespace notebook
{
    public class Poem
    {
        public static void Main(string[] args)
        {
            var me = Person.GetByReference("me");
            var you = Person.GetByReference("you");

            while(me.DoThinkAbout(you))
            {
                if(Calendar.Today.CelebratedProfession == you.Profession)
                {
                    try
                    {
                        Collection<Skill> myMainSkill = me
                            .Skills
                            .OrderByDescending(s => s.Profficency)
                            .First();

                        Collection<Feeling> myMotivation = me.GetFeelings(you);

                        Gift myGift = GiftFactory
                            .CreateGift(me, myMainSkill, myMotivation)
                            .Result;

                        bool giftAccepted = myGift
                            .SendTo(you)
                            .Result;
                    }
                    catch(PersonNotAvailableException ex)
                    {
                        Console.WriteLine("Do I need to define available?")
                    }
                }
            }
        }
    }
}