using System;

namespace To_Do_Application.DTO
{
    public class Schedule
    {
        // Primary key
        public int Id { get; set; }

        // Reminder, date and time
        public DateTime date { get; set; }
        public bool reminder { get; set; }
    }
}