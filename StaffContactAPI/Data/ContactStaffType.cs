using System;
using System.Collections.Generic;

namespace StaffContactAPI.Data;

public partial class ContactStaffType
{
    public int Id { get; set; }

    public string? TypeDescription { get; set; }

    public virtual ICollection<ContactDetail> ContactDetails { get; set; }
}
