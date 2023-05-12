using System.ComponentModel.DataAnnotations.Schema;

namespace StudentApi.Models
{
    public class Address : BaseModels
    {
        public string AddressName { get; set; }
        public string Street { get; set; }
        public string Descripiton { get; set; }
        public int CityId { get; set; }
        [ForeignKey("CityId")]
        public City City { get; set; }
    }
}
