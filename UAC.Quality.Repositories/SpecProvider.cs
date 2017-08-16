namespace UAC.Quality.Repositories
{
    using System.Collections.Generic;
    using System.Data;
    using Core;
    using Flash;
    using Gimme;

    public class SpecProvider : ISpecProvider
    {
        public IEnumerable<Spec> Specs() => Flash.List<Spec>(Collection.Locate<IDbConnection>("quality"), "quality.specs");

        public SpecDetailsResult SpecDetails(int specid)
        {
            var result = new SpecDetailsResult();

            Flash.List(
                Collection.Locate<IDbConnection>("quality"),
                "quality.spec_details",
                new { id = specid },
                (d) => result.Spec = Flash.Bind<Spec>(d),
                (d) => result.SpecAlloyTemper.Add(Flash.Bind<SpecAlloyTemper>(d)),
                (d) => result.EquivSpecs.Add(Flash.Bind<SpecEquiv>(d)),
                (d) => result.SpecCostImpact.Add(Flash.Bind<SpecCostImpact>(d)),
                (d) => result.SpecDeliveryImpact.Add(Flash.Bind<SpecDeliveryImpact>(d)),
                (d) => result.SpecNotes.Add(Flash.Bind<SpecNote>(d))
            );

            return result;
        }

        public int SaveSpec(Spec spec)
        {
            return Flash.Scalar<int>
            (
                Collection.Locate<IDbConnection>("quality"),
                "quality.spec_save",
                new
                {
                    Id = spec.Id,
                    name = spec.Name,
                    customer = spec.Customer,
                    location = spec.Location,
                    title = spec.Title,
                    control = spec.Control,
                    revision = spec.Revision,
                    amendment = spec.Amendment,
                    fileunder = spec.FileUnder,
                    supercededby = spec.SupercededBy,
                    typematerial = spec.TypeMaterial,
                    typeprocess = spec.TypeProcess,
                    typeother = spec.TypeOther,
                    allplants = spec.AllPlants,
                    anaheim = spec.Anaheim,
                    canton = spec.Canton,
                    heavypress = spec.HeavyPress,
                    noexceptions = spec.NoExceptions,
                    waiversrequired = spec.WaiversRequired,
                    limitedscope = spec.LimitedScope,
                    notacceptable = spec.NotAcceptable,
                    onfile = spec.OnFile,
                    notreviewed = spec.NotReviewed,
                    metreviewnotrequired = spec.MetReviewNotRequired,
                    metrevieweveryorder = spec.MetReviewEveryOrder,
                    metreviewrequiredwhen = spec.MetReviewRequiredWhen,
                    metalurgicalreviewwhen = spec.MetalurgicalReviewWhen,
                    reviewedby = spec.ReviewedBy,
                    reviewedat = spec.ReviewedAt,
                    supercedereviewdate = spec.SupercedeReviewDate
                }
            );
        }
    }
}