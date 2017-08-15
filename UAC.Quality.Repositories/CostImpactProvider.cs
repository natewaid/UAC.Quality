namespace UAC.Quality.Repositories
{
    using System.Data;
    using System.Linq;
    using Flash;
    using Gimme;

    public class CostImpactProvider : ICostImpactProvider
    {
        public void SaveCostImpact(int specid, string costImpacts)
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

        public void AddCostImpact(int specid, string addedcost, string determinedby) => Flash.Execute(Collection.Locate<IDbConnection>("quality"), "quality.spec_cost_impact_add", new { specid, addedcost, determinedby });

        public void Delete(int id) => Flash.Execute(Collection.Locate<IDbConnection>("quality"), "quality.spec_cost_impact_delete", new { id });
    }
}