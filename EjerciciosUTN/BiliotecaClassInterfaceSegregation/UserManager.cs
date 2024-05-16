namespace BiliotecaClassInterfaceSegregation
{
    public class UserManager : IAddUser, IGetUser
    {
        public void AddUser()
        {
            Console.WriteLine("User added by the manager.");
        }

        public void GetUser()
        {
            Console.WriteLine("Getting user information.");
        }
    }

}
