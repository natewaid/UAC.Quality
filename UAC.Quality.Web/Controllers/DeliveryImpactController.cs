namespace UAC.Quality.Web.Controllers
{
    using System.Web.Mvc;

    public class DeliveryImpactController : BaseController
    {
        [HttpPost]
        [Route("adddelimpact", Name = "spec.adddelimpact")]
        public ActionResult AddDeliveryImpact(int id, string impact)
        {
            deliveryImpactProvider.Add(id, impact);

            return Json(new { });
        }

        [HttpPost]
        [Route("deletedelimpact", Name = "spec.deletedelimpact")]
        public ActionResult DeleteDeliveryImpact(int id)
        {
            deliveryImpactProvider.Delete(id);

            return Json(new { });
        }
    }
}