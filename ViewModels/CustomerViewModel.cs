using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ArdalanAraghi_CRUD.ViewModels
{
    public class CustomerViewModel
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        [Column(TypeName = "date")]
        public DateTime DateOfBirth { get; set; }
        [Required(ErrorMessage = "Please enter a mobile number.")]
        [RegularExpression("09[0-9]{9}", ErrorMessage = "Please enter a valid mobile number. For exapmle: 09123456789")]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "Please enter a valid email.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please enter a bank account number.")]
        [RegularExpression("[0-9]{16}",ErrorMessage = "Please enter a valid 16-digit bank account number.")]
        public string BankAccountNumber { get; set; }
    }
}
