namespace Domain
{
    public class UserAccount
    {
        public string UserAccountName { get; private set; }

        public UserAccount(string userAccountName)
        {
            UserAccountName = userAccountName;
        }
    }
}