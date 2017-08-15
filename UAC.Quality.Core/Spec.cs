
namespace UAC.Quality.Core
{
    using System;

    public class Spec
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Customer { get; set; }
        public string Location { get; set; }
        public string Title { get; set; }
        public string Control { get; set; }
        public string Revision { get; set; }
        public string Amendment { get; set; }
        public string FileUnder { get; set; }
        public string SupercededBy { get; set; }
        public bool TypeMaterial { get; set; }
        public bool TypeProcess { get; set; }
        public bool TypeOther { get; set; }
        public bool AllPlants { get; set; }
        public bool Canton { get; set; }
        public bool Anaheim { get; set; }
        public bool HeavyPress { get; set; }
        public bool NoExceptions { get; set; }
        public bool WaiversRequired { get; set; }
        public bool LimitedScope { get; set; }
        public bool NotAcceptable { get; set; }
        public bool OnFile { get; set; }
        public bool NotReviewed { get; set; }
        public bool MetReviewNotRequired { get; set; }
        public bool MetReviewEveryOrder { get; set; }
        public bool MetReviewRequiredWhen { get; set; }
        public string MetalurgicalReviewWhen { get; set; }
        public string ReviewedBy { get; set; }
        public DateTime ReviewedAt { get; set; } = DateTime.Today;
        public DateTime SupercedeReviewDate { get; set; } = DateTime.Today;
        public string CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Today;
        public string UpdatedBy { get; set; }
        public DateTime UpdatedAt { get; set; } = DateTime.Today;
    }
}