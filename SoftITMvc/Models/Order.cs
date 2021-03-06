﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SoftITMvc.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    public partial class Order
    {
        public int OrderId { get; set; }
        [Display(Name = "Megrendelő e-mail címe")]
        [Required]
        public string ProcurerId { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string Tel { get; set; }
        [Display(Name = "Megrendelő cég/személy neve")]
        [Required]
        public string ProcurerName { get; set; }
        [DataType(DataType.MultilineText)]
        [Display(Name = "Leírás")]
        [Required]
        public string Description { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Határidő")]
        public string Deadline { get; set; }
        [DataType(DataType.MultilineText)]
        [Display(Name = "Megjegyzés")]
        public string Remark { get; set; }
        [Display(Name = "Projekt neve")]
        [Required]
        public string ProjectName { get; set; }
    }
}
