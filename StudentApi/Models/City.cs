using System.ComponentModel.DataAnnotations.Schema;

namespace StudentApi.Models
{
    public class City : BaseModels
    {
        public string CityName { get; set; }
        public int? CountryId { get; set; }
        [ForeignKey("CountryId")]
        public Country Country { get; set; }

    }
}
