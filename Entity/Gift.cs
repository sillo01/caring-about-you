namespace notebook.entity
{
    public class Gift
    {
        private bool Integrity { get; }
        public async Task<bool> SendTo(Person person)
        {
            try
            {
                // TODO: validate if gift was accepted
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        public bool Destroy()
        {
            // myLaptop.Burn()?
            // TODO: find less destructive method
            return this.Integrity;
        }
    }
}