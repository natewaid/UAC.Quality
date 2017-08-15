namespace UAC.Quality.Repositories
{
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;    
    using Flash;
    using Gimme;

    public class AlloyTemperProvider : IProvider
    {
        public void Save(int specid, string alloyTempers)
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

        public void Add(int specid, params string[] toAdd)
        {
            var alloy = toAdd[0];
            var temper = toAdd[1];

            Flash.Execute(Collection.Locate<IDbConnection>("quality"), "quality.spec_alloy_temper_add", new { specid, alloy, temper });
        }

        public void Delete(int id)
        {
            Flash.Execute(Collection.Locate<IDbConnection>("quality"), "quality.spec_alloy_temper_delete", new { id });
        }
    }
}