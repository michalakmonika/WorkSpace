namespace WorkSpace.Domain.Entities;

public class PreviousEmployer
{
    public int Id { get; set; }
    public string CompanyName { get; set; } = string.Empty;
    public DateOnly StartDate { get; set; }
    public DateOnly EndDate { get; set; }
    public bool CountsTowardsSeniority { get; set; }
}
