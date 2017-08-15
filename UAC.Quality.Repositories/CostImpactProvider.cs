namespace UAC.Quality.Repositories
{
    using System.Data;
    using System.Linq;
    using Flash;
    using Gimme;

    public class CostImpactProvider : IProvider
    {
        public void Save(int specid, string costImpacts)
        {
            if (costImpacts == null)
            {
                return;
            }

            costImpacts
                .Split('|')
                .ToList()
                .ForEach(c =>
                    Flash.Execute(Collection.Locate<IDbConnection>("quality"), "quality.spec_cost_impact_add", new { specid, addedcost = c.Split('-')[0], determinedby = c.Split('-')[1] })
                );
        }

        public void Add(int specid, params string[] toAdd)
        {
            var addedcost = toAdd[0];
            var determinedby = toAdd[1];

            Flash.Execute(Collection.Locate<IDbConnection>("quality"), "quality.spec_cost_impact_add", new { specid, addedcost, determinedby });
        }

        public void Delete(int id) => Flash.Execute(Collection.Locate<IDbConnection>("quality"), "quality.spec_cost_impact_delete", new { id });
    }
}