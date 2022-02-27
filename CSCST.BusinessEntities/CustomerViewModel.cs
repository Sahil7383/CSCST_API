namespace CSCST.BusinessEntities
{
    public class CustomerViewModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string? LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; } 
        public string PhoneNo { get; set; }
        public string? AlternatePhoneNo { get; set; }
        public string CreatedBy { get; set; } = "Umang Patel";
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool IsActive { get; set; } = true;
    }
}