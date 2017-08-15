namespace UAC.Quality.Repositories
{
    public interface IProvider
    {
        void Save(int id, string toSave);

        void Add(int id, params string[] toAdd);

        void Delete(int id);
    }
}
