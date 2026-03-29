namespace CustomerOnboardingApi.Domain
{
    public class Customer
    {
        public int Id { get; set; } 
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public string Email { get; set; } = "";
        public string PhoneNumber { get; set; } = "";
        public DateTime DateCreated { get; set; } = DateTime.UtcNow;
        public string? Signature { get; set; }


    }
}
