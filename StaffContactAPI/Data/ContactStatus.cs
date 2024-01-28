using System;
using System.Collections.Generic;

namespace StaffContactAPI.Data;

public partial class ContactStatus
{
    public int Id { get; set; }

    public string StatusDescription { get; set; }

    public virtual ICollection<ContactDetail> ContactDetails { get; set; }
}
