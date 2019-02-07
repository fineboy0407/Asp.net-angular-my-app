﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngularCoreGym.ViewModels
{
    public class MemberRegistrationViewModel
    {
        public long MemberId { get; set; }

        [DisplayName("First Name")]
        [Required(ErrorMessage = "Please enter First Name")]
        public string MemberFName { get; set; }
        [DisplayName("Last Name")]
        [Required(ErrorMessage = "Please enter Last Name")]
        public string MemberLName { get; set; }
        [DisplayName("Middle Name")]
        [Required(ErrorMessage = "Please enter Middle Name")]
        public string MemberMName { get; set; }

        [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DisplayName("Birth Date")]
        [Required(ErrorMessage = "Please select Birth Date")]
        public DateTime? Dob { get; set; }

        [Required(ErrorMessage = "Please select Birth Date")]
        public string Age { get; set; }

        [Required(ErrorMessage = "Please enter Contactno")]
        public string Contactno { get; set; }

        [Required(ErrorMessage = "Please enter EmailID")]
        public string EmailId { get; set; }

        public int? Gender { get; set; }

        [DisplayName("Plan")]
        public int? PlanID { get; set; }

        [DisplayName("Workouttype")]
        public int? SchemeID { get; set; }

        [DisplayName("Joining Date")]
        [Required(ErrorMessage = "Please select Joining Date")]
        [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? JoiningDate { get; set; }

        [Required(ErrorMessage = "Please enter Address")]
        public string Address { get; set; }
        
        [Required(ErrorMessage = "Amount Cannot be Empty")]
        public Decimal? Amount { get; set; }

        public string SchemeName { get; set; }

        public string PlanName { get; set; }

    }
}
