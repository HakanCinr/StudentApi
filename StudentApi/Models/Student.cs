using System.ComponentModel.DataAnnotations.Schema;

namespace StudentApi.Models
{
    public class Student : BaseModels
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }   
        public string Phone { get; set; }
        public int AddressId { get; set; }
        [ForeignKey("AddressId")]
        public Address Address { get; set; }
    }
}
