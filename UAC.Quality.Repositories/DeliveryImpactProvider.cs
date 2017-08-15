namespace UAC.Quality.Repositories
{
    using System.Data;
    using System.Linq;
    using Gimme;
    using Flash;

    public class DeliveryImpactProvider : IDeliveryImpactProvider
    {
        public void SaveDeliveryImpact(int specid, string deliveryImpacts)
        {
            if (deliveryImpacts == null)
            {
                return;
            }

            deliveryImpacts
                .Split('|')
                .ToList()
                .ForEach(d =>
                    Flash.Execute(Collection.Locate<IDbConnection>("quality"), "quality.spec_delivery_impact_add", new { specid, impact = d })
                );
        }

        public void AddDeliveryImpact(int specid, string impact) => Flash.Execute(Collection.Locate<IDbConnection>("quality"), "quality.spec_delivery_impact_add", new { specid, impact });

        public void Delete(int id) => Flash.Execute(Collection.Locate<IDbConnection>("quality"), "quality.spec_delivery_impact_delete", new { id });

    }
}