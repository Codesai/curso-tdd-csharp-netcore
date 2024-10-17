
namespace TripService.User
{
    public class UserSession
    {
        private static readonly UserSession InternalUserSession = new UserSession();
        private static readonly HttpClient HttpClient = new HttpClient();

        private UserSession()
        {
        }

        public static UserSession GetInstance()
        {
            return InternalUserSession;
        }

        public User GetLoggedUser()
        {
            try
            {
                var requestUri = new Uri("https://trip-service.nanana/client-2038/logged-user/");
                var response = HttpClient.GetAsync(requestUri).Result;

                if (response.IsSuccessStatusCode)
                {
                    var name = response.Content.ReadAsStringAsync().Result;
                    if (!string.IsNullOrEmpty(name))
                    {
                        return new User(name);
                    }
                }

                return null;
            }
            catch (System.Exception e)
            {
                throw new System.Exception("Unable to recover session", e);
            }
        }
    }
}