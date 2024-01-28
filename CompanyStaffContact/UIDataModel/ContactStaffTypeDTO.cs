using System;
using System.Collections.Generic;

namespace CompanyStaffContact.UIDataModel
{

    public partial class ContactStaffTypeDTO
    {
        public int Id { get; set; }

        public string TypeDescription { get; set; }

        public List<ContactDetailDTO> ContactDetails { get; set; } 
    }
}
