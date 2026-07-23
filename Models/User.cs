namespace UserManagementAPI.Models
{
    public class User
    {
        public int Id { get; set; }           // Primary Key
        public string Name { get; set; }      // Username
        public string Email { get; set; }     // User email
        public string Role { get; set; }      // Role: Admin, Staff, etc
    }
}
