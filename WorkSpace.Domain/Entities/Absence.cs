using WorkSpace.Domain.Enums;

namespace WorkSpace.Domain.Entities;

public class Absence
{
    public int Id { get; set; }
    public AbsenceType AbsenceType { get; set; }
    public DateOnly From { get; set; }
    public DateOnly To { get; set; }
}
