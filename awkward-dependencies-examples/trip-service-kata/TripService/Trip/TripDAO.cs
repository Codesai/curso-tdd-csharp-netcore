using Microsoft.Data.SqlClient;

namespace TripService.Trip
{
    public class TripDAO
    {
        private const string DatabaseName = "trips";
        private const string User = "phileas";
        private const string Pass = "123456";

        public static List<Trip> FindTripsByUser(User.User user)
        {
            var trips = new List<Trip>();

            var connectionString = $"Server=localhost;Database={DatabaseName};User Id={User};Password={Pass};";
            
            using (var connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    const string sql = "SELECT id FROM trips WHERE [user] = @username";

                    using (var command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@username", user.Name);
                        
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                trips.Add(new Trip(reader.GetString(0)));
                            }
                        }
                    }
                }
                catch (SqlException e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            return trips;
        }
    }
}