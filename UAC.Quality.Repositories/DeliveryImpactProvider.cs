namespace UAC.Quality.Repositories
{
    using System.Data;
    using System.Linq;
    using Gimme;
    using Flash;

    public class DeliveryImpactProvider : IProvider
    {
        public void Save(int specid, string deliveryImpacts)
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

        public void Add(int specid, params string[] toAdd)
        {
            Flash.Execute(Collection.Locate<IDbConnection>("quality"), "quality.spec_delivery_impact_add", new { specid, impact = toAdd[0] });
        }

        public void Delete(int id) => Flash.Execute(Collection.Locate<IDbConnection>("quality"), "quality.spec_delivery_impact_delete", new { id });

    }
}