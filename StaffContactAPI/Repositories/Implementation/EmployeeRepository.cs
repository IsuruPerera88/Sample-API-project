
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using StaffContactAPI.Data;
using StaffContactAPI.Dto;
using StaffContactAPI.Dto.Enum;
using StaffContactAPI.Repositories.Interfaces;

namespace StaffContactAPI.Repositories.Implementation
{
    public class EmployeeRepository : IEmployee
    {
        private readonly StaffContactManagementContext _dbContext;
        private IMapper _mapper;

        public EmployeeRepository(StaffContactManagementContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public int CreateEmployee(ContactDetailDTO employeeContactDetail)
        {
            try
            {
                int result = -1;
                if (employeeContactDetail != null)
                {
                    ContactDetail contactDetail = _mapper.Map<ContactDetail>(employeeContactDetail);
                    _dbContext.ContactDetails.Add(contactDetail);
                    _dbContext.SaveChanges();
                    result = contactDetail?.Id ?? 0 ;
                }
                else
                {
                    result = 0;
                }
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public int DeleteEmployee(int id)
        {
            try
            {
                if (id == 0)
                {
                    return -1;
                }
                var x = _dbContext.ContactDetails.Where(x => x.Id == id).FirstOrDefault();
                if (x != null)
                {
                    _dbContext.ContactDetails.Remove(x);
                    _dbContext.SaveChanges();
                    return x.Id;
                }
                return 0;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public IEnumerable<ContactDetailDTO> GetAllEmployeeContactDetails()
        {
            try
            {
                List<ContactDetailDTO> employeeContactDetails = new List<ContactDetailDTO>(); 
                var data = _dbContext.ContactDetails.Where(x=>x.Status == (int)EnumStatus.Active).OrderBy(y=>y.FirstName).ToList();
                if (data.Count > 0)
                {
                    employeeContactDetails = _mapper.Map<List<ContactDetailDTO>>(data);
                    
                }

                return employeeContactDetails;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public IEnumerable<ContactDetailDTO> GetAllManagersContactDetails()
        {
            try
            {
                List<ContactDetailDTO> employeeContactDetails = new List<ContactDetailDTO>();
                var data = _dbContext.ContactDetails.Where(x => x.Status == (int)EnumStatus.Active && x.StaffType == (int)EnumStaffType.Manager).ToList();
                if (data.Count > 0)
                {
                    employeeContactDetails = _mapper.Map<List<ContactDetailDTO>>(data);

                }

                return employeeContactDetails;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public ContactDetailDTO GetEmployeeById(int id)
        {
            try
            {
                ContactDetailDTO employeeContactDetail = new ContactDetailDTO();
                var data = _dbContext.ContactDetails.Where(x => x.Id == id).FirstOrDefault() ?? null;
                if (data != null)
                {
                    employeeContactDetail.Id = data.Id;
                }
                
                return employeeContactDetail;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public int UpdateEmployee(ContactDetailDTO employeeContactDetail)
        {
            try
            {
                var data = _dbContext.ContactDetails.Where(x => x.Id == employeeContactDetail.Id).FirstOrDefault() ?? null;
                if (data != null)
                {
                    data.Title = employeeContactDetail.Title;
                    data.FirstName = employeeContactDetail?.FirstName?.ToString();
                    data.LastName = employeeContactDetail?.LastName?.ToString();
                    data.MiddleInitial = employeeContactDetail?.MiddleInitial?.ToString();
                    data.HomePhone = employeeContactDetail?.HomePhone?.ToString();
                    data.CellPhone = employeeContactDetail?.CellPhone?.ToString();
                    data.IrdNumber = employeeContactDetail?.IrdNumber?.ToString();
                    data.OfficeExtension = employeeContactDetail?.OfficeExtension?.ToString();
                    data.StaffType = employeeContactDetail?.StaffType;
                    data.Status = employeeContactDetail?.Status;
                    data.ManagerId = employeeContactDetail?.ManagerId;
                    _dbContext.SaveChanges();
                    return data.Id;
                }
                return -1;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        
    }
}
