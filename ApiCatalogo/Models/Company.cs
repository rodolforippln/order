using System.Text.Json.Serialization;

namespace ApiCatalogo.Models
{
    public class Company
    {
        public int CompanyId { get; set; }
        public string? Nome { get; set; }

        [JsonIgnore]
        public ICollection<Order>? Orders { get; set; }
    }
}
