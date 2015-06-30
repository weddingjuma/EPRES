//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EPRES.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    public partial class PrescriptionMaster
    {
        public int PrescriptionId { get; set; }

        [Required(ErrorMessage = "Please provide prescriber name", AllowEmptyStrings = false)]
        public string PrecriberName { get; set; }

        [Required(ErrorMessage = "Please provide physician Id", AllowEmptyStrings = false)]
        public string PhysicianId { get; set; }

        [Required(ErrorMessage = "Please provide patient name", AllowEmptyStrings = false)]
        public string PatientName { get; set; }

        [Required(ErrorMessage = "Please provide patient Id", AllowEmptyStrings = false)]
        public string PatientId { get; set; }

        [Required(ErrorMessage = "Please provide diagnosis", AllowEmptyStrings = false)]
        public string Diagnosis { get; set; }

        [Required(ErrorMessage = "Please provide drug name", AllowEmptyStrings = false)]
        public string DrugName { get; set; }

        [Required(ErrorMessage = "Please provide dose", AllowEmptyStrings = false)]
        public string Dose { get; set; }

        [Required(ErrorMessage = "Please provide dose units", AllowEmptyStrings = false)]
        public string DoseUnits { get; set; }

        [Required(ErrorMessage = "Please provide frequency", AllowEmptyStrings = false)]
        public string Frequency { get; set; }

        [Required(ErrorMessage = "Please provide number of days", AllowEmptyStrings = false)]
        public string NumOfDays { get; set; }

        
        public System.DateTime SubmitDate { get; set; }

        public Nullable<System.DateTime> ProcessedDate { get; set; }

        [Required(ErrorMessage = "Please provide allergies", AllowEmptyStrings = false)]
        public string Allergies { get; set; }

        [Required(ErrorMessage = "Please provide comments", AllowEmptyStrings = false)]
        public string Comments { get; set; }

        [Required(ErrorMessage = "Please provide refills", AllowEmptyStrings = false)]
        public string Refills { get; set; }

        [Required(ErrorMessage = "Please provide issue to", AllowEmptyStrings = false)]
        public string IssueTo { get; set; }

        [Required(ErrorMessage = "Please provide pharmacy Id", AllowEmptyStrings = false)]
        public string PharmacyId { get; set; }
    }
}
