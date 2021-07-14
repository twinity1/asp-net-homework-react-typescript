using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace AspHomework2.Persistence.Entities
{
    public class JobApplication
    {
        public int Id { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string Content { get; set; }
        
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        
        [Required]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }
        
        [Required]
        public string CvFilePath { get; set; }
        
        [Required]
        public int JobPositionId { get; set; }
        
        [Required]
        public virtual JobPosition JobPosition { get; set; }
        
        [BindNever]
        public DateTime Created { get; set; } = DateTime.Now;

        [Required]
        public bool Accepted { get; set; }

        public bool Done { get; set; }

        [DataType(DataType.Text)]
        public string? Answer { get; set; }
        
        [BindNever]
        public DateTime? AnswerCreated { get; set; } 
    }
}