namespace UAC.Quality.Core
{
    public class SpecCostImpact
    {
        public int Id { get; set; }
        public int SpecId { get; set; }
        public string AddedCost { get; set; }
        public string DeterminedBy { get; set; }
    }
}