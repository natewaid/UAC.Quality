namespace UAC.Quality.Repositories
{
    using System.Data;
    using System.Linq;    
    using Flash;
    using Gimme;

    public class AlloyTemperProvider : IAlloyTemperProvider
    {
        public void SaveSpecAlloyTemper(int specid, string alloyTempers)
        {
            if (alloyTempers == null)
            {
                return;
            }

            alloyTempers
                .Split('|')
                .ToList()
                .ForEach(a =>
                    Flash.Execute(Collection.Locate<IDbConnection>("quality"), "quality.spec_alloy_temper_add", new { specid, alloy = a.Split('-')[0], temper = a.Split('-')[1] })
                );
        }

        public void AddAlloyTemper(int specid, string alloy, string temper) => Flash.Execute(Collection.Locate<IDbConnection>("quality"), "quality.spec_alloy_temper_add", new { specid, alloy, temper });

        public void Delete(int id) => Flash.Execute(Collection.Locate<IDbConnection>("quality"), "quality.spec_alloy_temper_delete", new { id });
    }
}