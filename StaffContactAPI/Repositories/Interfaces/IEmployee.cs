using StaffContactAPI.Data;
using StaffContactAPI.Dto;

namespace StaffContactAPI.Repositories.Interfaces
{
    public interface IEmployee
    {
        IEnumerable<ContactDetailDTO> GetAllEmployeeContactDetails();
        ContactDetailDTO GetEmployeeById(int id);
        int CreateEmployee(ContactDetailDTO employeeContactDetail);
        int UpdateEmployee(ContactDetailDTO employeeContactDetail);
        int DeleteEmployee(int id);
        IEnumerable<ContactDetailDTO> GetAllManagersContactDetails();
    }
}
