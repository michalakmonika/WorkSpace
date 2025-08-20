using System.ComponentModel.DataAnnotations;

namespace WorkSpace.Domain.Enums;

public enum ContractType
{
    [Display(Name = "Umowa o pracę na okres próbny")]
    TrialPeriodEmployment,

    [Display(Name = "Umowa o pracę na czas określony")]
    FixedTermEmployment,

    [Display(Name = "Umowa o pracę na czas nieokreślony")]
    PermanentEmployment,

    [Display(Name = "Umowa o pracę na zastępstwo")]
    ReplacementEmployment,

    [Display(Name = "Umowa zlecenie")]
    MandateContract,

    [Display(Name = "Umowa o dzieło")]
    SpecificTaskContract,

    [Display(Name = "B2B (działalność gospodarcza)")]
    B2BContract
}
