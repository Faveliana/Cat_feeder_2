using System.Collections.Generic;
using System.Linq;

namespace WindowsFormsApp1.Data.Model
{
    public class User : UserBase
    {
        public IEnumerable<Feeder> Feeders { get; set; } = Enumerable.Empty<Feeder>();

        public User(UserBase user, IEnumerable<Feeder> feeders) : base(user)
        {
            Feeders = feeders;
        }
    }
}