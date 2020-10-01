using System;

namespace TimeCard.API.Model
{
    public class TimeCards : IAsyncEnumerable
    {
        public int ID { get; set; }
        public int EmployeeID { get; set; }
        public DateTime Date { get; set; }
        public string PunchType { get; set; }
        public string TimeCode { get; set; }

        public TimeCards() { }
       
        public TimeCards(int employeeID)
        {
            EmployeeID = employeeID;
            Date = DateTime.Now;
        }

        public class PunchEvent
        {
            
            public int ID { get; set; }
            public int TimeCode { get; set; } 
            public int PunchType { get; set; }
        }
    }

    public interface IAsyncEnumerable
    {
    }
}
