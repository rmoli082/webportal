namespace TimeCard.API.Model
{
    public class PunchType : Enumeration
    {
        public static readonly PunchType PunchIn = new PunchType(1, "Punch In");
        public static readonly PunchType PunchOut = new PunchType(2, "Punch Out");
        public static readonly PunchType LunchOut = new PunchType(3, "Lunch Out");
        public static readonly PunchType LunchIn = new PunchType(4, "Lunch In");

        public PunchType() { }
        private PunchType(int ID, string _displayName) : base(ID, _displayName)
        {
        }
    }
}
