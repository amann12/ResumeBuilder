using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ResumeBuilder.Models
{
    public class PersonEducation
    {
        public string XSchoolName { get; set; }
        [Display(Name = "Xth Passing Year")]
        [Required(ErrorMessage = "Xth Passing Year is required.")]
        [DataType(DataType.Date)]
        public DateTime XPassingYear { get; set; }
        public long XBoardRollNumber { get; set; }
        public string XBoard { get; set; }
        public float XPercentage { get; set; }

        public string XIISchoolName { get; set; }
        [Display(Name = "XIIth Passing Year Required")]
        [Required(ErrorMessage = "XIIth Passing Year is required.")]
        [DataType(DataType.Date)]
        public DateTime XIIPassingYear { get; set; }
        public long XIIBoardRollNumber { get; set; }
        public string XIIBoard { get; set; }
        public float XIIPercentage { get; set; }

        public string UniversityName { get; set; }
        public string CollegeName{ get; set; }
        public long EnrollNumber { get; set; }
        [Display(Name = "Passing Year")]
        [Required(ErrorMessage = "Passing Year is required.")]
        [DataType(DataType.Date)]
        public DateTime UPassingYear { get; set; }
        public float ObtainedPercentage { get; set; }
        public string CourseName { get; set; }

        public string InstitutionName { get; set; }
        public states? InstitutionState{ get; set; }
        public float ObtainedMarks{ get; set; }
        public string CertificateName{ get; set; }
        [Display(Name = "Passing Year")]
        [Required(ErrorMessage = "Passing Year is required.")]
        [DataType(DataType.Date)]
        public DateTime CPassingYear{ get; set; }
    }
}
