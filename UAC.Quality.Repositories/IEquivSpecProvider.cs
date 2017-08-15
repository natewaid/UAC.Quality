namespace UAC.Quality.Repositories
{
    public interface IEquivSpecProvider
    {
        void SaveEquivSpec(int specid, string equivSpecs);

        void AddEquivSpec(int specid, string specToAdd);

        void Delete(int id);
    }
}