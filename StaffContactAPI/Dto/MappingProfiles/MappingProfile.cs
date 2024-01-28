using AutoMapper;
using StaffContactAPI.Data;

namespace StaffContactAPI.Dto.MappingProfiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Add as many of these lines as you need to map your objects
            CreateMap<ContactDetailDTO, ContactDetail>();
            CreateMap<ContactDetail, ContactDetailDTO>();
        }
    }
}
