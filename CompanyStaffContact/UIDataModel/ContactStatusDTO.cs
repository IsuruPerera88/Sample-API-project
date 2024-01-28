using System;
using System.Collections.Generic;

namespace CompanyStaffContact.UIDataModel
{

    public partial class ContactStatusDTO
    {
        public int Id { get; set; }

        public string StatusDescription { get; set; }

        public List<ContactDetailDTO> ContactDetails { get; set; }
    }
}