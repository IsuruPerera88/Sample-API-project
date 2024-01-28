using StaffContactAPI.Data;

namespace StaffContactAPI.Dto
{
    public class ContactStaffTypeDTO
    {
        public int Id { get; set; }

        public string? TypeDescription { get; set; }

        public List<ContactDetailDTO>? ContactDetails { get; set; } 
    }
}