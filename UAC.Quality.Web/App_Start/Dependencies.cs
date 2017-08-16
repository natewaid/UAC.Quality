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

            Collection.Register<ISimpleData, SimpleDataProvider>();
            Collection.Register<ISpecProvider, SpecProvider>();
            Collection.RegisterWithName<IProvider, AlloyTemperProvider>("alloytemper");
            Collection.RegisterWithName<IProvider, EquivSpecProvider>("equivspec");
            Collection.RegisterWithName<IProvider, CostImpactProvider>("costimpact");
            Collection.RegisterWithName<IProvider, DeliveryImpactProvider>("deliveryimpact");
        }
    }
}