using System.ComponentModel.DataAnnotations;

namespace BlazorCrudApp.Models
{
    public class Customer
    {
        [Key]
        public int AccountId { get; set; } // Database will auto-generate this
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string Email { get; set; }
        public string PhoneNumber { get; set; } = string.Empty;
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? Country { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now; // Automatically set DateCreated to the current local date and time
    }
}
