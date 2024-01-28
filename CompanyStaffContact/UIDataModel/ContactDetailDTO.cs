using System;
using System.Collections.Generic;

namespace CompanyStaffContact.UIDataModel
{

    public partial class ContactDetailDTO
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string MiddleInitial { get; set; }

        public string HomePhone { get; set; }

        public string CellPhone { get; set; }

        public string OfficeExtension { get; set; }

        public string IrdNumber { get; set; }

        public int? Status { get; set; }

        public int StaffType { get; set; }

        public int ManagerId { get; set; }

        public string StatusDesCription { get; set; }

        public string StaffCategory { get; set; }
        public ContactStaffTypeDTO StaffTypeNavigation { get; set; }

        public ContactStatusDTO StatusNavigation { get; set; }
    }
}
