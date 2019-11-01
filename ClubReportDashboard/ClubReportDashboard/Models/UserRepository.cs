using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClubReportDashboard.Models
{
    public class UserRepository : IUserRepository
    {
        public IQueryable<User> Users => new List<User> {
         new User { FirstName = "Jane", LastName = "Doe", PIN = 1234, Preference = 2, UserID = 1, IsAdmin = true, IsPastUser = false }
         }.AsQueryable<User>();
    }
}
