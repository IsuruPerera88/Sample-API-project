using StaffContactAPI.Data;

namespace StaffContactAPI.Dto
{
    public class ContactStatusDTO
    {
        public int Id { get; set; }

        public string? StatusDescription { get; set; } 

        public List<ContactDetailDTO>? ContactDetails { get; set; }
    }
}