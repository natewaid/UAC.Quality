namespace UAC.Quality.Web.Controllers
{
    using System.Linq;
    using System.Web.Mvc;
    using Gimme;
    using Repositories;

    [RoutePrefix("data")]
    public class DataController : Controller
    {
        private SpecProvider specProvider;

        public DataController()
        {
            specProvider = (SpecProvider)Collection.Locate<ISpecProvider>();
        }

        [HttpGet]
        [Route("alloys", Name = "data.alloys")]
        public JsonResult Alloys()
        {
            var alloys = specProvider.Alloys();

            return Json(alloys, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        [Route("tempers", Name = "data.tempers")]
        public JsonResult Tempers()
        {
            var tempers = specProvider.Tempers();

            return Json(tempers, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        [Route("specs", Name = "data.specs")]
        public JsonResult Specs()
        {
            var specs = specProvider.Specs().Select(s => s.Name);

            return Json(specs, JsonRequestBehavior.AllowGet);
        }
    }
}