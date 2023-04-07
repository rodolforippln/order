using System.Text.Json.Serialization;

namespace ApiCatalogo.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public string? Nome { get; set; }
        public string? Descricao { get; set; }
        public int? CompanyId { get; set; }


        [JsonIgnore]
        public ICollection<Volume>? Volumes { get; set; }

        [JsonIgnore]
        public virtual Company? Company { get; set; }
    }
}
