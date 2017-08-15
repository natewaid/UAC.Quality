namespace UAC.Quality.Web.Controllers
{
    using System.Web.Mvc;
    using Repositories;

    public class BaseController : Controller
    {
        protected ISpecProvider specProvider { get; } = Gimme.Collection.Locate<ISpecProvider>();
        protected IAlloyTemperProvider alloyTemperProvider { get; } = Gimme.Collection.Locate<IAlloyTemperProvider>();
        protected IEquivSpecProvider equivSpecProvider { get; } = Gimme.Collection.Locate<IEquivSpecProvider>();
        protected ICostImpactProvider costImpactProvider { get; } = Gimme.Collection.Locate<ICostImpactProvider>();
        protected IDeliveryImpactProvider deliveryImpactProvider { get; } = Gimme.Collection.Locate<IDeliveryImpactProvider>();
    }
}