using System.ComponentModel.DataAnnotations;
using AspHomework2.Persistence.Entities;

namespace AspHomework2.Controllers.API.DTOs
{
    public class JobApplicationDto
    {
        [Required(ErrorMessage = "Text přihlášky je povinný.")]
        [DataType(DataType.Text)]
        [StringLength(1000, ErrorMessage = "Text přihlášky nesmí přesáhnout 1000 znaků.")]
        public string Content { get; set; }
        
        [Required(ErrorMessage = "Email je povinný.")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Email je neplatný.")]
        public string Email { get; set; }
        
        [Required(ErrorMessage = "Tel. číslo je povinné")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\+([0-9]){3}(\s[0-9]{3}){3}", ErrorMessage = "Zadejte tel. číslo ve tvaru +XXX XXX XXX XXX")]
        public string Phone { get; set; }
        
        [Required(ErrorMessage = "Životopis je povinný.")]
        public string CvBase64 { get; set; }
        
        public string CvFileName { get; set; }

        [Required(ErrorMessage = "Pole pozice je povinné.")]
        public int? JobPositionId { get; set; } = null;
    }
}