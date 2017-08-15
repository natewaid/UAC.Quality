namespace UAC.Quality.Web.Controllers
{
    using System.Web.Mvc;

    public class CostImpactController : BaseController
    {
        [HttpPost]
        [Route("addcostimpact", Name = "spec.addcostimpact")]
        public ActionResult AddCostImpact(int id, string addedcost, string determinedby)
        {
            costImpactProvider.AddCostImpact(id, addedcost, determinedby);

            return Json(new { });
        }

        [HttpPost]
        [Route("deletecostimpact", Name = "spec.deletecostimpact")]
        public ActionResult DeleteCostImpact(int id)
        {
            costImpactProvider.Delete(id);

            return Json(new { });
        }
    }
}