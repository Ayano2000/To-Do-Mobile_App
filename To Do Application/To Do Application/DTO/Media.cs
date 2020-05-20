using System.ComponentModel.DataAnnotations.Schema;
using System.IO;

namespace To_Do_Application.DTO
{
    public class Media
    {
        // Primary key
        public int Id { get; set; }
        
        // Foreign key
        [ForeignKey("Task")]
        public int TaskId { get; set; }
        
        // Media details
        public string name { get; set; }
        public string description { get; set; }
        public Stream media { get; set; }
        
    }
}