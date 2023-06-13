using PostgreSQL.Domain;

namespace PostgreSQL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (LastSportDBContext db = new LastSportDBContext())
            {
                Role admin = new Role
                {
                    role_id = 1,
                    role_name = "admin",
                    change_events = true,
                    change_user = true,
                    commentder_events = true,
                    read_events = true
                };
                User user = new User
                {
                    Id = 1,
                    Role = admin,
                    login = "admin",
                    password = "123",
                    email = "qw@w.e",
                    FIO = "weqwe"
                };

                db.Roles.Add(admin);
                db.Users.Add(user);


                foreach (var u in db.Users.ToList())
                    Console.WriteLine($"{u.FIO}, {u.Role.role_id}");

            }
        }
    }
}