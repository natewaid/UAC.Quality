namespace UAC.Quality.Web.Controllers
{
    using System.Web.Mvc;
    using Repositories;

    public class BaseController : Controller
    {
        protected ISpecProvider specProvider { get; } = Gimme.Collection.Locate<ISpecProvider>();
        protected IProvider alloyTemperProvider { get; } = Gimme.Collection.Locate<IProvider>("alloytemper");
        protected IProvider equivSpecProvider { get; } = Gimme.Collection.Locate<IProvider>("equivspec");
        protected IProvider costImpactProvider { get; } = Gimme.Collection.Locate<IProvider>("costimpact");
        protected IProvider deliveryImpactProvider { get; } = Gimme.Collection.Locate<IProvider>("deliveryimpact");
    }
}