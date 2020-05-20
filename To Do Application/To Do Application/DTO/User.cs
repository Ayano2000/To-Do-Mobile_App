namespace To_Do_Application.DTO
{
    public class User
    {
        // Primary key
        public int Id { get; set; }
        
        // Login credentials
        public string username { get; set; }
        public string password { get; set; }
        
        // User details
        public string name { get; set; }
        public string surname { get; set; }
    }
}