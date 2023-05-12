using System.ComponentModel.DataAnnotations.Schema;

namespace StudentApi.Models
{
    public class University : BaseModels
    {
        public string Name { get; set; }
        public int CityId { get; set; }
        [ForeignKey("CityId")]
        public City City { get; set; }
    }
}
