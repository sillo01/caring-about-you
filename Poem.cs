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
                    var mainSkill = me
                        .Skills
                        .OrderByDescending(s => s.Profficency)
                        .First();
                }
            }
        }
    }
}