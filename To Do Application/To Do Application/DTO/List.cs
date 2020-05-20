using System.ComponentModel.DataAnnotations.Schema;

namespace To_Do_Application.DTO
{
    public class List
    {
        // Primary key
        public int id { get; set; }
        
        // Foreign key
        [ForeignKey("User")]
        public int UserId { get; set; }
        
        // List details
        public string name { get; set; }
        public string description { get; set; }
    }
}