using System.Collections.Generic;

namespace WindowsFormsApp1.Data.Model
{
    public class Feeder : FeederBase
    {
        public IEnumerable<Schedule> Schedules { get; } 

        public Feeder(FeederBase feeder, IEnumerable<Schedule> schedules) : base(feeder)
        {
            Schedules = schedules;
        }
    }
}