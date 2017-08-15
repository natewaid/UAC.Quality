namespace UAC.Quality.Models
{
    using System.Collections.Generic;
    using Core;

    public class SpecViewModel
    {
        public Spec Spec { get; set; } = new Spec();
        public IEnumerable<SpecEquiv> EquivSpecs { get; set; } = new List<SpecEquiv>();
        public IEnumerable<SpecAlloyTemper> SpecAlloyTemper { get; set; } = new List<SpecAlloyTemper>();
        public IEnumerable<SpecCostImpact> SpecCostImpact { get; set; } = new List<SpecCostImpact>();
        public IEnumerable<SpecDeliveryImpact> SpecDeliveryImpact { get; set; } = new List<SpecDeliveryImpact>();
        public IEnumerable<SpecNote> SpecNotes { get; set; } = new List<SpecNote>();
        public string AlloyTempersToAdd { get; set; }
        public string EquivSpecsToAdd { get; set; }
        public string CostImpactsToAdd { get; set; }
        public string DeliveryImpactsToAdd { get; set; }
    }
}