namespace TimeCard.API.Model
{
    public class TimeCode : Enumeration
    {
        public static readonly TimeCode Training = new TimeCode(1, "Training");
        public static readonly TimeCode Meeting = new TimeCode(2, "Meeting");
        public static readonly TimeCode DevWork = new TimeCode(3, "Dev Stuff");
        public static readonly TimeCode AdminStuff = new TimeCode(4, "Admin Stuff");
        public static readonly TimeCode Break = new TimeCode(5, "Break");
        public static readonly TimeCode Meal = new TimeCode(6, "Lunch");
        public static readonly TimeCode Vacation = new TimeCode(7, "Vacation");
        public static readonly TimeCode PTO = new TimeCode(8, "Paid Time Off");

        public TimeCode() { }
        public TimeCode(int ID, string displayName)
            : base(ID, displayName)
        {
        }
    }
}
