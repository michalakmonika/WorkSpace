using WorkSpace.Domain.Enums;

namespace WorkSpace.Domain.Entities;

public class Employment
{
    public int Id { get; set; }
    public DateOnly StartDate { get; set; }
    public DateOnly? EndDate { get; set; }
    public JobPosition JobPosition { get; set; } = default!;
    public EmploymentFraction EmploymentFraction { get; set; }
    public ContractType ContractType { get; set; } = default!;
    public IEnumerable<Absence> Absences { get; set; } = new List<Absence>();
    public IEnumerable<PreviousEmployer> PreviousEmployers { get; set; } = new List<PreviousEmployer>();
    
    // ilość dni urlopu wypoczynkowego + na żądanie
}