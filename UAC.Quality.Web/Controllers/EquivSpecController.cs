namespace UAC.Quality.Web.Controllers
{
    using System.Web.Mvc;

    public class EquivSpecController : BaseController
    {
        [HttpPost]
        [Route("addequivspec", Name = "spec.addequivspec")]
        public ActionResult AddEquivSpec(int id, string specToAdd)
        {
            equivSpecProvider.Add(id, specToAdd);

            return Json(new { });
        }

        [HttpPost]
        [Route("deleteequivspec", Name = "spec.deleteequivspec")]
        public ActionResult DeleteEquivSpec(int id)
        {
            equivSpecProvider.Delete(id);

            return Json(new { });
        }
    }
}