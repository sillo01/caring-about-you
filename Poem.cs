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
                            .CreateGiftAsync(me, myMainSkill, myMotivation)
                            .Result;

                        bool giftAccepted = myGift
                            .SendToAsync(you)
                            .Result;

                        if (giftAccepted)
                        {
                            foreach(var feeling in me.GetFeelings(you))
                            {
                                // TODO: remove validation
                                if(!feeling.IsRated)
                                {
                                    Console.WriteLine(feeling);
                                }
                            }
                        }
                        else
                        {
                            myGift.Destroy();
                        }
                    } // Do I need to explain what I mean with "available"?
                    catch(PersonNotAvailableException ex)
                    {
                        // May throw InvalidOperationException
                        me.Ideas
                            .RemoveAll(i => i.Contains(you));
                    }
                }
            }
        }
    }
}