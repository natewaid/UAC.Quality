namespace UAC.Quality.Web.Controllers
{
    using System.Web.Mvc;

    public class AlloyTemperController : BaseController
    {
        [HttpPost]
        [Route("addalloytemper", Name = "spec.addalloytemper")]
        public ActionResult AddAlloyTemper(int id, string alloy, string temper)
        {
            alloyTemperProvider.Add(id, alloy, temper);

            return Json(new { });
        }

        [HttpPost]
        [Route("deletealloytemper", Name = "spec.deletealloytemper")]
        public ActionResult DeleteAlloyTemper(int id)
        {
            alloyTemperProvider.Delete(id);

            return Json(new { });
        }
    }
}