namespace UAC.Quality.Repositories
{
    using System.Data;
    using System.Linq;
    using Flash;
    using Gimme;

    public class EquivSpecProvider : IEquivSpecProvider
    {
        public void SaveEquivSpec(int specid, string equivSpecs)
        {
            if (equivSpecs == null)
            {
                return;
            }

            equivSpecs
                .Split('|')
                .ToList()
                .ForEach(s =>
                    Flash.Execute(Collection.Locate<IDbConnection>("quality"), "quality.spec_equiv_add", new { specid, specToAdd = s })
                );
        }

        public void AddEquivSpec(int specid, string specToAdd) => Flash.Execute(Collection.Locate<IDbConnection>("quality"), "quality.spec_equiv_add", new { specid, specToAdd });

        public void Delete(int id) => Flash.Execute(Collection.Locate<IDbConnection>("quality"), "quality.spec_equiv_delete", new { id });

    }
}