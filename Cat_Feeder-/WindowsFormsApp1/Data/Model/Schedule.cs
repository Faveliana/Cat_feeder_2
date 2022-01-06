using System;

namespace WindowsFormsApp1.Data.Model
{
    public class Schedule
    {
        public Schedule(int id, TimeSpan time)
        {
            Id = id;
            Time = time;
        }

        public int Id { get; }
        public TimeSpan Time { get; }

    }
}