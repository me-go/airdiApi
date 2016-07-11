namespace DapperApi.Models
{
    public class ListType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float? CaliberInches { get; set; }
        public float? CaliberMetricDiameter { get; set; }
        public int? CaliberMetricLength { get; set; }

    }
}