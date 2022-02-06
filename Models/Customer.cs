using ArdalanAraghi_CRUD.Services.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ArdalanAraghi_CRUD.Models
{
    public class Customer:IEntity<int>
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        [Column(TypeName = "date")]
        public DateTime DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string BankAccountNumber { get; set; }
    }
}
