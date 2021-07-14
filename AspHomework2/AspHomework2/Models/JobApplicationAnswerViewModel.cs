using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using AspHomework2.Persistence.Entities;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace AspHomework2.Models
{
    public class JobApplicationAnswerViewModel
    {
        [StringLength(1000, ErrorMessage = "Délka odpovědi nesmí přesáhnout 1000 znaků.")]
        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "Pole odpověď je povinné.")]
        [DisplayName("Odpověď")]
        public string Answer { get; set; }
        
        [DisplayName("Přijata")]
        public bool Accepted { get; set; }
        
        [BindNever]
        public JobApplication JobApplication { get; set; }
    }
}