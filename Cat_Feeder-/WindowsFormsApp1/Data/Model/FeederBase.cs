namespace WindowsFormsApp1.Data.Model
{
    public class FeederBase
    {
        public FeederBase(int id, int status, FeederType type)
        {
            Id = id;
            Status = status;
            Type = type;
        }

        public FeederBase(FeederBase feeder)
        {
            Id = feeder.Id;
            Status = feeder.Status;
            Type = feeder.Type;
        }

        public int Id { get; }
        public int Status { get; }

        public FeederType Type { get; }
    }
}