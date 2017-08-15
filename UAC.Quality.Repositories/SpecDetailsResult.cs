namespace UAC.Quality.Repositories
{
    using System.Collections.Generic;
    using Core;

    public class SpecDetailsResult
    {
        public Spec Spec { get; set; } = new Spec();
        public List<SpecEquiv> EquivSpecs { get; set; } = new List<SpecEquiv>();
        public List<SpecAlloyTemper> SpecAlloyTemper { get; set; } = new List<SpecAlloyTemper>();
        public List<SpecCostImpact> SpecCostImpact { get; set; } = new List<SpecCostImpact>();
        public List<SpecDeliveryImpact> SpecDeliveryImpact { get; set; } = new List<SpecDeliveryImpact>();
        public List<SpecNote> SpecNotes { get; set; } = new List<SpecNote>();
    }
}