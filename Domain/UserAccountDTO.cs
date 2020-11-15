namespace Domain
{
    public class UserAccountDTO
    {
        public string UserAccountName { get; private set; }

        public UserAccountDTO(string userAccountName)
        {
            UserAccountName = userAccountName;
        }
    }
}