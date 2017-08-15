namespace UAC.Quality.Web.Controllers
{
    using System.Linq;
    using System.Web.Mvc;
    using Newtonsoft.Json;
    using Gimme;

    [RoutePrefix("data")]
    public class DataController : Controller
    {
        //private ISpecProvider specProvider;
        //private IAlloyTemperProvider alloyTemperProvider;

       // public DataController()
        //{
        //    specProvider = Collection.Locate<ISpecProvider>();
        //    alloyTemperProvider = Collection.Locate<IAlloyTemperProvider>();
       // }

        //[HttpGet]
        //[Route("alloys", Name = "data.alloys")]
        //public JsonResult Alloys()
        //{
        //    var alloys = alloyTemperProvider.Alloys();

        //    return Json(alloys, JsonRequestBehavior.AllowGet);
        //}

        //[HttpGet]
        //[Route("tempers", Name = "data.tempers")]
        //public JsonResult Tempers()
        //{
        //    var tempers = alloyTemperProvider.Tempers();

        //    return Json(tempers, JsonRequestBehavior.AllowGet);
        //}

        //[HttpGet]
        //[Route("specs", Name = "data.specs")]
        //public JsonResult Specs()
        //{
        //    var specs = specProvider.Specs().Select(s => s.Name);

        //    return Json(specs, JsonRequestBehavior.AllowGet);
        //}
    }
}