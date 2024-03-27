using TripService.Exception;

namespace TripService.User
{
    public class UserSession
    {
        private static readonly UserSession UserSessionInstance = new();

        private UserSession() { }

        public static UserSession GetInstance()
        {
            return UserSessionInstance;
        }

        public User GetLoggedUser()
        {
            throw new CollaboratorCallException(
                "UserSession.GetLoggedUser() should not be called in an unit test");
        }
    }
}
