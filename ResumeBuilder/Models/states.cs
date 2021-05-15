using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ResumeBuilder.Models
{
    public enum states
    {
        [Display(Name = "Andhra Pradesh")]
        AndhraPradesh,
        [Display(Name = "Arunachal Pradesh")]
        ArunachalPradesh,
        Assam,
        Bihar,
        Chhattisgarh,
        Goa,
        Gujarat,
        Haryana,
        [Display(Name = "Himachal Pradesh")]
        HimachalPradesh,
        Jharkhand,
        Karnataka,
        Kerala,
        [Display(Name = "Madhya Pradesh")]
        MadhyaPradesh,
        Maharashtra,
        Manipur,
        Meghalaya,
        Mizoram,
        Nagaland,
        Odisha,
        Punjab,
        Rajasthan,
        Sikkim,
        TamilNadu,
        Telangana,
        Tripura,
        Uttarakhand,
        [Display(Name = "Uttar Pradesh")]
        UttarPradesh,
        [Display(Name = "West Bengal")]
        WestBengal,
    }
}
