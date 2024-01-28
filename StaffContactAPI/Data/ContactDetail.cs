using System;
using System.Collections.Generic;

namespace StaffContactAPI.Data;

public partial class ContactDetail
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? MiddleInitial { get; set; }

    public string? HomePhone { get; set; }

    public string? CellPhone { get; set; }

    public string? OfficeExtension { get; set; }

    public string? IrdNumber { get; set; }

    public int? Status { get; set; }

    public int? StaffType { get; set; }

    public int? ManagerId { get; set; }

    public virtual ContactStaffType? StaffTypeNavigation { get; set; }

    public virtual ContactStatus? StatusNavigation { get; set; }
}
