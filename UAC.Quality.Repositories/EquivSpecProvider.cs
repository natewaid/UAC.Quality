namespace UAC.Quality.Repositories
{
    using System.Data;
    using System.Linq;
    using Flash;
    using Gimme;

    public class EquivSpecProvider : IProvider
    {
        public void Save(int specid, string equivSpecs)
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

        public void Add(int specid, params string[] toAdd)
        {
            Flash.Execute(Collection.Locate<IDbConnection>("quality"), "quality.spec_equiv_add", new { specid, specToAdd = toAdd[0] });
        }

        public void Delete(int id) => Flash.Execute(Collection.Locate<IDbConnection>("quality"), "quality.spec_equiv_delete", new { id });

    }
}