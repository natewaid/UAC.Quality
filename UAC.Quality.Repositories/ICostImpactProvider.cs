namespace UAC.Quality.Repositories
{
    public interface ICostImpactProvider
    {
        void SaveCostImpact(int specid, string costImpacts);

        void AddCostImpact(int specid, string addedcost, string determinedby);

        void Delete(int id);
    }
}
