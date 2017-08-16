namespace UAC.Quality.Web.Controllers
{
    using System.Web.Mvc;
    using Models;

    public class SpecController : BaseController
    {        
        [Route("", Name = "spec.index")]
        public ActionResult Index() => View(specProvider.Specs());

        [Route("details", Name = "spec.details")]
        public ActionResult Details()
        {
            return View(new SpecViewModel());
        }

        [Route("details/{id:int}", Name = "spec.details.byid")]
        public ActionResult Details(int id)
        {
            var result = specProvider.SpecDetails(id);
            var model = new SpecViewModel
            {
                Spec = result.Spec,
                EquivSpecs = result.EquivSpecs,
                SpecAlloyTemper = result.SpecAlloyTemper,
                SpecCostImpact = result.SpecCostImpact,
                SpecDeliveryImpact = result.SpecDeliveryImpact,
                SpecNotes = result.SpecNotes
            };

            return View(model);
        }

        [HttpPost]
        [Route("update")]
        public ActionResult Save(SpecViewModel model)
        {
            var id = specProvider.SaveSpec(model.Spec);

            alloyTemperProvider.Save(id, model.AlloyTempersToAdd);

            equivSpecProvider.Save(id, model.EquivSpecsToAdd);

            costImpactProvider.Save(id, model.CostImpactsToAdd);

            deliveryImpactProvider.Save(id, model.DeliveryImpactsToAdd);

            return RedirectToRoute("spec.index");
        }
    }
}