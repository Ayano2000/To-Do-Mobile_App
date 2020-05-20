using System.ComponentModel.DataAnnotations.Schema;

namespace To_Do_Application.DTO
{
    public class Task
    {
        // Primary key
        public int Id { get; set; }
        
        // Foreign key
        [ForeignKey("List")]
        public int ListId { get; set; }
        [ForeignKey("Schedule")]
        public int ScheduleId { get; set; }
        [ForeignKey("Priority")]
        public int PriorityId { get; set; }
        
        // List details
        public string name { get; set; }
        public string description { get; set; }    
    }
}