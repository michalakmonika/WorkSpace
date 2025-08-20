using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace WorkSpace.Domain.Enums;

public enum EmploymentFraction
{
    [Display(Name = "Cały etat")]
    FullTime = 100,

    [Display(Name = "3/4 etatu")]
    ThreeQuarters = 75,

    [Display(Name = "1/2 etatu")]
    HalfTime = 50,

    [Display(Name = "1/4 etatu")]
    QuarterTime = 25,

    [Display(Name = "Inny/nie dotyczy")]
    Other = 1
}