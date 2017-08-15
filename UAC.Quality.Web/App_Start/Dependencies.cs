namespace UAC.Quality.Web
{
    using System.Configuration;
    using System.Data;
    using System.Data.SqlClient;
    using Gimme;
    using Repositories;

    public class Dependencies
    {
        public static void Register()
        {
            var connStr = ConfigurationManager.ConnectionStrings["quality"].ConnectionString;

            Collection.RegisterAsFactoryWithName<IDbConnection, SqlConnection>("quality", connStr);
            
            Collection.Register<ISpecProvider, SpecProvider>();
            Collection.Register<IAlloyTemperProvider, AlloyTemperProvider>();
            Collection.Register<IEquivSpecProvider, EquivSpecProvider>();
            Collection.Register<ICostImpactProvider, CostImpactProvider>();
            Collection.Register<IDeliveryImpactProvider, DeliveryImpactProvider>();
        }
    }
}