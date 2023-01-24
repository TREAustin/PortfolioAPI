using System.Text.Json.Serialization;

namespace PortfolioAPI.Models
{
    public class Examples
    {
        [JsonPropertyName("id")]
        public int? Id { get; set; }
        [JsonPropertyName("name")]
        public string? Name { get; set; }
        [JsonPropertyName("description")]
        public string? Description { get; set; }
        [JsonPropertyName("subDescription")]
        public string? SubDescription { get; set; }
        [JsonPropertyName("languages")]
        public List<Langauge> Langauges { get; set; } = new();
        [JsonPropertyName("frameworks")]
        public List<Framework> Frameworks { get; set; } = new();
        [JsonPropertyName("operatingSystems")]
        public List<OperatingSystem> OperatingSystems { get; set; } = new();
        [JsonPropertyName("images")]
        public List<Image> Images { get; set; } = new List<Image>();

        public Examples() { }

        public Examples(Example example, List<Langauge> langauges, List<Framework> frameworks, List<OperatingSystem> operatingSystems, List<Image> images)
        {
            Id = example.Id;
            Name = example.Name;
            Description = example.Description;
            SubDescription = example.SubDescription;
            Langauges = langauges;
            Frameworks = frameworks;
            OperatingSystems = operatingSystems;
            Images = images;
        }
    }
}
