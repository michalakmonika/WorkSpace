using System.ComponentModel.DataAnnotations;

namespace WorkSpace.Domain.Enums;

public enum AbsenceType
{
    [Display(Name ="Urlop wypoczynkowy")]
    Vacation,

    [Display(Name = "Urlop na żądanie")]
    OnDemandLeave,

    [Display(Name = "Urlop okolicznościowy")]
    SpecialLeave,

    [Display(Name = "Urlop bezpłatny")]
    UnpaidLeave,

    [Display(Name = "Urlop macierzyński")]
    MaternityLeave,

    [Display(Name = "Urlop ojcowski")]
    PaternityLeave,

    [Display(Name = "Urlop rodzicielski")]
    ParentalLeave,

    [Display(Name = "Urlop wychowawczy")]
    ChildcareLeave,

    [Display(Name = "Opieka nad dzieckiem art. 188")]
    ChildCareDays,

    [Display(Name = "Urlop opiekuńczy")]
    CareLeave,

    [Display(Name = "Dni wolne na poszukiwanie pracy")]
    JobSeekingLeave,

    [Display(Name = "Zwolnienie z powodu siły wyższej")]
    ForceMajeureLeave,

    [Display(Name = "Urlop szkoleniowy")]
    TrainingLeave,

    [Display(Name = "Dzień wolny za oddanie krwi")]
    BloodDonationDay,

    [Display(Name = "Zwolnienie lekarskie")]
    SickLeave,

    [Display(Name = "Delegacja")]
    BusinessTrip,

    [Display(Name = "Nieobecność nieusprawiedliwiona")]
    UnexcusedAbsence
}
