using System.Net;
using WorkSpace.Domain.ValueObjects;

namespace WorkSpace.Domain.Entities;

public class Employee
{
    public int Id { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string? MiddleName { get; set; }
    public string LastName { get; set; } = string.Empty;
    public string Pesel { get; set; } = string.Empty;
    public DateOnly BirthDate { get; set; }
    public ContactData ContactData { get; set; } = default!;
    public EmergencyContact? EmergencyContact { get; set; }
    public int? EmploymentId { get; set; }
    public Employment? Employment { get; set; }

}
