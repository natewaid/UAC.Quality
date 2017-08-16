namespace UAC.Quality.Web.Controllers
{
    using System.Linq;
    using System.Web.Mvc;
    using Gimme;
    using Repositories;

    [RoutePrefix("data")]
    public class SimpleDataController : Controller
    {
        private ISpecProvider specProvider;
        private ISimpleData simpleDataProvider;

        public SimpleDataController()
        {
            specProvider = Collection.Locate<ISpecProvider>();
            simpleDataProvider = Collection.Locate<ISimpleData>();
        }

        [HttpGet]
        [Route("alloys", Name = "data.alloys")]
        public JsonResult Alloys()
        {
            var alloys = simpleDataProvider.Alloys();

            return Json(alloys, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        [Route("tempers", Name = "data.tempers")]
        public JsonResult Tempers()
        {
            var tempers = simpleDataProvider.Tempers();

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